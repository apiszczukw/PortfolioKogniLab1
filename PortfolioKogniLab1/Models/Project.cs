using System.ComponentModel.DataAnnotations;

namespace PortfolioKogniLab1.Models
{
    public class Project
    {
        public int Id { get; set; }

        // lub
        // public int ProjectId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageLink { get; set; }

        public string Tags { get; set; }
    }
}
