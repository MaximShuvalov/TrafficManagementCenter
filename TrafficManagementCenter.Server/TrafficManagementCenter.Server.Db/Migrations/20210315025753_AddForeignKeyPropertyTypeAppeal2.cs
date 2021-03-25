using Microsoft.EntityFrameworkCore.Migrations;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    public partial class AddForeignKeyPropertyTypeAppeal2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubtypeAppeals_TypeAppeal_TypeId",
                table: "SubtypeAppeals");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "SubtypeAppeals",
                newName: "TypesId");

            migrationBuilder.RenameIndex(
                name: "IX_SubtypeAppeals_TypeId",
                table: "SubtypeAppeals",
                newName: "IX_SubtypeAppeals_TypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubtypeAppeals_TypeAppeal_TypesId",
                table: "SubtypeAppeals",
                column: "TypesId",
                principalTable: "TypeAppeal",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubtypeAppeals_TypeAppeal_TypesId",
                table: "SubtypeAppeals");

            migrationBuilder.RenameColumn(
                name: "TypesId",
                table: "SubtypeAppeals",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_SubtypeAppeals_TypesId",
                table: "SubtypeAppeals",
                newName: "IX_SubtypeAppeals_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubtypeAppeals_TypeAppeal_TypeId",
                table: "SubtypeAppeals",
                column: "TypeId",
                principalTable: "TypeAppeal",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
