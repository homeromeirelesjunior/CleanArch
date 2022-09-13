using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
  public partial class SeedCategories : Migration
  {
    protected override void Up(MigrationBuilder mb)
    {
      mb.Sql("INSERT INTO Categories(Name) " + "VALUES('Alimentos')");
    }

    protected override void Down(MigrationBuilder mb)
    {
      mb.Sql("DELETE FROM Categories");
    }
  }
}
