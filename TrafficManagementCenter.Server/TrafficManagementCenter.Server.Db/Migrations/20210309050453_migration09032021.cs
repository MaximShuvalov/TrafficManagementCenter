using Microsoft.EntityFrameworkCore.Migrations;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    public partial class migration09032021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppealClass",
                table: "Appeal",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppealClass",
                table: "Appeal");
        }
    }
}
