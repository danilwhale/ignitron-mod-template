using Allumeria;
using Ignitron.Loader;

namespace ExampleMod;

public sealed class ExampleMod : IModEntrypoint
{
    public void Main(ModBox box)
    {
        Logger.Info("Hello, World!");
    }
}