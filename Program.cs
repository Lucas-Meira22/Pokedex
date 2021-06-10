using System;

namespace primeiro_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            showIntroduction();
            showActions();
            var selectedOption = getSelectedOption();
            doSelectedAction(selectedOption);

            static void showIntroduction()
            {
                Console.WriteLine("Welcome to your POKEDEX!");
            }

            static void showActions()
            {
                Console.WriteLine("Press:");
                Console.WriteLine("1 - Open your Pokedex.");
                Console.WriteLine("2 - Add a new Pokemon");   
            }

            static string getSelectedOption()
            {
                string choosenOption = Console.ReadLine();
                return choosenOption;
            }
            static void doSelectedAction(string selectedOption)
            {
                PokemonList pokemonList = new PokemonList();
                Pokemon pokemon = new Pokemon();
                if(selectedOption == "1" )
                {
                    // show pokedex
                    pokemonList.showPokedex();
                }
                else if(selectedOption == "2")
                {
                    // add new pokemon .....PokemonList.Add(Pokemon);
                    showAddingNewPokemon();
                    // onde.Add(pokemon); no caso seria a Lista 
                    // pokemonList.addingNewPokemon()
                }
                else
                {
                    // se chegar aqui, fazer um loop para o usuario reecolocar sua nova resposta
                    Console.WriteLine("This is a incorrect caracter, try again...");
                }
            }
            static void showAddingNewPokemon()
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine(); 

                Console.WriteLine("Type:");
                string typePokemon = Console.ReadLine();

                Console.WriteLine("Discription:");
                string discription = Console.ReadLine();

                Console.WriteLine("How many evolutions:");
                int howManyEvolutions = Console.Read();

                Console.WriteLine("OK..your pokemon has been saved");
                // funcao para retornar a pagina inicial
                Pokemon NewPokemon = new Pokemon(name , typePokemon ,discription , howManyEvolutions );
            }
        }    
    }
}  