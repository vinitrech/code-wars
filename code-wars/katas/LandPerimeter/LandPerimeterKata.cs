namespace katas.LandPerimeter;

public class LandPerimeterKata
{
    public static string Calculate(string[] map)
    {
        var sum = 0;

        for (var rowIndex = 0; rowIndex < map.Length; rowIndex++)
        {
            var block = map[rowIndex];

            for (var columnIndex = 0; columnIndex < block.Length; columnIndex++)
            {
                var element = block[columnIndex];
                var weight = 4;

                if (!element.Equals('X'))
                    continue;

                if (map.ElementAtOrDefault(rowIndex - 1)?.ElementAtOrDefault(columnIndex) == 'X') weight -= 1;
                if (map.ElementAtOrDefault(rowIndex + 1)?.ElementAtOrDefault(columnIndex) == 'X') weight -= 1;
                if (map.ElementAtOrDefault(rowIndex)?.ElementAtOrDefault(columnIndex - 1) == 'X') weight -= 1;
                if (map.ElementAtOrDefault(rowIndex)?.ElementAtOrDefault(columnIndex + 1) == 'X') weight -= 1;

                sum += weight;
            }
        }

        return $"Total land perimeter: {sum}";
    }

    public static string CalculateLinq(string[] map) => $"Total land perimeter: {CalculatePerimeter(map)}";

    private static int CalculatePerimeter(string[] map) => Enumerable.Range(0, map.Length).Select(rowIndex => SumRow(rowIndex, map)).Sum();

    private static int SumRow(int rowIndex, string[] map) =>
        Enumerable.Range(0, map[rowIndex].Length)
            .Sum((int columnIndex) =>
            {
                var element = map[rowIndex][columnIndex];
                var weight = 4;

                if (!element.Equals('X'))
                    return 0;

                if (map.ElementAtOrDefault(rowIndex - 1)?.ElementAtOrDefault(columnIndex) == 'X') weight -= 1;
                if (map.ElementAtOrDefault(rowIndex + 1)?.ElementAtOrDefault(columnIndex) == 'X') weight -= 1;
                if (map.ElementAtOrDefault(rowIndex)?.ElementAtOrDefault(columnIndex - 1) == 'X') weight -= 1;
                if (map.ElementAtOrDefault(rowIndex)?.ElementAtOrDefault(columnIndex + 1) == 'X') weight -= 1;

                return weight;
            });
}
