
namespace BoxOfficeChart.Model
{
    public class BoxOfficeModel
    {
        public BoxOfficeModel(double year, double totalGross, double grossLastYearDelta, double releases, double averageGross, string topMovie)
        {
            Year = year;
            TotalGross = totalGross;
            GrossLastYearDelta = grossLastYearDelta;
            AverageGross = averageGross;
            TopMovie = topMovie;
            Releases = releases;
            TotalGrossInBillion = TotalGross / 1000000000;
        }

        public double Year { get; set; }
        public double TotalGross { get; set; }
        public double TotalGrossInBillion { get; set; }
        public double GrossLastYearDelta { get; set; }
        public double AverageGross { get; set; }
        public double Releases { get; set; }
        public string TopMovie { get; set; }

    }
}
