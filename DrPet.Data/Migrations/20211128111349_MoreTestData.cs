using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrPet.Data.Migrations
{
    public partial class MoreTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "Name", "Position", "PublicDescription" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Kiss Erika", 1, "Duis ac sapien laoreet, gravida justo vel, posuere leo. Curabitur mi diam, interdum vel neque in, consequat suscipit ex. Morbi porta sagittis nunc, a dictum tortor viverra et. Mauris egestas at dui in ultrices. Suspendisse tempor imperdiet justo, eget maximus nibh vulputate nec. Quisque vel urna sed ipsum venenatis facilisis. Nam rutrum, augue id rhoncus fermentum, lorem quam suscipit orci, nec lobortis lacus velit a justo. Suspendisse commodo lacus nec sagittis efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dictum aliquet sapien. Nulla id pellentesque nisi. Aliquam viverra, est vel auctor pretium, mauris magna rhoncus nisl, vel dictum arcu velit non dui. Nullam dignissim elit quis lectus aliquam, nec aliquam est molestie. Donec aliquet sed mauris in molestie. Phasellus vitae elit vel mi interdum viverra. Integer vel leo tempus, aliquam enim a, hendrerit ipsum. Pellentesque finibus libero libero, volutpat ullamcorper dui facilisis at. Praesent sit amet lacus mollis, egestas dolor nec, porta est. Integer dapibus ex ipsum, eu semper massa maximus sed. Aenean sodales, nulla ac semper blandit, quam diam dignissim nisi, lobortis posuere ipsum diam vitae justo. Ut fringilla elementum orci at faucibus. Nullam posuere porta purus, eu aliquet felis aliquam volutpat. Phasellus turpis libero, lobortis sit amet diam eget, tempor varius libero. Quisque cursus ullamcorper laoreet." },
                    { 2, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Horváth Tibor", 1, "Duis ac sapien laoreet, gravida justo vel, posuere leo. Curabitur mi diam, interdum vel neque in, consequat suscipit ex. Morbi porta sagittis nunc, a dictum tortor viverra et. Mauris egestas at dui in ultrices. Suspendisse tempor imperdiet justo, eget maximus nibh vulputate nec. Quisque vel urna sed ipsum venenatis facilisis. Nam rutrum, augue id rhoncus fermentum, lorem quam suscipit orci, nec lobortis lacus velit a justo. Suspendisse commodo lacus nec sagittis efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dictum aliquet sapien. Nulla id pellentesque nisi. Aliquam viverra, est vel auctor pretium, mauris magna rhoncus nisl, vel dictum arcu velit non dui. Nullam dignissim elit quis lectus aliquam, nec aliquam est molestie. Donec aliquet sed mauris in molestie. Phasellus vitae elit vel mi interdum viverra. Integer vel leo tempus, aliquam enim a, hendrerit ipsum. Pellentesque finibus libero libero, volutpat ullamcorper dui facilisis at. Praesent sit amet lacus mollis, egestas dolor nec, porta est. Integer dapibus ex ipsum, eu semper massa maximus sed. Aenean sodales, nulla ac semper blandit, quam diam dignissim nisi, lobortis posuere ipsum diam vitae justo. Ut fringilla elementum orci at faucibus. Nullam posuere porta purus, eu aliquet felis aliquam volutpat. Phasellus turpis libero, lobortis sit amet diam eget, tempor varius libero. Quisque cursus ullamcorper laoreet." },
                    { 4, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Kovács József", 1, "Duis ac sapien laoreet, gravida justo vel, posuere leo. Curabitur mi diam, interdum vel neque in, consequat suscipit ex. Morbi porta sagittis nunc, a dictum tortor viverra et. Mauris egestas at dui in ultrices. Suspendisse tempor imperdiet justo, eget maximus nibh vulputate nec. Quisque vel urna sed ipsum venenatis facilisis. Nam rutrum, augue id rhoncus fermentum, lorem quam suscipit orci, nec lobortis lacus velit a justo. Suspendisse commodo lacus nec sagittis efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dictum aliquet sapien. Nulla id pellentesque nisi. Aliquam viverra, est vel auctor pretium, mauris magna rhoncus nisl, vel dictum arcu velit non dui. Nullam dignissim elit quis lectus aliquam, nec aliquam est molestie. Donec aliquet sed mauris in molestie. Phasellus vitae elit vel mi interdum viverra. Integer vel leo tempus, aliquam enim a, hendrerit ipsum. Pellentesque finibus libero libero, volutpat ullamcorper dui facilisis at. Praesent sit amet lacus mollis, egestas dolor nec, porta est. Integer dapibus ex ipsum, eu semper massa maximus sed. Aenean sodales, nulla ac semper blandit, quam diam dignissim nisi, lobortis posuere ipsum diam vitae justo. Ut fringilla elementum orci at faucibus. Nullam posuere porta purus, eu aliquet felis aliquam volutpat. Phasellus turpis libero, lobortis sit amet diam eget, tempor varius libero. Quisque cursus ullamcorper laoreet." },
                    { 1, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dr. Szabó ildikó", 1, "Duis ac sapien laoreet, gravida justo vel, posuere leo. Curabitur mi diam, interdum vel neque in, consequat suscipit ex. Morbi porta sagittis nunc, a dictum tortor viverra et. Mauris egestas at dui in ultrices. Suspendisse tempor imperdiet justo, eget maximus nibh vulputate nec. Quisque vel urna sed ipsum venenatis facilisis. Nam rutrum, augue id rhoncus fermentum, lorem quam suscipit orci, nec lobortis lacus velit a justo. Suspendisse commodo lacus nec sagittis efficitur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis dictum aliquet sapien. Nulla id pellentesque nisi. Aliquam viverra, est vel auctor pretium, mauris magna rhoncus nisl, vel dictum arcu velit non dui. Nullam dignissim elit quis lectus aliquam, nec aliquam est molestie. Donec aliquet sed mauris in molestie. Phasellus vitae elit vel mi interdum viverra. Integer vel leo tempus, aliquam enim a, hendrerit ipsum. Pellentesque finibus libero libero, volutpat ullamcorper dui facilisis at. Praesent sit amet lacus mollis, egestas dolor nec, porta est. Integer dapibus ex ipsum, eu semper massa maximus sed. Aenean sodales, nulla ac semper blandit, quam diam dignissim nisi, lobortis posuere ipsum diam vitae justo. Ut fringilla elementum orci at faucibus. Nullam posuere porta purus, eu aliquet felis aliquam volutpat. Phasellus turpis libero, lobortis sit amet diam eget, tempor varius libero. Quisque cursus ullamcorper laoreet." }
                });

            migrationBuilder.InsertData(
                table: "Consultings",
                columns: new[] { "Id", "Comment", "DateOfCreation", "DateOfUpdate", "EndOfConsulting", "StartOfConsulting", "WorkerId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 28, 20, 13, 48, 388, DateTimeKind.Local).AddTicks(4866), new DateTime(2021, 11, 28, 12, 13, 48, 385, DateTimeKind.Local).AddTicks(5288), 1 },
                    { 2, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 29, 20, 13, 48, 388, DateTimeKind.Local).AddTicks(6012), new DateTime(2021, 11, 29, 12, 13, 48, 388, DateTimeKind.Local).AddTicks(5992), 2 },
                    { 3, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 30, 20, 13, 48, 388, DateTimeKind.Local).AddTicks(6022), new DateTime(2021, 11, 30, 12, 13, 48, 388, DateTimeKind.Local).AddTicks(6018), 3 },
                    { 4, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 1, 20, 13, 48, 388, DateTimeKind.Local).AddTicks(6031), new DateTime(2021, 12, 1, 12, 13, 48, 388, DateTimeKind.Local).AddTicks(6026), 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Consultings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Workers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "PetOwnerships",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TreatmentTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Varieties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfCreation", "DateOfUpdate" },
                values: new object[] { new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
