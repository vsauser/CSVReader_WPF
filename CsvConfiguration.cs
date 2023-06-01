using System.Globalization;

internal class CsvConfiguration
{
    private CultureInfo currentCulture;

    public CsvConfiguration(CultureInfo currentCulture)
    {
        this.currentCulture = currentCulture;
    }

    public bool HasHeaderRecord { get; set; }
    public char Comment { get; set; }
    public bool AllowComments { get; set; }
    public string Delimiter { get; set; }
}