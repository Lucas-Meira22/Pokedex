using System;

class Pokemon{
    public Pokemon(string Name , string TypePokemon , string DescriptionPokemon , int howManyEvolutions ){
        this._namePokemon = Name;
        this._typePokemon = TypePokemon;
        this._descriptionPokemon = DescriptionPokemon;
        this._howManyEvolutions = howManyEvolutions;
    }
    private string _namePokemon;
    private string _typePokemon;
    private string _descriptionPokemon;
    private int  _howManyEvolutions;

    public string NamePokemon 
    {
        get
        {
            return _namePokemon;
        }
        set
        {
            _namePokemon = value;
        }
    }

    public string TypePokemon
    {
        get
        {
            return _typePokemon;
        }
        set
        {
            _typePokemon = value;
        }

    }
    public string DescriptionPokemon
    {
        get 
        {
            return _descriptionPokemon;
        }
        set
        {
            _descriptionPokemon = value;
        }
    }
    public int HowManyEvolutions
    {
       get
       {
             return _howManyEvolutions;
       }
       set
        {
            _howManyEvolutions = value;
        }
    }



}