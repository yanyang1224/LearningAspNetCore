using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invengo.Library.MIS.Migrations.MISMigrationsDb
{
    public partial class addatt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "MisAttachment",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "MisAttachment",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MisAttachment",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "MisAttachment",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "MisAttachment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "MisAttachment");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "MisAttachment");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MisAttachment");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "MisAttachment");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "MisAttachment");
        }
    }
}
