using Microsoft.EntityFrameworkCore;
using PortfolioKogniLab1.Models;

namespace PortfolioKogniLab1.DAL
{
    public class ProjectsContext : DbContext
    {


        public DbSet<Project> Projects { get; set; }

        public ProjectsContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var listaZDanymi = new List<Project>()
            {
                new Project()
                {
                    Id = 10,
                    Name = "System Rezerwacji Wizyt",
                    Description = "Aplikacja umożliwiająca rezerwację wizyt w salonach usługowych (fryzjer, lekarz, itp.).",
                    Tags = "C#, ASP.NET Core, SQL Server",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                },
                new Project()
                {
                    Id = 11,
                    Name = "Analizator Sentimentów",
                    Description = "Narzędzie analizujące emocje w recenzjach produktów lub komentarzach użytkowników.",
                    Tags = "Python, NLP, scikit-learn",
                    ImageLink = "https://images.pexels.com/photos/3861956/pexels-photo-3861956.jpeg"
                },
                new Project()
                {
                    Id = 12,
                    Name = "System Zarządzania Kursami",
                    Description = "Platforma do tworzenia i monitorowania kursów szkoleniowych dla firm.",
                    Tags = "Java, Spring Boot, PostgreSQL",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                },
                new Project()
                {
                    Id = 13,
                    Name = "Aplikacja Fitness",
                    Description = "Mobilna aplikacja do planowania treningów i śledzenia postępów użytkownika.",
                    Tags = "Flutter, Firebase, Dart",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                },
                new Project()
                {
                    Id = 14,
                    Name = "System Pomocy Technicznej",
                    Description = "Platforma do zgłaszania i obsługi zgłoszeń serwisowych (helpdesk).",
                    Tags = "PHP, Symfony, MySQL",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                },
                new Project()
                {
                    Id = 15,
                    Name = "Wirtualny Asystent Głosowy",
                    Description = "Asystent głosowy wykonujący polecenia i odpowiadający na pytania użytkownika.",
                    Tags = "Python, SpeechRecognition, PyTorch",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                },
                new Project()
                {
                    Id = 16,
                    Name = "System do Ankiet Online",
                    Description = "Aplikacja do tworzenia, udostępniania i analizy wyników ankiet.",
                    Tags = "Vue.js, Node.js, MongoDB",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                },
                new Project()
                {
                    Id = 17,
                    Name = "System Wynajmu Pojazdów",
                    Description = "Platforma do rezerwacji i zarządzania wynajmem samochodów lub rowerów.",
                    Tags = "Ruby on Rails, PostgreSQL, Bootstrap",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                },
                new Project()
                {
                    Id = 18,
                    Name = "Panel Administracyjny Firmy",
                    Description = "Panel dla administratorów do zarządzania pracownikami, dokumentami i zasobami firmy.",
                    Tags = "Angular, .NET Core, SQL Server",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                },
                new Project()
                {
                    Id = 19,
                    Name = "Monitoring Cen Produktów",
                    Description = "Aplikacja śledząca zmiany cen produktów w sklepach internetowych.",
                    Tags = "Python, BeautifulSoup, SQLite",
                    ImageLink = "https://images.pexels.com/photos/3183197/pexels-photo-3183197.jpeg"
                }
            };



            modelBuilder.Entity<Project>().HasData(listaZDanymi);
        }
    }
}
