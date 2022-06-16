using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryCatalogNetCore.Migrations
{
    public partial class InitialPopulate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var bookStatement = "INSERT INTO Books (Title, Author) VALUES ";
            bookStatement += "('Dune', 'Frank Herbert'),";
            bookStatement += "('The Black Cauldron', 'Lloyd Alexander'),";
            bookStatement += "('The Hobbit', 'J.R.R. Tolkien'),";
            bookStatement += "('Red, White, and Royal Blue', 'Casey McQuiston'),";
            bookStatement += "('Paradise', 'Toni Morrison')";
            migrationBuilder.Sql(bookStatement);

            var patronStatement = "INSERT INTO Patrons (Name) VALUES ";
            patronStatement += "('Jim'),";
            patronStatement += "('Ashley'),";
            patronStatement += "('Harold')";
            migrationBuilder.Sql(patronStatement);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Patrons");
            migrationBuilder.Sql("DELETE FROM Books");
        }
    }
}
