using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioKogniLab1.Migrations
{
    public partial class DodanieDanych : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "ImageLink", "Name", "Tags" },
                values: new object[,]
                {
                    { 10, "Aplikacja umożliwiająca rezerwację wizyt w salonach usługowych (fryzjer, lekarz, itp.).", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "System Rezerwacji Wizyt", "C#, ASP.NET Core, SQL Server" },
                    { 11, "Narzędzie analizujące emocje w recenzjach produktów lub komentarzach użytkowników.", "https://images.pexels.com/photos/3861956/pexels-photo-3861956.jpeg", "Analizator Sentimentów", "Python, NLP, scikit-learn" },
                    { 12, "Platforma do tworzenia i monitorowania kursów szkoleniowych dla firm.", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "System Zarządzania Kursami", "Java, Spring Boot, PostgreSQL" },
                    { 13, "Mobilna aplikacja do planowania treningów i śledzenia postępów użytkownika.", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "Aplikacja Fitness", "Flutter, Firebase, Dart" },
                    { 14, "Platforma do zgłaszania i obsługi zgłoszeń serwisowych (helpdesk).", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "System Pomocy Technicznej", "PHP, Symfony, MySQL" },
                    { 15, "Asystent głosowy wykonujący polecenia i odpowiadający na pytania użytkownika.", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "Wirtualny Asystent Głosowy", "Python, SpeechRecognition, PyTorch" },
                    { 16, "Aplikacja do tworzenia, udostępniania i analizy wyników ankiet.", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "System do Ankiet Online", "Vue.js, Node.js, MongoDB" },
                    { 17, "Platforma do rezerwacji i zarządzania wynajmem samochodów lub rowerów.", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "System Wynajmu Pojazdów", "Ruby on Rails, PostgreSQL, Bootstrap" },
                    { 18, "Panel dla administratorów do zarządzania pracownikami, dokumentami i zasobami firmy.", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "Panel Administracyjny Firmy", "Angular, .NET Core, SQL Server" },
                    { 19, "Aplikacja śledząca zmiany cen produktów w sklepach internetowych.", "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg", "Monitoring Cen Produktów", "Python, BeautifulSoup, SQLite" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
