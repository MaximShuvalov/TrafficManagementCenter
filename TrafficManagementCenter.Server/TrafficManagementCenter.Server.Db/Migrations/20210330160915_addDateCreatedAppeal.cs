using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    public partial class addDateCreatedAppeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_AppealClass_ClassAppealId",
                table: "Appeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppealClass",
                table: "AppealClass");

            migrationBuilder.RenameTable(
                name: "AppealClass",
                newName: "ClassAppeal");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreate",
                table: "Appeal",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassAppeal",
                table: "ClassAppeal",
                column: "Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealId",
                table: "Appeal",
                column: "ClassAppealId",
                principalTable: "ClassAppeal",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_ClassAppeal_ClassAppealId",
                table: "Appeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassAppeal",
                table: "ClassAppeal");

            migrationBuilder.DropColumn(
                name: "DateCreate",
                table: "Appeal");

            migrationBuilder.RenameTable(
                name: "ClassAppeal",
                newName: "AppealClass");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppealClass",
                table: "AppealClass",
                column: "Key");

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_AppealClass_ClassAppealId",
                table: "Appeal",
                column: "ClassAppealId",
                principalTable: "AppealClass",
                principalColumn: "Key",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
