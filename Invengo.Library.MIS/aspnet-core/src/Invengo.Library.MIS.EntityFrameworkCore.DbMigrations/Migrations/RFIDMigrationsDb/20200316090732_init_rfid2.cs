using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invengo.Library.MIS.Migrations.RFIDMigrationsDb
{
    public partial class init_rfid2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BorrowHisIndex",
                columns: table => new
                {
                    nHisIndexID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dtOperateDate = table.Column<DateTime>(nullable: true),
                    nOperateType = table.Column<int>(nullable: true),
                    szIPAdd = table.Column<string>(nullable: true),
                    szMacAdd = table.Column<string>(nullable: true),
                    szMachineName = table.Column<string>(nullable: true),
                    nStaffID = table.Column<int>(nullable: true),
                    szGlideID = table.Column<string>(nullable: true),
                    nGlideIndex = table.Column<int>(nullable: true),
                    nSucCount = table.Column<int>(nullable: true),
                    nFailCount = table.Column<int>(nullable: true),
                    szReaderID = table.Column<string>(nullable: true),
                    szReaderName = table.Column<string>(nullable: true),
                    szReaderPwd = table.Column<string>(nullable: true),
                    szInterLendNO = table.Column<string>(nullable: true),
                    szInterLendLib = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowHisIndex", x => x.nHisIndexID);
                });

            migrationBuilder.CreateTable(
                name: "BorrowHistory",
                columns: table => new
                {
                    nHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nHisIndexID = table.Column<int>(nullable: true),
                    szBookID = table.Column<string>(nullable: true),
                    szReaderID = table.Column<string>(nullable: true),
                    bResult = table.Column<bool>(nullable: true),
                    szMemo = table.Column<string>(nullable: true),
                    dtNeedBack = table.Column<DateTime>(nullable: true),
                    szBookIndex = table.Column<string>(nullable: true),
                    bBooking = table.Column<bool>(nullable: false),
                    szBookName = table.Column<string>(nullable: true),
                    szReaderName = table.Column<string>(nullable: true),
                    nBooksTypeID = table.Column<int>(nullable: true),
                    szBooksType = table.Column<string>(nullable: true),
                    szLibCDByType = table.Column<string>(nullable: true),
                    nHavePrint = table.Column<short>(nullable: true),
                    szCheckInfo = table.Column<string>(nullable: true),
                    szCardType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowHistory", x => x.nHistoryID);
                });

            migrationBuilder.CreateTable(
                name: "CardType",
                columns: table => new
                {
                    nCardTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    szCardType = table.Column<string>(nullable: true),
                    nLevel = table.Column<int>(nullable: true),
                    nStaffID = table.Column<int>(nullable: true),
                    szStaffName = table.Column<string>(nullable: true),
                    dtAddDate = table.Column<DateTime>(nullable: true),
                    fDeposit = table.Column<double>(nullable: true),
                    ValidDay = table.Column<int>(nullable: true),
                    szILSTypeCode = table.Column<string>(nullable: true),
                    beginTime = table.Column<string>(nullable: true),
                    endTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardType", x => x.nCardTypeID);
                });

            migrationBuilder.CreateTable(
                name: "CRD_TRANS_Recd",
                columns: table => new
                {
                    nID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    szIdentifyCard = table.Column<string>(nullable: true),
                    szReaderID = table.Column<string>(nullable: true),
                    szName = table.Column<string>(nullable: true),
                    nCardID = table.Column<string>(nullable: true),
                    nCardTypeID = table.Column<int>(nullable: true),
                    fDeposit = table.Column<decimal>(nullable: true),
                    szOperateDesc = table.Column<string>(nullable: true),
                    szRemark = table.Column<string>(nullable: true),
                    dtTransDate = table.Column<DateTime>(nullable: true),
                    bError = table.Column<bool>(nullable: true),
                    bAddReaderRsult = table.Column<bool>(nullable: true),
                    dtTransBegin = table.Column<DateTime>(nullable: true),
                    fNeedDeposit = table.Column<decimal>(nullable: true),
                    bSendCard = table.Column<bool>(nullable: true),
                    dtSendCard = table.Column<DateTime>(nullable: true),
                    bReBackCard = table.Column<bool>(nullable: true),
                    szCardDevice = table.Column<string>(nullable: true),
                    szStep = table.Column<string>(nullable: true),
                    szDeviceName = table.Column<string>(nullable: true),
                    nOperateType = table.Column<short>(nullable: false),
                    bSettleAccounts = table.Column<bool>(nullable: false),
                    dtSettleAccounts = table.Column<DateTime>(nullable: true),
                    szStaffName = table.Column<string>(nullable: true),
                    nRecordStep = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRD_TRANS_Recd", x => x.nID);
                });

            migrationBuilder.CreateTable(
                name: "DeviceInfo",
                columns: table => new
                {
                    nDeviceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    szDeviceName = table.Column<string>(nullable: true),
                    nTypeNo = table.Column<int>(nullable: true),
                    szIP = table.Column<string>(nullable: true),
                    nBuildingNo = table.Column<int>(nullable: false),
                    nFloorNo = table.Column<int>(nullable: false),
                    nRoomNo = table.Column<int>(nullable: false),
                    nXCoordinate = table.Column<int>(nullable: false),
                    nYCoordinate = table.Column<int>(nullable: false),
                    nVideoNum = table.Column<int>(nullable: false),
                    nVideoChannel1 = table.Column<int>(nullable: false),
                    nVideoChannel2 = table.Column<int>(nullable: false),
                    nVideoChannel3 = table.Column<int>(nullable: false),
                    nVideoChannel4 = table.Column<int>(nullable: false),
                    bIsValid = table.Column<bool>(nullable: false),
                    dtUpdateDate = table.Column<DateTime>(nullable: true),
                    nStaffID = table.Column<int>(nullable: true),
                    nSubSystemID = table.Column<int>(nullable: true),
                    bAutoSaveVideo = table.Column<bool>(nullable: true),
                    szDescription = table.Column<string>(nullable: true),
                    bCanPing = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceInfo", x => x.nDeviceID);
                });

            migrationBuilder.CreateTable(
                name: "duStaff",
                columns: table => new
                {
                    nStaffID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    szName = table.Column<string>(nullable: true),
                    szUserName = table.Column<string>(nullable: true),
                    szPassword = table.Column<string>(nullable: true),
                    bIsValid = table.Column<bool>(nullable: true),
                    bSex = table.Column<bool>(nullable: true),
                    szTelephone = table.Column<string>(nullable: true),
                    szAddress = table.Column<string>(nullable: true),
                    bIsAdmin = table.Column<bool>(nullable: true),
                    nDeptID = table.Column<int>(nullable: true),
                    szFinger = table.Column<string>(nullable: true),
                    szMobile = table.Column<string>(nullable: true),
                    szEMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_duStaff", x => x.nStaffID);
                });

            migrationBuilder.CreateTable(
                name: "JanitorLog",
                columns: table => new
                {
                    nJanitorLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dtLogTime = table.Column<DateTime>(nullable: true),
                    szJanitorName = table.Column<string>(nullable: true),
                    lEPCOrder = table.Column<long>(nullable: true),
                    szBookID = table.Column<string>(nullable: true),
                    szBookName = table.Column<string>(nullable: true),
                    szBookIndex = table.Column<string>(nullable: true),
                    nBookStatus = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JanitorLog", x => x.nJanitorLogID);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    nID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    szName = table.Column<string>(nullable: true),
                    szShortName = table.Column<string>(nullable: true),
                    nDefaultStatus = table.Column<int>(nullable: false),
                    nStaffID = table.Column<int>(nullable: true),
                    szStaffName = table.Column<string>(nullable: true),
                    dtAddDate = table.Column<DateTime>(nullable: true),
                    bForceSortCase = table.Column<bool>(nullable: true),
                    bInitSortOver = table.Column<bool>(nullable: true),
                    szMedicalLib = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.nID);
                });

            migrationBuilder.CreateTable(
                name: "Reader",
                columns: table => new
                {
                    szReaderID = table.Column<string>(nullable: false),
                    nCardID = table.Column<string>(nullable: true),
                    nEPCOrder = table.Column<long>(nullable: true),
                    szName = table.Column<string>(nullable: true),
                    bSex = table.Column<bool>(nullable: true),
                    dtBirthday = table.Column<DateTime>(nullable: true),
                    szCompany = table.Column<string>(nullable: true),
                    szAddress = table.Column<string>(nullable: true),
                    szTelephone = table.Column<string>(nullable: true),
                    dtRegisterDate = table.Column<DateTime>(nullable: true),
                    fDeposit = table.Column<decimal>(nullable: true),
                    fBalance = table.Column<decimal>(nullable: true),
                    szCardPswd = table.Column<string>(nullable: true),
                    nLibraryNo = table.Column<int>(nullable: true),
                    szidentityCard = table.Column<string>(nullable: true),
                    dtlapse = table.Column<DateTime>(nullable: true),
                    nConvertStaffID = table.Column<int>(nullable: true),
                    dtConvertDate = table.Column<DateTime>(nullable: true),
                    imgPic = table.Column<byte[]>(nullable: true),
                    szFinger = table.Column<string>(nullable: true),
                    nCardTypeID = table.Column<int>(nullable: true),
                    nCardStatusID = table.Column<int>(nullable: true),
                    szEmail = table.Column<string>(nullable: true),
                    szMobile = table.Column<string>(nullable: true),
                    nCardOrder = table.Column<short>(nullable: true),
                    szRemark = table.Column<string>(nullable: true),
                    fOwe = table.Column<decimal>(nullable: true),
                    szMajorName = table.Column<string>(nullable: true),
                    szEduLevel = table.Column<string>(nullable: true),
                    szMajorNameSub = table.Column<string>(nullable: true),
                    szProRanks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reader", x => x.szReaderID);
                });

            migrationBuilder.CreateTable(
                name: "ReaderINOUTLog",
                columns: table => new
                {
                    nID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dtRecordTime = table.Column<DateTime>(nullable: true),
                    nType = table.Column<short>(nullable: true),
                    nCounter = table.Column<int>(nullable: false),
                    szJanitorName = table.Column<string>(nullable: true),
                    szReaderID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReaderINOUTLog", x => x.nID);
                });

            migrationBuilder.CreateTable(
                name: "VerifyIdentity",
                columns: table => new
                {
                    nID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerifyIdentityName = table.Column<string>(nullable: true),
                    dtRecordTime = table.Column<DateTime>(nullable: true),
                    CardType = table.Column<short>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    ReaderName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerifyIdentity", x => x.nID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowHisIndex");

            migrationBuilder.DropTable(
                name: "BorrowHistory");

            migrationBuilder.DropTable(
                name: "CardType");

            migrationBuilder.DropTable(
                name: "CRD_TRANS_Recd");

            migrationBuilder.DropTable(
                name: "DeviceInfo");

            migrationBuilder.DropTable(
                name: "duStaff");

            migrationBuilder.DropTable(
                name: "JanitorLog");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Reader");

            migrationBuilder.DropTable(
                name: "ReaderINOUTLog");

            migrationBuilder.DropTable(
                name: "VerifyIdentity");
        }
    }
}
