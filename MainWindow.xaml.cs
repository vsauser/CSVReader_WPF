using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Windows;

namespace CSVReader_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ",",
            };

            using var streamReader = File.OpenText("query.csv");
            using var csvReader = new CsvReader(streamReader, csvConfig);

            csvReader.Read();

            PrintData();

            void PrintData()
            {
                for (var i = 0; i < 8900; i++)
                {
                    csvReader.Read();
                    var firstName = csvReader.GetField(6);

                    ListBox_1.Items.Add(firstName);
                }

            }

        }

    }
}
