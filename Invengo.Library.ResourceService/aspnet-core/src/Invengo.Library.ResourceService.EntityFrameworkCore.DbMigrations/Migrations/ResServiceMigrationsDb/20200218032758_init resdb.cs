using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invengo.Library.ResourceService.Migrations.ResServiceMigrationsDb
{
    public partial class initresdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResNotFoundBook",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ISBN = table.Column<string>(nullable: true),
                    IsCrawl = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResNotFoundBook", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResNotFoundBook");
        }
    }
}
