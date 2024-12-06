using System.ComponentModel.DataAnnotations;

namespace DogsApp.Models.Breed
{
    public class BreedPaiViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Breed")]
        public string Name { get; set; } = null!;
    }
}
