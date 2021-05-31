using System.ComponentModel.DataAnnotations;
namespace CommanderGQL.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        public string LicenseKey { get; set; }
    }
}