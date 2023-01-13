using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoUdemy.Migrations
{
    public partial class outrasEntradas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistoVenda_Vendedor_VendedorId",
                table: "RegistoVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistoVenda",
                table: "RegistoVenda");

            migrationBuilder.RenameTable(
                name: "RegistoVenda",
                newName: "RegistroVenda");

            migrationBuilder.RenameIndex(
                name: "IX_RegistoVenda_VendedorId",
                table: "RegistroVenda",
                newName: "IX_RegistroVenda_VendedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistroVenda",
                table: "RegistroVenda",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroVenda_Vendedor_VendedorId",
                table: "RegistroVenda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroVenda_Vendedor_VendedorId",
                table: "RegistroVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistroVenda",
                table: "RegistroVenda");

            migrationBuilder.RenameTable(
                name: "RegistroVenda",
                newName: "RegistoVenda");

            migrationBuilder.RenameIndex(
                name: "IX_RegistroVenda_VendedorId",
                table: "RegistoVenda",
                newName: "IX_RegistoVenda_VendedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistoVenda",
                table: "RegistoVenda",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistoVenda_Vendedor_VendedorId",
                table: "RegistoVenda",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
