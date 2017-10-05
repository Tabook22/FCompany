using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fcapi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    imgid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    adate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    imgdesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgfolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgfullurl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imglink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgurl_lg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgurl_sm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgurl_th = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.imgid);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    post_adate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    post_author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    post_data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    post_excerpt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    post_img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    post_img_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    post_status = table.Column<int>(type: "int", nullable: false),
                    post_title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
