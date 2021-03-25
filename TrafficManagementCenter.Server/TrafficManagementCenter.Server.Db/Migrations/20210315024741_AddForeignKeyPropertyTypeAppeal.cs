using Microsoft.EntityFrameworkCore.Migrations;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    public partial class AddForeignKeyPropertyTypeAppeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubtypeAppeals_TypeAppeal_TypeKey",
                table: "SubtypeAppeals");

            migrationBuilder.DropIndex(
                name: "IX_SubtypeAppeals_TypeKey",
                table: "SubtypeAppeals");

            migrationBuilder.DropColumn(
                name: "TypeKey",
                table: "SubtypeAppeals");

            migrationBuilder.AddColumn<long>(
                name: "TypeId",
                table: "SubtypeAppeals",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_SubtypeAppeals_TypeId",
                table: "SubtypeAppeals",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubtypeAppeals_TypeAppeal_TypeId",
                table: "SubtypeAppeals",
                column: "TypeId",
                principalTable: "TypeAppeal",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubtypeAppeals_TypeAppeal_TypeId",
                table: "SubtypeAppeals");

            migrationBuilder.DropIndex(
                name: "IX_SubtypeAppeals_TypeId",
                table: "SubtypeAppeals");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "SubtypeAppeals");

            migrationBuilder.AddColumn<long>(
                name: "TypeKey",
                table: "SubtypeAppeals",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubtypeAppeals_TypeKey",
                table: "SubtypeAppeals",
                column: "TypeKey");

            migrationBuilder.AddForeignKey(
                name: "FK_SubtypeAppeals_TypeAppeal_TypeKey",
                table: "SubtypeAppeals",
                column: "TypeKey",
                principalTable: "TypeAppeal",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
