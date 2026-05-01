
namespace Flyweight;

public sealed class FlyweightFactory
{
    private readonly Dictionary<char, CharacterFlyweight> _cache = new();

    public IFlyweight Get(char symbol)
    {
        if (_cache.TryGetValue(symbol, out var flyweight))
        {
            return flyweight;
        }

        flyweight = new CharacterFlyweight(symbol);
        _cache[symbol] = flyweight;
        return flyweight;
    }

    public int Count => _cache.Count;
}

