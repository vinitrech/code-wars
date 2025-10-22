namespace katas.BreadcrumbGenerator;

public class BreadcrumbGeneratorKata
{
    public static string GenerateBC(string url, string separator)
    {
        var wordsToIgnore = new List<string> { "the", "of", "in", "from", "by", "with", "and", "or", "for", "to", "at", "a" };
        var urlParts = new Uri(new UriBuilder(url).ToString()).Segments.Skip(1).Where(segment => !segment.Contains("index."));
        var sanitizedParts = urlParts.Select(s => s.Split('.')[0].TrimEnd('/').ToUpper()).Prepend("HOME");
        var mountedParts = sanitizedParts.Select((s, i) => new
        {
            href = string.Concat(urlParts.Take(i)),
            text = s.Length > 30
                ? string.Concat(s.Split('-').Where(w => !wordsToIgnore.Contains(w, StringComparer.InvariantCultureIgnoreCase)).Select(c => c[0]))
                : s.Replace("-", " ")
        });

        return string.Join(separator, mountedParts
            .Select((x, i) =>
                i < urlParts.Count()
                    ? $"<a href=\"/{x.href}\">{x.text}</a>"
                    : $"<span class=\"active\">{x.text}</span>"));
    }
}
