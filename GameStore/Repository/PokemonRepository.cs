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

        // ICollection can only be shown or only be read (its just a less fancy list)
        public ICollection<Pokemon> GetPokemons()
        {
            // You have to explicit about what you returning (Here I'm returning a List)
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }
    }
}
