
namespace Flyweight;

public sealed class CharacterFlyweight : IFlyweight
{
    public CharacterFlyweight(char symbol)
    {
        Symbol = symbol;
    }

    public char Symbol { get; }

    public void Operation(string extrinsicState)
    {
        Console.WriteLine($"Character '{Symbol}' rendered with: {extrinsicState}");
    }
}

