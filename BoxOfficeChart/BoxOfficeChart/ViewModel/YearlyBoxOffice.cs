
using BoxOfficeChart.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace BoxOfficeChart
{
    public class YearlyBoxOffice : INotifyPropertyChanged
    {
        List<BoxOfficeModel> yearlyRevenueCollection;
        public List<BoxOfficeModel> RevenueCollection
        { 
            get
            {
                return yearlyRevenueCollection;
            }
            set
            {
                yearlyRevenueCollection = value;
                NotifyPropertyChanged();
            }
        }

        private int selectedIndex;
        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
                SelectedYear = RevenueCollection[selectedIndex];
                NotifyPropertyChanged();
                
            }
        }

        private BoxOfficeModel selectedYear;
        public BoxOfficeModel SelectedYear
        {
            get
            {
                return selectedYear;
            }
            set
            {
                selectedYear = value;
                NotifyPropertyChanged();
            }
        }

        public YearlyBoxOffice()
        {
            RevenueCollection = new List<BoxOfficeModel>(ReadCSV());
            SelectedIndex = RevenueCollection.Count - 1;
            SelectedYear= RevenueCollection[selectedIndex];
        }

        public IEnumerable<BoxOfficeModel> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("BoxOfficeChart.Resources.Raw.boxofficeyearlydata.csv");

            string? line;
            List<string> lines = new List<string>();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            
            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new BoxOfficeModel(Convert.ToDouble(data[0]), Convert.ToDouble(data[1]), Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), Convert.ToDouble(data[4]), data[5]);
            });
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
