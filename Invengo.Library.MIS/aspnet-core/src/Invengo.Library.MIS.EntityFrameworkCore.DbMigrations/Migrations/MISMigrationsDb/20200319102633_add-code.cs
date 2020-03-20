using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invengo.Library.MIS.Migrations.MISMigrationsDb
{
    public partial class addcode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MisTemplate_MisAttachment_Thumbnail",
                table: "MisTemplate");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "MisAttachment");

            migrationBuilder.AlterColumn<Guid>(
                name: "Thumbnail",
                table: "MisTemplate",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "MisTemplate",
                maxLength: 128,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_MisTemplate_MisAttachment_Thumbnail",
                table: "MisTemplate",
                column: "Thumbnail",
                principalTable: "MisAttachment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MisTemplate_MisAttachment_Thumbnail",
                table: "MisTemplate");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "MisTemplate");

            migrationBuilder.AlterColumn<Guid>(
                name: "Thumbnail",
                table: "MisTemplate",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "MisAttachment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MisTemplate_MisAttachment_Thumbnail",
                table: "MisTemplate",
                column: "Thumbnail",
                principalTable: "MisAttachment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
