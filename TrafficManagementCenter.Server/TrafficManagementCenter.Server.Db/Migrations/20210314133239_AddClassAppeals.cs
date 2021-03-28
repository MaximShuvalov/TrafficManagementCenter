using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    public partial class AddClassAppeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppealClass",
                table: "Appeal");

            migrationBuilder.AddColumn<long>(
                name: "ClassAppealKey",
                table: "Appeal",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppealClass",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassAppeal", x => x.Key);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_ClassAppealKey",
                table: "Appeal",
                column: "ClassAppealKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealKey",
                table: "Appeal",
                column: "ClassAppealKey",
                principalTable: "AppealClass",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealKey",
                table: "Appeal");

            migrationBuilder.DropTable(
                name: "AppealClass");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_ClassAppealKey",
                table: "Appeal");

            migrationBuilder.DropColumn(
                name: "ClassAppealKey",
                table: "Appeal");

            migrationBuilder.AddColumn<int>(
                name: "AppealClass",
                table: "Appeal",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
