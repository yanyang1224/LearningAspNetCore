using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invengo.Library.MIS.Migrations.RFIDMigrationsDb
{
    public partial class init_rfid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookInfo",
                columns: table => new
                {
                    szBookID = table.Column<string>(nullable: false),
                    nLabelID = table.Column<string>(nullable: true),
                    nEPCOrder = table.Column<long>(nullable: true),
                    szBookCaseNo = table.Column<string>(nullable: true),
                    nBooksTypeID = table.Column<int>(nullable: true),
                    nPublishID = table.Column<int>(nullable: true),
                    szBookSSID = table.Column<string>(nullable: true),
                    szSeriesID = table.Column<string>(nullable: true),
                    nBookStatus = table.Column<int>(nullable: true),
                    szCardID = table.Column<string>(nullable: true),
                    dtBorrowDate = table.Column<DateTime>(nullable: true),
                    dtNeedBackDate = table.Column<DateTime>(nullable: true),
                    dtLastRead = table.Column<DateTime>(nullable: true),
                    nStaffID = table.Column<int>(nullable: true),
                    szISBN = table.Column<string>(nullable: true),
                    szName = table.Column<string>(nullable: true),
                    szAuthor = table.Column<string>(nullable: true),
                    fPrice = table.Column<decimal>(nullable: true),
                    dtPublishDate = table.Column<DateTime>(nullable: true),
                    nPages = table.Column<int>(nullable: true),
                    szBookIndex = table.Column<string>(nullable: true),
                    szMainWord = table.Column<string>(nullable: true),
                    szClassNO = table.Column<string>(nullable: true),
                    szlibCD = table.Column<string>(nullable: true),
                    szMemo = table.Column<string>(nullable: true),
                    nStartYear = table.Column<int>(nullable: true),
                    szPublishyear = table.Column<string>(nullable: true),
                    nConvertStaffID = table.Column<int>(nullable: true),
                    dtConvertDate = table.Column<DateTime>(nullable: true),
                    nUpdateStaffID = table.Column<int>(nullable: true),
                    dtUpdateDate = table.Column<DateTime>(nullable: true),
                    szMoneyType = table.Column<string>(nullable: true),
                    szPretendIndexNum = table.Column<string>(nullable: true),
                    bForceSortCase = table.Column<bool>(nullable: true),
                    szConvertStaff = table.Column<string>(nullable: true),
                    dtAutoUpdate = table.Column<DateTime>(nullable: true),
                    nRenewTime = table.Column<int>(nullable: true),
                    nBookLenType = table.Column<int>(nullable: true),
                    szBookLen = table.Column<string>(nullable: true),
                    nBookThickness = table.Column<int>(nullable: true),
                    nSetInfoCount = table.Column<int>(nullable: true),
                    nSetInfoOrder = table.Column<int>(nullable: true),
                    szTemplibCD = table.Column<string>(nullable: true),
                    szMedicalLib = table.Column<string>(nullable: true),
                    bBookLabelChecked = table.Column<bool>(nullable: true),
                    bLostBookFlag = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookInfo", x => x.szBookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookInfo");
        }
    }
}
