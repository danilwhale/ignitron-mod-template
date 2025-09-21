using Allumeria;
using Ignitron.Loader.API;

namespace ExampleMod;

public sealed class ExampleMod : Mod
{
    public override void Initialize()
    {
        Logger.Init("Hello, World!");
    }
}