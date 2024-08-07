using GameStore.Data;
using GameStore.Interfaces;
using GameStore.Models;

namespace GameStore.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) 
        {
            _context = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemonName(string name)
        {
            return _context.Pokemon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeId)
        {
            var review = _context.Reviews.Where(p => p.Pokemon.Id == pokeId);
            if (review.Count() <= 0)
            {
                return 0;
            }
            return ((decimal)review.Sum(r => r.Rating) / review.Count());

        }

        // ICollection can only be shown or only be read (its just a less fancy list)
        public ICollection<Pokemon> GetPokemons()
        {
            // You have to explicit about what you returning (Here I'm returning a List)
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        public bool IsPokemonExist(int pokeId)
        {
            return _context.Pokemon.Any(p => p.Id == pokeId);
        }
    }
}
