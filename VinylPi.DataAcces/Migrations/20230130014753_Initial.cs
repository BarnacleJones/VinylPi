using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VinylPi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BasicInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Masterid = table.Column<int>(name: "Master_id", type: "int", nullable: true),
                    Masterurl = table.Column<string>(name: "Master_url", type: "nvarchar(max)", nullable: true),
                    Resourceurl = table.Column<string>(name: "Resource_url", type: "nvarchar(max)", nullable: true),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coverimage = table.Column<string>(name: "Cover_image", type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Last = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Next = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Join = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tracks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resourceurl = table.Column<string>(name: "Resource_url", type: "nvarchar(max)", nullable: true),
                    BasicInformationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artist_BasicInformation_BasicInformationId",
                        column: x => x.BasicInformationId,
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Formats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInformationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formats_BasicInformation_BasicInformationId",
                        column: x => x.BasicInformationId,
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInformationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genres_BasicInformation_BasicInformationId",
                        column: x => x.BasicInformationId,
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entitytype = table.Column<string>(name: "Entity_type", type: "nvarchar(max)", nullable: true),
                    Entitytypename = table.Column<string>(name: "Entity_type_name", type: "nvarchar(max)", nullable: true),
                    LabelId = table.Column<int>(type: "int", nullable: true),
                    Resourceurl = table.Column<string>(name: "Resource_url", type: "nvarchar(max)", nullable: true),
                    BasicInformationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Labels_BasicInformation_BasicInformationId",
                        column: x => x.BasicInformationId,
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicInformationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Styles_BasicInformation_BasicInformationId",
                        column: x => x.BasicInformationId,
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pagination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pages = table.Column<int>(type: "int", nullable: true),
                    Perpage = table.Column<int>(name: "Per_page", type: "int", nullable: true),
                    Items = table.Column<int>(type: "int", nullable: true),
                    UrlsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagination_Urls_UrlsId",
                        column: x => x.UrlsId,
                        principalTable: "Urls",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Descriptions_Formats_FormatId",
                        column: x => x.FormatId,
                        principalTable: "Formats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Root",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaginationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Root", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Root_Pagination_PaginationId",
                        column: x => x.PaginationId,
                        principalTable: "Pagination",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Releases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Instanceid = table.Column<int>(name: "Instance_id", type: "int", nullable: true),
                    Dateadded = table.Column<DateTime>(name: "Date_added", type: "datetime2", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    basicinformationId = table.Column<int>(name: "basic_informationId", type: "int", nullable: true),
                    RootId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Releases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Releases_BasicInformation_basic_informationId",
                        column: x => x.basicinformationId,
                        principalTable: "BasicInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Releases_Root_RootId",
                        column: x => x.RootId,
                        principalTable: "Root",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_BasicInformationId",
                table: "Artist",
                column: "BasicInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_FormatId",
                table: "Descriptions",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Formats_BasicInformationId",
                table: "Formats",
                column: "BasicInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_BasicInformationId",
                table: "Genres",
                column: "BasicInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Labels_BasicInformationId",
                table: "Labels",
                column: "BasicInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagination_UrlsId",
                table: "Pagination",
                column: "UrlsId");

            migrationBuilder.CreateIndex(
                name: "IX_Releases_basic_informationId",
                table: "Releases",
                column: "basic_informationId");

            migrationBuilder.CreateIndex(
                name: "IX_Releases_RootId",
                table: "Releases",
                column: "RootId");

            migrationBuilder.CreateIndex(
                name: "IX_Root_PaginationId",
                table: "Root",
                column: "PaginationId");

            migrationBuilder.CreateIndex(
                name: "IX_Styles_BasicInformationId",
                table: "Styles",
                column: "BasicInformationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "Releases");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "Formats");

            migrationBuilder.DropTable(
                name: "Root");

            migrationBuilder.DropTable(
                name: "BasicInformation");

            migrationBuilder.DropTable(
                name: "Pagination");

            migrationBuilder.DropTable(
                name: "Urls");
        }
    }
}
