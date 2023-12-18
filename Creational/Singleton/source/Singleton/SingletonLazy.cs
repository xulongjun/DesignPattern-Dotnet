namespace Singleton
{
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> instance = new(() => new SingletonLazy());

        private SingletonLazy() { }

        public static SingletonLazy Instance => instance.Value;

        public string Data => "Singleton Data";
    }
}
