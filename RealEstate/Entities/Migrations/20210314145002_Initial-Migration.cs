using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    NumOfRooms = table.Column<int>(nullable: false),
                    FloorNo = table.Column<int>(nullable: false),
                    Square = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    Square = table.Column<int>(nullable: false),
                    NumOfRooms = table.Column<int>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    RegionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Houses_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Tashkent" });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "Description", "FloorNo", "ImageURL", "NumOfRooms", "Price", "RegionId", "Square", "Status" },
                values: new object[,]
                {
                    { 1, "New apartment with furniture", 3, "https://img01.cdnbor.uz/storage/uploads/listing_image/2020/09/07/4796303/200x160_fitted/358a23bec1b8765e7d996b8709c1d7bc.jpg", 3, 450.0, 1, 85, 1 },
                    { 2, "New apartment with furniture, TV and internet (students pls don't bother)", 2, "https://img07.cdnbor.uz/storage/uploads/listing_image/2020/08/20/4750987/200x160_fitted/8d56f14d874026ea7372fcd5ef38d0fa.jpg", 3, 500.0, 1, 80, 1 },
                    { 3, "apartment with furniture and TV (students pls don't bother)", 2, "https://img09.cdnbor.uz/storage/uploads/listing_image/2020/12/19/5019614/1920x1080_resized/97a0ae6b2446f4c8f5a6e84e36e9f2e9.jpeg", 1, 300.0, 1, 35, 1 },
                    { 4, "there are some old furniture in the apartment", 1, "https://img02.cdnbor.uz/storage/uploads/listing_image/2019/09/11/4093722/200x160_fitted/1bd6f2237bd96f65d11dd3d5e34bec23.jpg", 2, 35000.0, 1, 50, 0 },
                    { 5, "in good condition", 3, "https://img02.cdnbor.uz/storage/uploads/listing_image/2020/01/12/4337545/200x160_fitted/9ad824a18ce345550290c6c8783238e7.jpg", 2, 40000.0, 1, 60, 0 },
                    { 6, "For Sale asap", 1, "https://img07.cdnbor.uz/storage/uploads/listing_image/2019/09/06/4082046/200x160_fitted/5046b9d8413f72a3aad412db0fb7b737.jpg", 1, 25000.0, 1, 30, 0 },
                    { 7, "in a good condition", 9, "https://img10.cdnbor.uz/storage/uploads/listing_image/2020/05/12/4533019/200x160_fitted/875eca3baaa10acde1afffa1d607a4ad.JPEG", 1, 250.0, 1, 35, 1 },
                    { 8, "in a perfect condition", 2, "https://img06.cdnbor.uz/storage/uploads/listing_image/2021/01/03/5045061/200x160_fitted/a84ff6a169af313c467e8776b06f9abf.jpg", 3, 55000.0, 1, 90, 0 },
                    { 9, "apartment is for a long term rent only with contract", 1, "https://img06.cdnbor.uz/storage/uploads/listing_image/2021/02/18/5156013/200x160_fitted/f163967240f8715cbd98716b2f1118db.jpg", 2, 1000.0, 1, 30, 0 },
                    { 10, "Apartment with 4 bedrooms in a perfect condition in city center", 3, "https://img03.cdnbor.uz/storage/uploads/listing_image/2019/12/08/4282198/200x160_fitted/ca01a8611542d5a240e8c1870523195b.jpg", 4, 100000.0, 1, 100, 0 }
                });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Description", "ImageURL", "NumOfRooms", "Price", "RegionId", "Square", "Status" },
                values: new object[,]
                {
                    { 1, "a cool place", "https://img02.cdnbor.uz/storage/uploads/listing_image/2021/02/13/5143259/200x160_fitted/d105b6e989b550fc0ca7d982c25a690f.jpg", 5, 1200.0, 1, 160, 1 },
                    { 2, "house for sale asap", "https://img04.cdnbor.uz/storage/uploads/listing_image/2021/02/18/5156017/200x160_fitted/998df78b70a2fc148ac91ef55e5a6c3c.jpg", 4, 110000.0, 1, 150, 0 },
                    { 3, "good house", "https://img05.cdnbor.uz/storage/uploads/listing_image/2020/11/04/4920470/200x160_fitted/80d9206c5310864f26ff35978735ca56.jpg", 5, 1500.0, 1, 185, 1 },
                    { 4, "in a good condition ", "https://img10.cdnbor.uz/storage/uploads/listing_image/2020/11/04/4920442/200x160_fitted/c09510779675298b4afba809e48e63ca.jpg", 5, 111200.0, 1, 190, 0 },
                    { 5, "something should've been written here so I wrote", "https://img09.cdnbor.uz/storage/uploads/listing_image/2020/07/10/4672481/200x160_fitted/14cc822dbc2c8830c5d0a7b3b0675ea1.jpg", 5, 1200.0, 1, 200, 1 },
                    { 6, "some description", "https://img05.cdnbor.uz/storage/uploads/listing_image/2021/01/07/5055201/200x160_fitted/1675204b7ee8bab5877e853e657f0e5c.jpg", 4, 120000.0, 1, 165, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_RegionId",
                table: "Apartments",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_RegionId",
                table: "Houses",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
