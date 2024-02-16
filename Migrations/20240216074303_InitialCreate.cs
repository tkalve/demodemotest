using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoDemo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Things",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Things", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Things",
                column: "Name",
                values: new object[] {
                    "Apple",
                    "Laptop",
                    "Mountain Bike",
                    "Sunglasses",
                    "Coffee Mug",
                    "Novel",
                    "Piano",
                    "Backpack",
                    "Chess Board",
                    "Guitar",
                    "Yoga Mat",
                    "Telescope",
                    "Globe",
                    "Cactus",
                    "Digital Camera",
                    "Wristwatch",
                    "Running Shoes",
                    "Swimming Goggles",
                    "Cooking Pot",
                    "Smartphone",
                    "Desk Lamp",
                    "Electric Guitar",
                    "Barbell",
                    "Water Bottle",
                    "Sketchbook",
                    "Microscope",
                    "Soccer Ball",
                    "Bird Feeder",
                    "Scented Candle",
                    "Gardening Gloves",
                    "Ice Skates",
                    "Picnic Basket",
                    "Rubik's Cube",
                    "Fountain Pen",
                    "Succulent Plant",
                    "Bluetooth Speaker",
                    "Binoculars",
                    "Acoustic Guitar",
                    "Board Game",
                    "E-Reader",
                    "Hammock",
                    "Snowboard",
                    "Beach Towel",
                    "Travel Guidebook",
                    "Drone",
                    "Plush Toy",
                    "Herbal Tea",
                    "Umbrella",
                    "Dumbbells",
                    "Jigsaw Puzzle"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Things");
        }
    }
}
