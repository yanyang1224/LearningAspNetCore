using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invengo.Library.MIS.Migrations.MISMigrationsDb
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MisActivity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Subject = table.Column<string>(maxLength: 128, nullable: false),
                    BeginTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(maxLength: 128, nullable: false),
                    Crowd = table.Column<string>(maxLength: 128, nullable: false),
                    SortCode = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: false),
                    Sponsor = table.Column<string>(maxLength: 64, nullable: true),
                    Organizer = table.Column<string>(maxLength: 64, nullable: true),
                    Remark = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisActivity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MisAttachment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Length = table.Column<long>(nullable: false),
                    Extension = table.Column<string>(maxLength: 64, nullable: true),
                    AttachmentApplyType = table.Column<byte>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisAttachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MisMediaInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    MediaType = table.Column<byte>(nullable: false),
                    SortCode = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Remark = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisMediaInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MisNews",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Type = table.Column<byte>(nullable: false),
                    Title = table.Column<string>(maxLength: 256, nullable: false),
                    Author = table.Column<string>(maxLength: 64, nullable: true),
                    Editor = table.Column<string>(maxLength: 64, nullable: false),
                    Tags = table.Column<string>(maxLength: 128, nullable: true),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    SourcesName = table.Column<string>(maxLength: 64, nullable: true),
                    SourcesAddress = table.Column<string>(maxLength: 128, nullable: true),
                    ReleaseTime = table.Column<DateTime>(nullable: false),
                    SortCode = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false),
                    Content = table.Column<string>(nullable: false),
                    Remark = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisNews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MisTemplate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Thumbnail = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 256, nullable: true),
                    Config = table.Column<string>(nullable: true),
                    RootId = table.Column<Guid>(nullable: true),
                    Remark = table.Column<string>(maxLength: 256, nullable: true),
                    TenantId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisTemplate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MisTemplate_MisAttachment_Thumbnail",
                        column: x => x.Thumbnail,
                        principalTable: "MisAttachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MisTenantConfig",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    LibraryName = table.Column<string>(maxLength: 128, nullable: false),
                    Logo = table.Column<Guid>(nullable: true),
                    OpenTime = table.Column<string>(maxLength: 256, nullable: true),
                    City = table.Column<string>(maxLength: 32, nullable: true),
                    Address = table.Column<string>(maxLength: 256, nullable: true),
                    TemplateId = table.Column<Guid>(nullable: false),
                    TenantId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MisTenantConfig", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MisTenantConfig_MisTemplate_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "MisTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MisTemplate_Thumbnail",
                table: "MisTemplate",
                column: "Thumbnail");

            migrationBuilder.CreateIndex(
                name: "IX_MisTenantConfig_TemplateId",
                table: "MisTenantConfig",
                column: "TemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MisActivity");

            migrationBuilder.DropTable(
                name: "MisMediaInfo");

            migrationBuilder.DropTable(
                name: "MisNews");

            migrationBuilder.DropTable(
                name: "MisTenantConfig");

            migrationBuilder.DropTable(
                name: "MisTemplate");

            migrationBuilder.DropTable(
                name: "MisAttachment");
        }
    }
}
