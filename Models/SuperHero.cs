using System.ComponentModel.DataAnnotations;
namespace DotNET_CRUD.Models
{
    public class SuperHero
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "SuperHero Name")]
        [DataType(DataType.Text)]
        public String SuperHeroName { get; set; } = string.Empty;

        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public String FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public String LastName { get; set; } = string.Empty;

        [Display(Name = "Group")]
        [DataType(DataType.Text)]
        public String Group { get; set; } = string.Empty;
    }
}