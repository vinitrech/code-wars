namespace katas.JosephusSurvivor;

public class JosephusSurvivorKata
{
    public static int JosSurvivor(int n, int k)
    {
        var group = Enumerable.Range(1, n).ToList();
        var index = 0;

        while(group.Count > 1)
        {
            index = (index + k - 1) % group.Count;
            group.RemoveAt(index);
        }

        return group[0];
    }
}
