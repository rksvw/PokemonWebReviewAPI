using GameStore.Models;

namespace GameStore.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemonName(string name);
        decimal GetPokemonRating(int pokeId);
        bool IsPokemonExist(int pokeId);
    }
}
