namespace EdAnalytics.Models;

public abstract record CreationDate 
{
    public static CreationDate Parse(string? value) =>
        !string.IsNullOrWhiteSpace(value) ? 
        new Date(DateTime.Parse(value)) : new DateAbsent();
}

public sealed record Date(DateTime DateTime) : CreationDate;
public sealed record DateAbsent : CreationDate;