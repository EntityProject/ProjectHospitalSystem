using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectHospitalSystem.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_Bills_BillId",
                table: "payments");

            migrationBuilder.AlterColumn<int>(
                name: "BillId",
                table: "payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_Bills_BillId",
                table: "payments",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "BillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_Bills_BillId",
                table: "payments");

            migrationBuilder.AlterColumn<int>(
                name: "BillId",
                table: "payments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_Bills_BillId",
                table: "payments",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "BillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
