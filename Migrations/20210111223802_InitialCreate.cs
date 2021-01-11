using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mbfwAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACBAL",
                columns: table => new
                {
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ATYPE = table.Column<short>(type: "smallint", nullable: true),
                    ATPNAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TDEBIT = table.Column<double>(type: "float", nullable: true),
                    TCREDIT = table.Column<double>(type: "float", nullable: true),
                    TDEBIT2 = table.Column<double>(type: "float", nullable: true),
                    TCREDIT2 = table.Column<double>(type: "float", nullable: true),
                    TDEBIT3 = table.Column<double>(type: "float", nullable: true),
                    TCREDIT3 = table.Column<double>(type: "float", nullable: true),
                    TDEBIT4 = table.Column<double>(type: "float", nullable: true),
                    TCREDIT4 = table.Column<double>(type: "float", nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    VTYPE = table.Column<int>(type: "int", nullable: true),
                    VORDR = table.Column<int>(type: "int", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    SDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    EDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    EXP = table.Column<double>(type: "float", nullable: true),
                    UACODE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UANAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ACCOUNT",
                columns: table => new
                {
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ANAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ATYPE = table.Column<short>(type: "smallint", nullable: true),
                    ATPNAME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    INTERF = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    BAL = table.Column<double>(type: "float", nullable: true),
                    AGNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AGNAMESUB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACTIV = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACCOUNT", x => x.ACODE);
                });

            migrationBuilder.CreateTable(
                name: "ADV",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AGROUP",
                columns: table => new
                {
                    PGRP = table.Column<int>(type: "int", nullable: false),
                    PGNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGROUP", x => x.PGRP);
                });

            migrationBuilder.CreateTable(
                name: "AGROUPSUB",
                columns: table => new
                {
                    PGRP = table.Column<int>(type: "int", nullable: false),
                    PGNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGROUPSUB", x => x.PGRP);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    ADate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mnth = table.Column<int>(type: "int", nullable: true),
                    Yar = table.Column<int>(type: "int", nullable: true),
                    ECode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    OTIME = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BALANCE",
                columns: table => new
                {
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    BALN = table.Column<double>(type: "float", nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    JO = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    NO = table.Column<int>(type: "int", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BALREP",
                columns: table => new
                {
                    ACODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    BALN = table.Column<double>(type: "float", nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    JO = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    NO = table.Column<int>(type: "int", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CHQNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DD = table.Column<DateTime>(type: "datetime", nullable: true),
                    GRUP = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BANKJV",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ANAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANKJV", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CASHPYM",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CASHPYM", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CASHRCP",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CASHRCP", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CHEQUES",
                columns: table => new
                {
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CHQNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    POSS = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CHQDT = table.Column<DateTime>(type: "datetime", nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CITY",
                columns: table => new
                {
                    CCODE = table.Column<int>(type: "int", nullable: false),
                    CNAME = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITY", x => x.CCODE);
                });

            migrationBuilder.CreateTable(
                name: "CLAIM1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true),
                    STNAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DISCOUNT = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    REM = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<double>(type: "float", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SQTY = table.Column<int>(type: "int", nullable: true),
                    SQTY1 = table.Column<int>(type: "int", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TEL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SMCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SMNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COMM = table.Column<double>(type: "float", nullable: true),
                    COMMRATE = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FREIGHT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DQTY = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CLAIM2",
                columns: table => new
                {
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATEP = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<float>(type: "real", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    BONUS = table.Column<double>(type: "float", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LRATE = table.Column<double>(type: "float", nullable: true),
                    SLRATE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "COLOR",
                columns: table => new
                {
                    GRP = table.Column<int>(type: "int", nullable: false),
                    GNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UCOLOR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COLOR", x => x.GRP);
                });

            migrationBuilder.CreateTable(
                name: "CREDIT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<double>(type: "float", nullable: true),
                    RNO = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    ANAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    PDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CLRDATE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    SORD = table.Column<int>(type: "int", nullable: true),
                    CHQNO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TERM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CR_BY = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CR_TYM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    BRNO = table.Column<int>(type: "int", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CREDIT", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                columns: table => new
                {
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MOBILENO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => x.VCODE);
                });

            migrationBuilder.CreateTable(
                name: "DEBIT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<double>(type: "float", nullable: true),
                    RNO = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    ANAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    PDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CLRDATE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    SORD = table.Column<int>(type: "int", nullable: true),
                    CHQNO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TERM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CR_BY = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CR_TYM = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEBIT", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    DPCode = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DPName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DeptSub",
                columns: table => new
                {
                    DPCode = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DPName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Desg",
                columns: table => new
                {
                    DCode = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DLLOG",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    JO = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    VTYPNAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DWageAtt",
                columns: table => new
                {
                    ECode = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    EName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Att = table.Column<double>(type: "float", nullable: true),
                    Mnth = table.Column<int>(type: "int", nullable: true),
                    Yar = table.Column<int>(type: "int", nullable: true),
                    OTHRS = table.Column<int>(type: "int", nullable: true),
                    OTAMT = table.Column<double>(type: "float", nullable: true),
                    BPAY = table.Column<double>(type: "float", nullable: true),
                    SALARY = table.Column<double>(type: "float", nullable: true),
                    LOAN = table.Column<double>(type: "float", nullable: true),
                    LOANAMT = table.Column<double>(type: "float", nullable: true),
                    ADV = table.Column<double>(type: "float", nullable: true),
                    MESS = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    Allow = table.Column<double>(type: "float", nullable: true),
                    Conv = table.Column<double>(type: "float", nullable: true),
                    Utilty = table.Column<double>(type: "float", nullable: true),
                    Itax = table.Column<double>(type: "float", nullable: true),
                    OTHER = table.Column<double>(type: "float", nullable: true),
                    PJCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PJNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    INCREMENT = table.Column<double>(type: "float", nullable: true),
                    WDAY = table.Column<double>(type: "float", nullable: true),
                    LEVPAID = table.Column<double>(type: "float", nullable: true),
                    ARRER = table.Column<double>(type: "float", nullable: true),
                    EOBI = table.Column<double>(type: "float", nullable: true),
                    SSC = table.Column<double>(type: "float", nullable: true),
                    INCOMTAX = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EMP_VIEW",
                columns: table => new
                {
                    ECode = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    UCODE = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    EName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MOBNO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    DPCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ApDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EStat = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    REF = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AGE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    cECN1Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN1Rel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN1Add = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN1Tel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN2Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN2Rel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN2Add = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN2Tel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CurDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DPName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ECode = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    UCODE = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    EName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    FName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    NIC = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    MOBNO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DCode = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    DPCode = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    dpcodeSub = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    ApDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EStat = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<int>(type: "int", nullable: true),
                    STATUS = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    REF = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AGE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    cECN1Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN1Rel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN1Add = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN1Tel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN2Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN2Rel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN2Add = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    cECN2Tel = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CurDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Experience = table.Column<string>(type: "varchar(2000)", unicode: false, maxLength: 2000, nullable: true),
                    PJCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PJNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EMPTY_SHEET_ADVANCE",
                columns: table => new
                {
                    ECODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ENAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BPay = table.Column<double>(type: "float", nullable: true),
                    DAYS = table.Column<int>(type: "int", nullable: true),
                    CalcPay = table.Column<double>(type: "float", nullable: true),
                    PADVANCE = table.Column<double>(type: "float", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "FORM_IN_SOFTWARE",
                columns: table => new
                {
                    frm_sno = table.Column<int>(type: "int", nullable: true),
                    FRM_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FRM_MENU_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MENU_HEADING = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Full_Access = table.Column<short>(type: "smallint", nullable: true),
                    Manager_Level = table.Column<short>(type: "smallint", nullable: true),
                    Advanced_User = table.Column<short>(type: "smallint", nullable: true),
                    General_Staff = table.Column<short>(type: "smallint", nullable: true),
                    View_Only = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GIN1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SQTY = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SQTY1 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true),
                    ADD = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BBNO = table.Column<string>(type: "nchar(25)", fixedLength: true, maxLength: 25, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    INTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TOTALAMNT = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GIN1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "GIN2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true),
                    SOBAL = table.Column<double>(type: "float", nullable: true),
                    OABAL = table.Column<double>(type: "float", nullable: true),
                    COLORDEMAND = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    NETRATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GIN2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Gnrllgr",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<int>(type: "int", nullable: true),
                    VDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Jo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ACode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Descr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true),
                    Credit = table.Column<double>(type: "float", nullable: true),
                    PDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    POST = table.Column<int>(type: "int", nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TERM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CHQNO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CLRDATE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    BRNO = table.Column<int>(type: "int", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gnrllgr", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GNRLLGR_CHQS",
                columns: table => new
                {
                    No = table.Column<int>(type: "int", nullable: true),
                    VDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Jo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ACode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    AName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Descr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true),
                    Credit = table.Column<double>(type: "float", nullable: true),
                    PDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    POST = table.Column<int>(type: "int", nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TERM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CHQNO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CLRDATE = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    BRNO = table.Column<int>(type: "int", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GPRICE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PRATE = table.Column<double>(type: "float", nullable: true),
                    SRATE = table.Column<double>(type: "float", nullable: true),
                    sno = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPRICE", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GRN_PRODTN1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FUNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FQTY = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    SHIFT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TYP = table.Column<short>(type: "smallint", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GRN_PRODTN2",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    BQTY = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    FCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SHIFT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GRN1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SQTY = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SQTY1 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRN1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "GRN2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<short>(type: "smallint", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true),
                    SOBAL = table.Column<double>(type: "float", nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRN2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GRNPending",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SQTY = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SQTY1 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GRP",
                columns: table => new
                {
                    GRP = table.Column<int>(type: "int", nullable: false),
                    GNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRP", x => x.GRP);
                });

            migrationBuilder.CreateTable(
                name: "IMGPATH",
                columns: table => new
                {
                    IMGPATH = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "JOURNAL",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ANAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JOURNAL", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LesOldSoft",
                columns: table => new
                {
                    NO = table.Column<double>(type: "float", nullable: true),
                    VDATE = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    SNO = table.Column<double>(type: "float", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OVCODE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OVNAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PCODE = table.Column<double>(type: "float", nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PRATE = table.Column<double>(type: "float", nullable: true),
                    SRATE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LESSLIST_NEW",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SRATE = table.Column<double>(type: "float", nullable: true),
                    PRATE = table.Column<double>(type: "float", nullable: true),
                    sno = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PGNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PGRP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LESSLIST_NEW", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Lgrrep",
                columns: table => new
                {
                    No = table.Column<int>(type: "int", nullable: true),
                    VDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    AName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Descr = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Jo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true),
                    Credit = table.Column<double>(type: "float", nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SORD = table.Column<int>(type: "int", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    FCODE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    sdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PYM = table.Column<double>(type: "float", nullable: true),
                    BAL = table.Column<double>(type: "float", nullable: true),
                    SALE = table.Column<double>(type: "float", nullable: true),
                    CHQNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OTHERS = table.Column<double>(type: "float", nullable: true),
                    DASTI = table.Column<double>(type: "float", nullable: true),
                    FREIGHT = table.Column<double>(type: "float", nullable: true),
                    CHQ = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<short>(type: "smallint", nullable: true),
                    TERM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Lgrrep1",
                columns: table => new
                {
                    No = table.Column<int>(type: "int", nullable: true),
                    VDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    AName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Descr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Jo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Debit = table.Column<double>(type: "float", nullable: true),
                    Credit = table.Column<double>(type: "float", nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    inv = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CHQNO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CLRDT = table.Column<DateTime>(type: "datetime", nullable: true),
                    PARTY = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LOAN",
                columns: table => new
                {
                    VNO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ECODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ENAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    edesg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EDEPT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Estat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VTYPE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LAMOUNT = table.Column<double>(type: "float", nullable: true),
                    INST = table.Column<double>(type: "float", nullable: true),
                    PMINST = table.Column<double>(type: "float", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LOCATION",
                columns: table => new
                {
                    GCODE = table.Column<int>(type: "int", nullable: false),
                    GNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCATION", x => x.GCODE);
                });

            migrationBuilder.CreateTable(
                name: "LOG",
                columns: table => new
                {
                    VOUCHER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NO = table.Column<int>(type: "int", nullable: true),
                    USERNM = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ETIME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ADATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    MODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    usernm = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PASSWRD = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TYPE = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MESS",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    CACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MGRP",
                columns: table => new
                {
                    GRP = table.Column<int>(type: "int", nullable: false),
                    GNAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGRP", x => x.GRP);
                });

            migrationBuilder.CreateTable(
                name: "MOB",
                columns: table => new
                {
                    MOB = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MPRODTN1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    GTYPE = table.Column<short>(type: "smallint", nullable: true),
                    GTNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Shift = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MPRODTN2",
                columns: table => new
                {
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OPJOURNAL",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPJOURNAL", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OVERTIME",
                columns: table => new
                {
                    ADate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mnth = table.Column<int>(type: "int", nullable: true),
                    Yar = table.Column<int>(type: "int", nullable: true),
                    ECode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OTIME = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PARTY",
                columns: table => new
                {
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    VCODEOLD = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    VCODE_NO = table.Column<int>(type: "int", nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    uvname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UFVNAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UVADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CITY = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AREA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LIMIT = table.Column<double>(type: "float", nullable: true),
                    ATYPE = table.Column<short>(type: "smallint", nullable: true),
                    ATYPNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CCODE = table.Column<int>(type: "int", nullable: true),
                    PGRP = table.Column<int>(type: "int", nullable: true),
                    PGNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PERSON = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    TEL = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MOBILE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MOBILE1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MOBILE2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FAX = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SMCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SMNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    COMM = table.Column<double>(type: "float", nullable: true),
                    MGRP = table.Column<short>(type: "smallint", nullable: true),
                    MGNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACTIV = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARTY", x => x.VCODE);
                });

            migrationBuilder.CreateTable(
                name: "PAY_LN_PAYMENT",
                columns: table => new
                {
                    VNO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ECODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ENAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EDESIG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EDEPT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LN_PAY_AMT = table.Column<double>(type: "float", nullable: true),
                    ADV_PAY_AMT = table.Column<double>(type: "float", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PendingOrdersPO",
                columns: table => new
                {
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SRATEP = table.Column<double>(type: "float", nullable: true),
                    PTYPE = table.Column<short>(type: "smallint", nullable: true),
                    GNAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    PONO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PendingordersSO",
                columns: table => new
                {
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SRATEP = table.Column<double>(type: "float", nullable: true),
                    PTYPE = table.Column<short>(type: "smallint", nullable: true),
                    GNAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ORDFROM = table.Column<short>(type: "smallint", nullable: true),
                    CITY = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PERIOD",
                columns: table => new
                {
                    PERIOD = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    SDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    EDATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PERIODCLOS",
                columns: table => new
                {
                    PERIOD = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    EDATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PGROUP",
                columns: table => new
                {
                    PGRP = table.Column<int>(type: "int", nullable: false),
                    PGNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PGROUP", x => x.PGRP);
                });

            migrationBuilder.CreateTable(
                name: "PLS",
                columns: table => new
                {
                    SALES = table.Column<double>(type: "float", nullable: true),
                    COGS = table.Column<double>(type: "float", nullable: true),
                    EXPENSES = table.Column<double>(type: "float", nullable: true),
                    PRODUCTION = table.Column<double>(type: "float", nullable: true),
                    RECOVERY = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "POCAN1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SQTY = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SQTY1 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POCAN1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "POCAN2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POCAN2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PORDER1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DISCOUNT = table.Column<double>(type: "float", nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PRNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    STAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    PONO = table.Column<int>(type: "int", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    CBAL = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FREIGHT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PRDCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PRDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DQTY = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PJCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PJNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SPECIAL = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DELIVERY = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PORDER1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "PORDER2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    FOCQTY = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<float>(type: "real", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PONO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PJCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PJNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PORDER2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PRDADJ1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    STYPE = table.Column<string>(type: "char(2)", unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    STPNAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    FGDN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FGDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TGDN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TGDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TQTY = table.Column<double>(type: "float", nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRDADJ2",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    AVBLSTOCK = table.Column<double>(type: "float", nullable: true),
                    QTYP = table.Column<double>(type: "float", nullable: true),
                    QTYM = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRDBAL",
                columns: table => new
                {
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PTYPE = table.Column<int>(type: "int", nullable: true),
                    PTPNAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GRP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    COLOR = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ART = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SIZE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PURAVG = table.Column<double>(type: "float", nullable: true),
                    Q1 = table.Column<double>(type: "float", nullable: true),
                    Q2 = table.Column<double>(type: "float", nullable: true),
                    Q3 = table.Column<double>(type: "float", nullable: true),
                    Q4 = table.Column<double>(type: "float", nullable: true),
                    Q5 = table.Column<double>(type: "float", nullable: true),
                    Q6 = table.Column<double>(type: "float", nullable: true),
                    Q7 = table.Column<double>(type: "float", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    LDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SALES = table.Column<double>(type: "float", nullable: true),
                    CQ1 = table.Column<double>(type: "float", nullable: true),
                    CQ2 = table.Column<double>(type: "float", nullable: true),
                    CQ3 = table.Column<double>(type: "float", nullable: true),
                    AMNT1 = table.Column<double>(type: "float", nullable: true),
                    AMNT2 = table.Column<double>(type: "float", nullable: true),
                    AMNT3 = table.Column<double>(type: "float", nullable: true),
                    AMNT4 = table.Column<double>(type: "float", nullable: true),
                    Bal = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRDBAL1",
                columns: table => new
                {
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PTYPE = table.Column<int>(type: "int", nullable: true),
                    PTPNAME = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GRP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PURAVG = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRDID",
                columns: table => new
                {
                    PRGID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRDINFO",
                columns: table => new
                {
                    FCODE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FUNIT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FQTY = table.Column<double>(type: "float", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRET1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DISCOUNT = table.Column<double>(type: "float", nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PRNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    STAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    PONO = table.Column<int>(type: "int", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    CBAL = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FREIGHT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRET1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "PRET2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<float>(type: "real", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PONO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRET2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PRLIST",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SRATE = table.Column<double>(type: "float", nullable: true),
                    PRATE2 = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRLIST", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PRODTN1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    FCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    FUNIT = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    FQTY = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    SHIFT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    TYP = table.Column<short>(type: "smallint", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRODTN2",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    BQTY = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    FCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SHIFT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PCODEOLD = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PCODE_NO = table.Column<double>(type: "float", nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UPNAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UPFNAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GRP = table.Column<short>(type: "smallint", nullable: true),
                    GNAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MGRP = table.Column<short>(type: "smallint", nullable: true),
                    MGNAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PRATE = table.Column<double>(type: "float", nullable: true),
                    PRATEP = table.Column<double>(type: "float", nullable: true),
                    SRATE = table.Column<double>(type: "float", nullable: true),
                    SRATEP = table.Column<double>(type: "float", nullable: true),
                    PTYPE = table.Column<short>(type: "smallint", nullable: true),
                    PTPNAME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SGNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SIZE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ARTICLE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SHOESTYP = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TYP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LESSAMNT = table.Column<double>(type: "float", nullable: true),
                    MINLEVL = table.Column<double>(type: "float", nullable: true),
                    MAXLEVL = table.Column<double>(type: "float", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DISC = table.Column<double>(type: "float", nullable: true),
                    ACTIV = table.Column<short>(type: "smallint", nullable: true),
                    DEAD = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.PCODE);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_COLOR",
                columns: table => new
                {
                    pcid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pcode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    color = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCT___83E06A9FAF6EF7A4", x => x.pcid);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_COLOR1",
                columns: table => new
                {
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    COLOR = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT2delete",
                columns: table => new
                {
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UNIT = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    GROUP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT_1", x => x.PCODE);
                });

            migrationBuilder.CreateTable(
                name: "PUJOURNAL",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ANAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PUJOURNAL", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PURCH1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    GRNNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DISCOUNT = table.Column<double>(type: "float", nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PRNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    STAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    PONO = table.Column<int>(type: "int", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    CBAL = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FREIGHT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PRDCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PRDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DQTY = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURCH1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "PURCH2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<float>(type: "real", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PONO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PURCH2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    ECode = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    Dat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mnth = table.Column<int>(type: "int", nullable: true),
                    Yar = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    WDays = table.Column<double>(type: "float", nullable: true),
                    ADays = table.Column<double>(type: "float", nullable: true),
                    BPay = table.Column<double>(type: "float", nullable: true),
                    HRent = table.Column<int>(type: "int", nullable: true),
                    Utility = table.Column<int>(type: "int", nullable: true),
                    Con = table.Column<int>(type: "int", nullable: true),
                    OTIME = table.Column<int>(type: "int", nullable: true),
                    Loan = table.Column<int>(type: "int", nullable: true),
                    ITax = table.Column<int>(type: "int", nullable: true),
                    Adv = table.Column<int>(type: "int", nullable: true),
                    LeaveDed = table.Column<int>(type: "int", nullable: true),
                    EOBI = table.Column<int>(type: "int", nullable: true),
                    Post = table.Column<int>(type: "int", nullable: true),
                    DPCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    MESS = table.Column<double>(type: "float", nullable: true),
                    Allow = table.Column<double>(type: "float", nullable: true),
                    Conv = table.Column<double>(type: "float", nullable: true),
                    Utilty = table.Column<double>(type: "float", nullable: true),
                    OTHER = table.Column<double>(type: "float", nullable: true),
                    OTHRS = table.Column<double>(type: "float", nullable: true),
                    OTAMT = table.Column<double>(type: "float", nullable: true),
                    LOANAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    LBAL = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SALE1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    GINNO = table.Column<int>(type: "int", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true),
                    STNAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DISCOUNT = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    REM = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<double>(type: "float", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SQTY = table.Column<int>(type: "int", nullable: true),
                    SQTY1 = table.Column<int>(type: "int", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TEL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SMCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SMNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COMM = table.Column<double>(type: "float", nullable: true),
                    COMMRATE = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FREIGHT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DQTY = table.Column<double>(type: "float", nullable: true),
                    VANCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    VANNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    COMM1 = table.Column<double>(type: "float", nullable: true),
                    COMMRATE1 = table.Column<double>(type: "float", nullable: true),
                    ETIME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "SALE2",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<short>(type: "smallint", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATEP = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<float>(type: "real", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    BONUS = table.Column<double>(type: "float", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LRATE = table.Column<double>(type: "float", nullable: true),
                    SLRATE = table.Column<double>(type: "float", nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALE2", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SALECASH1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    GINNO = table.Column<int>(type: "int", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true),
                    STNAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DISCOUNT = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    REM = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<double>(type: "float", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SQTY = table.Column<int>(type: "int", nullable: true),
                    SQTY1 = table.Column<int>(type: "int", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TEL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SMCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SMNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COMM = table.Column<double>(type: "float", nullable: true),
                    COMMRATE = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FREIGHT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DQTY = table.Column<double>(type: "float", nullable: true),
                    VANCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    VANNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    COMM1 = table.Column<double>(type: "float", nullable: true),
                    COMMRATE1 = table.Column<double>(type: "float", nullable: true),
                    etime = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALECASH1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "SALECASH2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATEP = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<float>(type: "real", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    BONUS = table.Column<double>(type: "float", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LRATE = table.Column<double>(type: "float", nullable: true),
                    SLRATE = table.Column<double>(type: "float", nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALECASH2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SalInfo",
                columns: table => new
                {
                    ECode = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    EName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EDesg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EDept = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EDeptSub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Estat = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Leave = table.Column<int>(type: "int", nullable: true),
                    BPay = table.Column<int>(type: "int", nullable: true),
                    Con = table.Column<int>(type: "int", nullable: true),
                    HRent = table.Column<int>(type: "int", nullable: true),
                    OTime = table.Column<int>(type: "int", nullable: true),
                    Utility = table.Column<int>(type: "int", nullable: true),
                    Loan = table.Column<int>(type: "int", nullable: true),
                    Adv = table.Column<int>(type: "int", nullable: true),
                    ITax = table.Column<int>(type: "int", nullable: true),
                    LeaveDed = table.Column<int>(type: "int", nullable: true),
                    EOBI = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SENT_SMS",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    JO = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CELLNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MSGSTR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SLJOURNAL",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ACODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ANAME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SLJOURNAL", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SLREP",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    ART = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JO = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    GST = table.Column<double>(type: "float", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    FTAMT = table.Column<double>(type: "float", nullable: true),
                    BAL15 = table.Column<double>(type: "float", nullable: true),
                    BAL30 = table.Column<double>(type: "float", nullable: true),
                    BAL45 = table.Column<double>(type: "float", nullable: true),
                    BAL46 = table.Column<double>(type: "float", nullable: true),
                    BAL = table.Column<double>(type: "float", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    SALE = table.Column<double>(type: "float", nullable: true),
                    SRET = table.Column<double>(type: "float", nullable: true),
                    CASH = table.Column<double>(type: "float", nullable: true),
                    GTOTAL = table.Column<double>(type: "float", nullable: true),
                    SDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    EDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    OPENING = table.Column<double>(type: "float", nullable: true),
                    RECOVERY = table.Column<double>(type: "float", nullable: true),
                    AVERAGE = table.Column<double>(type: "float", nullable: true),
                    CLAIM = table.Column<double>(type: "float", nullable: true),
                    GROSS = table.Column<double>(type: "float", nullable: true),
                    rem = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BAL75 = table.Column<double>(type: "float", nullable: true),
                    BAL90 = table.Column<double>(type: "float", nullable: true),
                    BAL60 = table.Column<double>(type: "float", nullable: true),
                    TENAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SOBAL",
                columns: table => new
                {
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NO = table.Column<double>(type: "float", nullable: true),
                    ORD = table.Column<double>(type: "float", nullable: true),
                    DIS = table.Column<double>(type: "float", nullable: true),
                    BAL = table.Column<double>(type: "float", nullable: true),
                    CANCL = table.Column<double>(type: "float", nullable: true),
                    STKBAL = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SOCAN1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SQTY = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SQTY1 = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SOCAN2",
                columns: table => new
                {
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SORDER1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true),
                    STNAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DISCOUNT = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    REM = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<double>(type: "float", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SQTY = table.Column<int>(type: "int", nullable: true),
                    SQTY1 = table.Column<int>(type: "int", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TEL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SMCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SMNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COMM = table.Column<double>(type: "float", nullable: true),
                    COMMRATE = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FREIGHT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DQTY = table.Column<double>(type: "float", nullable: true),
                    ORDFROM = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SORDER1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "SORDER2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATEP = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<float>(type: "real", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    BONUS = table.Column<double>(type: "float", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LRATE = table.Column<double>(type: "float", nullable: true),
                    SLRATE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SORDER2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SRET1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true),
                    STNAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ADDR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    DISCOUNT = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    REM = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    STAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<double>(type: "float", nullable: true),
                    OPBAL = table.Column<double>(type: "float", nullable: true),
                    TRANSPORT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    BNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SQTY = table.Column<int>(type: "int", nullable: true),
                    SQTY1 = table.Column<int>(type: "int", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TEL = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SMCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SMNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    COMM = table.Column<double>(type: "float", nullable: true),
                    COMMRATE = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FREIGHT = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    vancode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    VANNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    COMM1 = table.Column<double>(type: "float", nullable: true),
                    COMMRATE1 = table.Column<double>(type: "float", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DQTY = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRET1", x => x.NO);
                });

            migrationBuilder.CreateTable(
                name: "SRET2",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATEP = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true),
                    GST = table.Column<float>(type: "real", nullable: true),
                    GSTAMT = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    BONUS = table.Column<double>(type: "float", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true),
                    LRATE = table.Column<double>(type: "float", nullable: true),
                    SLRATE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SRET2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "STKCON1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "STKCON2",
                columns: table => new
                {
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "STKIW1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "STKIW2",
                columns: table => new
                {
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "STOCK",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    JO = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    INQT = table.Column<double>(type: "float", nullable: true),
                    OUTQT = table.Column<double>(type: "float", nullable: true),
                    INAMT = table.Column<double>(type: "float", nullable: true),
                    OUTAMT = table.Column<double>(type: "float", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    POST = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GRP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STOCK", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "STOCK_COLOR",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    JO = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    COLOR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RNO = table.Column<int>(type: "int", nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    INQT = table.Column<double>(type: "float", nullable: true),
                    OUTQT = table.Column<double>(type: "float", nullable: true),
                    INAMT = table.Column<double>(type: "float", nullable: true),
                    OUTAMT = table.Column<double>(type: "float", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    BQTY = table.Column<double>(type: "float", nullable: true),
                    ESTATUS = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STOCK_COLOR", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "STOCKPO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    JO = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    INQT = table.Column<double>(type: "float", nullable: true),
                    OUTQT = table.Column<double>(type: "float", nullable: true),
                    INAMT = table.Column<double>(type: "float", nullable: true),
                    OUTAMT = table.Column<double>(type: "float", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    POST = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GRP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    MARKA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PJCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PJNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PONO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STOCKPO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "STOCKSO",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NO = table.Column<int>(type: "int", nullable: true),
                    SONO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    JO = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DESCR = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    INQT = table.Column<double>(type: "float", nullable: true),
                    OUTQT = table.Column<double>(type: "float", nullable: true),
                    INAMT = table.Column<double>(type: "float", nullable: true),
                    OUTAMT = table.Column<double>(type: "float", nullable: true),
                    BATCH = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    POST = table.Column<int>(type: "int", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GRP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    STYPE = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STOCKSO", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TAttendance",
                columns: table => new
                {
                    ADate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mnth = table.Column<int>(type: "int", nullable: true),
                    Yar = table.Column<int>(type: "int", nullable: true),
                    ECode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TAttSummary",
                columns: table => new
                {
                    ADate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mnth = table.Column<int>(type: "int", nullable: true),
                    Yar = table.Column<int>(type: "int", nullable: true),
                    ECode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PRESENT = table.Column<double>(type: "float", nullable: true),
                    ABSENT = table.Column<double>(type: "float", nullable: true),
                    LEAVE = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TCHKUSER",
                columns: table => new
                {
                    USER = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TEmpe",
                columns: table => new
                {
                    ECode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DpName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    ApDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EStat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Active = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TRANSPORT",
                columns: table => new
                {
                    TCODE = table.Column<short>(type: "smallint", nullable: false),
                    TNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TADDR = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TCITY = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    OCITY = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TTEL = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TMOB = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UTNAME = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    bilty = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    adda = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSPORT", x => x.TCODE);
                });

            migrationBuilder.CreateTable(
                name: "TRIAL",
                columns: table => new
                {
                    ACODE = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    ANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DEBIT = table.Column<double>(type: "float", nullable: true),
                    CREDIT = table.Column<double>(type: "float", nullable: true),
                    ODEBIT = table.Column<double>(type: "float", nullable: true),
                    OCREDIT = table.Column<double>(type: "float", nullable: true),
                    CDEBIT = table.Column<double>(type: "float", nullable: true),
                    CCREDIT = table.Column<double>(type: "float", nullable: true),
                    UACODE = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UANAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TRSF1",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    FGDN = table.Column<int>(type: "int", nullable: true),
                    FGDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TGDN = table.Column<int>(type: "int", nullable: true),
                    TGDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TQTY = table.Column<double>(type: "float", nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    EUSER = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EDATE = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TRSF2",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    GDCODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    GDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TSalary",
                columns: table => new
                {
                    ECode = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    Dat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mnth = table.Column<int>(type: "int", nullable: true),
                    Yar = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    WDays = table.Column<double>(type: "float", nullable: true),
                    ADays = table.Column<double>(type: "float", nullable: true),
                    BPay = table.Column<double>(type: "float", nullable: true),
                    HRent = table.Column<int>(type: "int", nullable: true),
                    Utility = table.Column<int>(type: "int", nullable: true),
                    Con = table.Column<int>(type: "int", nullable: true),
                    OTIME = table.Column<int>(type: "int", nullable: true),
                    Loan = table.Column<int>(type: "int", nullable: true),
                    ITax = table.Column<int>(type: "int", nullable: true),
                    Adv = table.Column<int>(type: "int", nullable: true),
                    LeaveDed = table.Column<int>(type: "int", nullable: true),
                    EOBI = table.Column<int>(type: "int", nullable: true),
                    Post = table.Column<int>(type: "int", nullable: true),
                    DPCODE = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    MESS = table.Column<double>(type: "float", nullable: true),
                    Allow = table.Column<double>(type: "float", nullable: true),
                    Conv = table.Column<double>(type: "float", nullable: true),
                    Utilty = table.Column<double>(type: "float", nullable: true),
                    OTHER = table.Column<double>(type: "float", nullable: true),
                    OTHRS = table.Column<double>(type: "float", nullable: true),
                    OTAMT = table.Column<double>(type: "float", nullable: true),
                    LOANAMT = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    LBAL = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TSTKTRF",
                columns: table => new
                {
                    NO = table.Column<int>(type: "int", nullable: true),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    FGDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TGDNAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SNO = table.Column<int>(type: "int", nullable: true),
                    VNO = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UID_PASS_CHILD",
                columns: table => new
                {
                    u_login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    frm_ID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FRM_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    frm_Main_Menu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VIEW1",
                columns: table => new
                {
                    MGNAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    LES1 = table.Column<double>(type: "float", nullable: true),
                    LES2 = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VIEW2",
                columns: table => new
                {
                    MGNAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NO = table.Column<short>(type: "smallint", nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    LES1 = table.Column<double>(type: "float", nullable: true),
                    LES2 = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SERVICE1",
                columns: table => new
                {
                    NO = table.Column<double>(type: "float", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    SNO = table.Column<double>(type: "float", nullable: true),
                    INTIME = table.Column<DateTime>(type: "datetime", nullable: true),
                    OUTTIME = table.Column<DateTime>(type: "datetime", nullable: true),
                    VCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TOTAL = table.Column<double>(type: "float", nullable: true),
                    PRVBAL = table.Column<double>(type: "float", nullable: true),
                    ADVRCV = table.Column<double>(type: "float", nullable: true),
                    NET = table.Column<double>(type: "float", nullable: true),
                    PREPBY = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVICE3", x => x.NO);
                    table.ForeignKey(
                        name: "FK_SERVICE1_CUSTOMER",
                        column: x => x.VCODE,
                        principalTable: "CUSTOMER",
                        principalColumn: "VCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SERVICE2",
                columns: table => new
                {
                    NO = table.Column<double>(type: "float", nullable: false),
                    VDATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ORDERNO = table.Column<double>(type: "float", nullable: true),
                    PCODE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PNAME = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UNIT = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    QTY = table.Column<double>(type: "float", nullable: true),
                    RATE = table.Column<double>(type: "float", nullable: true),
                    AMOUNT = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVICE2", x => x.NO);
                    table.ForeignKey(
                        name: "FK_SERVICE2_SERVICE1",
                        column: x => x.ORDERNO,
                        principalTable: "SERVICE1",
                        principalColumn: "NO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SERVICE2_SERVICE2",
                        column: x => x.PCODE,
                        principalTable: "PRODUCT2delete",
                        principalColumn: "PCODE",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SERVICE1_VCODE",
                table: "SERVICE1",
                column: "VCODE");

            migrationBuilder.CreateIndex(
                name: "IX_SERVICE2_ORDERNO",
                table: "SERVICE2",
                column: "ORDERNO");

            migrationBuilder.CreateIndex(
                name: "IX_SERVICE2_PCODE",
                table: "SERVICE2",
                column: "PCODE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACBAL");

            migrationBuilder.DropTable(
                name: "ACCOUNT");

            migrationBuilder.DropTable(
                name: "ADV");

            migrationBuilder.DropTable(
                name: "AGROUP");

            migrationBuilder.DropTable(
                name: "AGROUPSUB");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "BALANCE");

            migrationBuilder.DropTable(
                name: "BALREP");

            migrationBuilder.DropTable(
                name: "BANKJV");

            migrationBuilder.DropTable(
                name: "CASHPYM");

            migrationBuilder.DropTable(
                name: "CASHRCP");

            migrationBuilder.DropTable(
                name: "CHEQUES");

            migrationBuilder.DropTable(
                name: "CITY");

            migrationBuilder.DropTable(
                name: "CLAIM1");

            migrationBuilder.DropTable(
                name: "CLAIM2");

            migrationBuilder.DropTable(
                name: "COLOR");

            migrationBuilder.DropTable(
                name: "CREDIT");

            migrationBuilder.DropTable(
                name: "DEBIT");

            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "DeptSub");

            migrationBuilder.DropTable(
                name: "Desg");

            migrationBuilder.DropTable(
                name: "DLLOG");

            migrationBuilder.DropTable(
                name: "DWageAtt");

            migrationBuilder.DropTable(
                name: "EMP_VIEW");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "EMPTY_SHEET_ADVANCE");

            migrationBuilder.DropTable(
                name: "FORM_IN_SOFTWARE");

            migrationBuilder.DropTable(
                name: "GIN1");

            migrationBuilder.DropTable(
                name: "GIN2");

            migrationBuilder.DropTable(
                name: "Gnrllgr");

            migrationBuilder.DropTable(
                name: "GNRLLGR_CHQS");

            migrationBuilder.DropTable(
                name: "GPRICE");

            migrationBuilder.DropTable(
                name: "GRN_PRODTN1");

            migrationBuilder.DropTable(
                name: "GRN_PRODTN2");

            migrationBuilder.DropTable(
                name: "GRN1");

            migrationBuilder.DropTable(
                name: "GRN2");

            migrationBuilder.DropTable(
                name: "GRNPending");

            migrationBuilder.DropTable(
                name: "GRP");

            migrationBuilder.DropTable(
                name: "IMGPATH");

            migrationBuilder.DropTable(
                name: "JOURNAL");

            migrationBuilder.DropTable(
                name: "LesOldSoft");

            migrationBuilder.DropTable(
                name: "LESSLIST_NEW");

            migrationBuilder.DropTable(
                name: "Lgrrep");

            migrationBuilder.DropTable(
                name: "Lgrrep1");

            migrationBuilder.DropTable(
                name: "LOAN");

            migrationBuilder.DropTable(
                name: "LOCATION");

            migrationBuilder.DropTable(
                name: "LOG");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "MESS");

            migrationBuilder.DropTable(
                name: "MGRP");

            migrationBuilder.DropTable(
                name: "MOB");

            migrationBuilder.DropTable(
                name: "MPRODTN1");

            migrationBuilder.DropTable(
                name: "MPRODTN2");

            migrationBuilder.DropTable(
                name: "OPJOURNAL");

            migrationBuilder.DropTable(
                name: "OVERTIME");

            migrationBuilder.DropTable(
                name: "PARTY");

            migrationBuilder.DropTable(
                name: "PAY_LN_PAYMENT");

            migrationBuilder.DropTable(
                name: "PendingOrdersPO");

            migrationBuilder.DropTable(
                name: "PendingordersSO");

            migrationBuilder.DropTable(
                name: "PERIOD");

            migrationBuilder.DropTable(
                name: "PERIODCLOS");

            migrationBuilder.DropTable(
                name: "PGROUP");

            migrationBuilder.DropTable(
                name: "PLS");

            migrationBuilder.DropTable(
                name: "POCAN1");

            migrationBuilder.DropTable(
                name: "POCAN2");

            migrationBuilder.DropTable(
                name: "PORDER1");

            migrationBuilder.DropTable(
                name: "PORDER2");

            migrationBuilder.DropTable(
                name: "PRDADJ1");

            migrationBuilder.DropTable(
                name: "PRDADJ2");

            migrationBuilder.DropTable(
                name: "PRDBAL");

            migrationBuilder.DropTable(
                name: "PRDBAL1");

            migrationBuilder.DropTable(
                name: "PRDID");

            migrationBuilder.DropTable(
                name: "PRDINFO");

            migrationBuilder.DropTable(
                name: "PRET1");

            migrationBuilder.DropTable(
                name: "PRET2");

            migrationBuilder.DropTable(
                name: "PRLIST");

            migrationBuilder.DropTable(
                name: "PRODTN1");

            migrationBuilder.DropTable(
                name: "PRODTN2");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "PRODUCT_COLOR");

            migrationBuilder.DropTable(
                name: "PRODUCT_COLOR1");

            migrationBuilder.DropTable(
                name: "PUJOURNAL");

            migrationBuilder.DropTable(
                name: "PURCH1");

            migrationBuilder.DropTable(
                name: "PURCH2");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "SALE1");

            migrationBuilder.DropTable(
                name: "SALE2");

            migrationBuilder.DropTable(
                name: "SALECASH1");

            migrationBuilder.DropTable(
                name: "SALECASH2");

            migrationBuilder.DropTable(
                name: "SalInfo");

            migrationBuilder.DropTable(
                name: "SENT_SMS");

            migrationBuilder.DropTable(
                name: "SERVICE2");

            migrationBuilder.DropTable(
                name: "SLJOURNAL");

            migrationBuilder.DropTable(
                name: "SLREP");

            migrationBuilder.DropTable(
                name: "SOBAL");

            migrationBuilder.DropTable(
                name: "SOCAN1");

            migrationBuilder.DropTable(
                name: "SOCAN2");

            migrationBuilder.DropTable(
                name: "SORDER1");

            migrationBuilder.DropTable(
                name: "SORDER2");

            migrationBuilder.DropTable(
                name: "SRET1");

            migrationBuilder.DropTable(
                name: "SRET2");

            migrationBuilder.DropTable(
                name: "STKCON1");

            migrationBuilder.DropTable(
                name: "STKCON2");

            migrationBuilder.DropTable(
                name: "STKIW1");

            migrationBuilder.DropTable(
                name: "STKIW2");

            migrationBuilder.DropTable(
                name: "STOCK");

            migrationBuilder.DropTable(
                name: "STOCK_COLOR");

            migrationBuilder.DropTable(
                name: "STOCKPO");

            migrationBuilder.DropTable(
                name: "STOCKSO");

            migrationBuilder.DropTable(
                name: "TAttendance");

            migrationBuilder.DropTable(
                name: "TAttSummary");

            migrationBuilder.DropTable(
                name: "TCHKUSER");

            migrationBuilder.DropTable(
                name: "TEmpe");

            migrationBuilder.DropTable(
                name: "TRANSPORT");

            migrationBuilder.DropTable(
                name: "TRIAL");

            migrationBuilder.DropTable(
                name: "TRSF1");

            migrationBuilder.DropTable(
                name: "TRSF2");

            migrationBuilder.DropTable(
                name: "TSalary");

            migrationBuilder.DropTable(
                name: "TSTKTRF");

            migrationBuilder.DropTable(
                name: "UID_PASS_CHILD");

            migrationBuilder.DropTable(
                name: "VIEW1");

            migrationBuilder.DropTable(
                name: "VIEW2");

            migrationBuilder.DropTable(
                name: "SERVICE1");

            migrationBuilder.DropTable(
                name: "PRODUCT2delete");

            migrationBuilder.DropTable(
                name: "CUSTOMER");
        }
    }
}
