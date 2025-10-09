namespace katas.ExesAndOhs;

public static class ExesAndOhsKata
{
    public static bool XO(string input) => input.Count("xX".Contains) == input.Count("oO".Contains);
}
