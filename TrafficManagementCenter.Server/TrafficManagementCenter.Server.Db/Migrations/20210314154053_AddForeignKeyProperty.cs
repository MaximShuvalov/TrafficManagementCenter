using Microsoft.EntityFrameworkCore.Migrations;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    public partial class AddForeignKeyProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealKey",
                table: "Appeal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_SubtypeAppeals_SubtypeKey",
                table: "Appeal");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_ClassAppealKey",
                table: "Appeal");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_SubtypeKey",
                table: "Appeal");

            migrationBuilder.DropColumn(
                name: "ClassAppealKey",
                table: "Appeal");

            migrationBuilder.DropColumn(
                name: "SubtypeKey",
                table: "Appeal");

            migrationBuilder.AddColumn<long>(
                name: "ClassAppealId",
                table: "Appeal",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SubtypeId",
                table: "Appeal",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_ClassAppealId",
                table: "Appeal",
                column: "ClassAppealId");

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_SubtypeId",
                table: "Appeal",
                column: "SubtypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealId",
                table: "Appeal",
                column: "ClassAppealId",
                principalTable: "ClassAppeal",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_SubtypeAppeals_SubtypeId",
                table: "Appeal",
                column: "SubtypeId",
                principalTable: "SubtypeAppeals",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealId",
                table: "Appeal");

            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_SubtypeAppeals_SubtypeId",
                table: "Appeal");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_ClassAppealId",
                table: "Appeal");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_SubtypeId",
                table: "Appeal");

            migrationBuilder.DropColumn(
                name: "ClassAppealId",
                table: "Appeal");

            migrationBuilder.DropColumn(
                name: "SubtypeId",
                table: "Appeal");

            migrationBuilder.AddColumn<long>(
                name: "ClassAppealKey",
                table: "Appeal",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SubtypeKey",
                table: "Appeal",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_ClassAppealKey",
                table: "Appeal",
                column: "ClassAppealKey");

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_SubtypeKey",
                table: "Appeal",
                column: "SubtypeKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealKey",
                table: "Appeal",
                column: "ClassAppealKey",
                principalTable: "ClassAppeal",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_SubtypeAppeals_SubtypeKey",
                table: "Appeal",
                column: "SubtypeKey",
                principalTable: "SubtypeAppeals",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
