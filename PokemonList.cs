using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class PokemonList 
{
     public  List<Pokemon> showPokedex()
    {
        if(!File.Exists("PokemonList.json"))
        {
            File.Create("PokemonList.json");
        }
        var streamReader = new StreamReader("PokemonList.json");

        var readAllPokemons = streamReader.ReadToEnd();

        streamReader.Close();
        var json = Newtonsoft.Json.JsonConvert.DeserializeObject <List<Pokemon>>(readAllPokemons);
        return json; // deserialize no addingNewPokemon ?
    }
    public  void addingNewPokemon(List<Pokemon> showingMyPokedex)
    {
        if(!File.Exists("PokemonList.json"))
        {
            File.Create("PokemonList.json");
        }
        var streamWriter = new StreamWriter("PokemonList.json");
        
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(showingMyPokedex);
        streamWriter.WriteLine(json);
        
        streamWriter.Close();
    }
}
