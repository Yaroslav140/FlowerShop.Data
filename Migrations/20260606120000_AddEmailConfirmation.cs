using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowerShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailConfirmation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "EmailConfirmationToken",
                table: "Users",
                type: "character varying(64)",
                maxLength: 64,
                nullable: true);

            // Все существующие пользователи считаются подтверждёнными
            migrationBuilder.Sql("UPDATE \"Users\" SET \"EmailConfirmed\" = true");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "EmailConfirmed", table: "Users");
            migrationBuilder.DropColumn(name: "EmailConfirmationToken", table: "Users");
        }
    }
}
