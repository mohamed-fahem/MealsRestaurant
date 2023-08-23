using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealsRestaurant.Migrations
{
    /// <inheritdoc />
    public partial class adjustcategoryname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Categories_CategoriyId",
                table: "Meals");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_AspNetUsers_ApplicationUserId",
                table: "UserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCards_AspNetUsers_ApplicationUserId",
                table: "UserCards");

            migrationBuilder.DropColumn(
                name: "OrderName",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "UserCards",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCards_ApplicationUserId",
                table: "UserCards",
                newName: "IX_UserCards_UserId");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "UserAddresses",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAddresses_ApplicationUserId",
                table: "UserAddresses",
                newName: "IX_UserAddresses_UserId");

            migrationBuilder.RenameColumn(
                name: "PriceDiscount",
                table: "Orders",
                newName: "TotalPriceAfterDiscount");

            migrationBuilder.RenameColumn(
                name: "FinalPrice",
                table: "Orders",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameColumn(
                name: "CategoriyId",
                table: "Meals",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Meals_CategoriyId",
                table: "Meals",
                newName: "IX_Meals_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Categories_CategoryId",
                table: "Meals",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_AspNetUsers_UserId",
                table: "UserAddresses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCards_AspNetUsers_UserId",
                table: "UserCards",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Categories_CategoryId",
                table: "Meals");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAddresses_AspNetUsers_UserId",
                table: "UserAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCards_AspNetUsers_UserId",
                table: "UserCards");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserCards",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCards_UserId",
                table: "UserCards",
                newName: "IX_UserCards_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserAddresses",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserAddresses_UserId",
                table: "UserAddresses",
                newName: "IX_UserAddresses_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "TotalPriceAfterDiscount",
                table: "Orders",
                newName: "PriceDiscount");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Orders",
                newName: "FinalPrice");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Meals",
                newName: "CategoriyId");

            migrationBuilder.RenameIndex(
                name: "IX_Meals_CategoryId",
                table: "Meals",
                newName: "IX_Meals_CategoriyId");

            migrationBuilder.AddColumn<string>(
                name: "OrderName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Categories_CategoriyId",
                table: "Meals",
                column: "CategoriyId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAddresses_AspNetUsers_ApplicationUserId",
                table: "UserAddresses",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCards_AspNetUsers_ApplicationUserId",
                table: "UserCards",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
