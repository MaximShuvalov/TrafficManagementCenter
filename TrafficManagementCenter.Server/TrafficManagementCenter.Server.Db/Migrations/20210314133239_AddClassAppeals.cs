using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    public partial class AddClassAppeals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassAppeal",
                table: "Appeal");

            migrationBuilder.AddColumn<long>(
                name: "ClassAppealKey",
                table: "Appeal",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClassAppeal",
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
                principalTable: "ClassAppeal",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealKey",
                table: "Appeal");

            migrationBuilder.DropTable(
                name: "ClassAppeal");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_ClassAppealKey",
                table: "Appeal");

            migrationBuilder.DropColumn(
                name: "ClassAppealKey",
                table: "Appeal");

            migrationBuilder.AddColumn<int>(
                name: "ClassAppeal",
                table: "Appeal",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
