using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dji.Cloud.Infrastructure.MsSql.Migrations
{
    /// <inheritdoc />
    public partial class addinitialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "DeviceDictionaries",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Domain = table.Column<int>(type: "int", nullable: false),
                    DeviceType = table.Column<int>(type: "int", nullable: false),
                    SubType = table.Column<int>(type: "int", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    DeviceDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceDictionaries_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceFirmwares",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmwareId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    FirmwareVersion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    ObjectKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    FileMd5 = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseNote = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ReleaseDate = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    WorkspaceId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceFirmwares_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceHmses",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HmsId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Tid = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Bid = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Module = table.Column<int>(type: "int", nullable: false),
                    HmsKey = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    MessageZh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MessageEn = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceHmses_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceLogs",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogsId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LogsInfo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DeviceSerialNumber = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    HappenTime = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceLogs_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevicePayloads",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayloadSerialNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    PayloadName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    PayloadType = table.Column<int>(type: "int", nullable: false),
                    SubType = table.Column<int>(type: "int", nullable: false),
                    FirmwareVersion = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    PayloadIndex = table.Column<int>(type: "int", nullable: false),
                    DeviceSerialNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    PayloadDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevicePayloads_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceSerialNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    WorkspaceId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    DeviceType = table.Column<int>(type: "int", nullable: false),
                    SubType = table.Column<int>(type: "int", nullable: false),
                    Domain = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<int>(type: "int", maxLength: 32, nullable: false),
                    DeviceIndex = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ChildSerialNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    DeviceDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UrlNormal = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UrlSelect = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Nickname = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    FirmwareVersion = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    CompatibleStatus = table.Column<bool>(type: "bit", nullable: false),
                    BoundStatus = table.Column<bool>(type: "bit", nullable: false),
                    BoundTime = table.Column<long>(type: "bigint", nullable: false),
                    LoginTime = table.Column<long>(type: "bigint", nullable: false),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElementCoordinates",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(18,14)", precision: 18, scale: 14, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(17,14)", precision: 17, scale: 14, nullable: false),
                    Altitude = table.Column<decimal>(type: "decimal(17,14)", precision: 17, scale: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementCoordinates_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirmwareModels",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmwareId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmwareModels_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupElements",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ElementId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ElementName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Display = table.Column<int>(type: "int", nullable: false),
                    ElementType = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ClampToGround = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupElements_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    GroupType = table.Column<int>(type: "int", nullable: false),
                    WorkspaceId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    IsDistributed = table.Column<bool>(type: "bit", nullable: false),
                    IsLock = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogsFileIndexes",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BootIndex = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    StartTime = table.Column<long>(type: "bigint", nullable: false),
                    EndTime = table.Column<long>(type: "bigint", nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    DeviceSerialNumber = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Domain = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsFileIndexes_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogsFiles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    LogsId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    DeviceSerialNumber = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Fingerprint = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ObjectKey = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogsFiles_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaFiles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WorkspaceId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Fingerprint = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    TinnyFingerprint = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ObjectKey = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SubFileType = table.Column<int>(type: "int", nullable: false),
                    IsOriginal = table.Column<bool>(type: "bit", nullable: false),
                    Drone = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    Payload = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    JobId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFiles_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    WorkspaceId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    MqttUserName = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    MqttPassword = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaylineFiles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    WaylineId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    DroneModelKey = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    PayloadModelKeys = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Sign = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    WorkspaceId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    Favorited = table.Column<bool>(type: "bit", nullable: false),
                    TemplateTypes = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    ObjectKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaylineFiles_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaylineJobs",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    FileId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    DockSerialNumber = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    WorkspaceId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    TaskType = table.Column<int>(type: "int", nullable: false),
                    WaylineType = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ExecuteTime = table.Column<long>(type: "bigint", nullable: false),
                    EndTime = table.Column<long>(type: "bigint", nullable: false),
                    ErrorCode = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RthAltitude = table.Column<int>(type: "int", nullable: false),
                    OutOfControlAction = table.Column<int>(type: "int", nullable: false),
                    MediaCount = table.Column<int>(type: "int", nullable: false),
                    BeginTime = table.Column<long>(type: "bigint", nullable: false),
                    CompletedTime = table.Column<long>(type: "bigint", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaylineJobs_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workspaces",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkspaceId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    WorkspaceName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    WorkspaceDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PlatformName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    BindCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    CreateTime = table.Column<long>(type: "bigint", nullable: false),
                    UpdateTime = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workspaces_Id", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceDictionaries",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DeviceFirmwares",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DeviceHmses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DeviceLogs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "DevicePayloads",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Devices",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ElementCoordinates",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "FirmwareModels",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GroupElements",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Groups",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LogsFileIndexes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LogsFiles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "MediaFiles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WaylineFiles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "WaylineJobs",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Workspaces",
                schema: "dbo");
        }
    }
}
