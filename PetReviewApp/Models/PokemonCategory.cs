namespace PetReviewApp.Models
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }

        public int CategoryId { get; set; }
        public Pokemon Pokemon { get; set; }
        public Category Catgory { get; set; }
    }
}
