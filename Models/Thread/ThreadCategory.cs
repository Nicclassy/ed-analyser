namespace EdAnalytics.Models;

public abstract record ThreadCategory 
{
    public static ThreadCategory Parse(string? name) =>
        string.IsNullOrWhiteSpace(name) ? new CategoryAbsent() : new Category(name);

    public abstract bool Exists();
}

public sealed record Category(string Name) : ThreadCategory 
{
    public override bool Exists() => true;
}

public sealed record CategoryAbsent : ThreadCategory 
{
    public override bool Exists() => false;
}