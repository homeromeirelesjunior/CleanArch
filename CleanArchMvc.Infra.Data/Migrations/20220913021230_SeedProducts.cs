using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " + "VALUES('Caderno espiral', 'Caderno espiral 100 folhas', 7.45, 50, 'caderno1.jpg', 1)");
            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " + "VALUES('Caderno brochura', 'Caderno brochura 50 folhas', 5.45, 50, 'caderno2.jpg', 1)");
            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " + "VALUES('Borracha', 'Borracha branca', 0.45, 150, 'borracha.jpg', 1)");
            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " + "VALUES('Calculadora', 'Calculadora operações básicas', 17.45, 5, 'calculadora.jpg', 2)");
            mb.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId) " + "VALUES('Boneca', 'Boneca de pano', 15.45, 10, 'boneca.jpg', 3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}
