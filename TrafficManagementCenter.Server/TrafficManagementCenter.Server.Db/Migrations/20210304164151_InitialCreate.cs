using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TrafficManagementCenter.Server.Db.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeAppeal",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeAppeal", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "SubtypeAppeals",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Note = table.Column<string>(type: "text", nullable: true),
                    TypeKey = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubtypeAppeals", x => x.Key);
                    table.ForeignKey(
                        name: "FK_SubtypeAppeals_TypeAppeal_TypeKey",
                        column: x => x.TypeKey,
                        principalTable: "TypeAppeal",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appeal",
                columns: table => new
                {
                    Key = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SubtypeKey = table.Column<long>(type: "bigint", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Text = table.Column<string>(type: "text", nullable: true),
                    Attachment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appeal", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Appeal_SubtypeAppeals_SubtypeKey",
                        column: x => x.SubtypeKey,
                        principalTable: "SubtypeAppeals",
                        principalColumn: "Key",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appeal_SubtypeKey",
                table: "Appeal",
                column: "SubtypeKey");

            migrationBuilder.CreateIndex(
                name: "IX_SubtypeAppeals_TypeKey",
                table: "SubtypeAppeals",
                column: "TypeKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appeal");

            migrationBuilder.DropTable(
                name: "SubtypeAppeals");

            migrationBuilder.DropTable(
                name: "TypeAppeal");
        }
    }
}
