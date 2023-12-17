namespace Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public static class Director
    {
        // Builder uses a complex series of steps
        public static void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
