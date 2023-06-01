using System.IO;

namespace CSVReader_WPF
{
    internal class CSVReader
    {
        private StreamReader streamReader;
        private CsvConfiguration csvConfig;

        public CSVReader(StreamReader streamReader, CsvConfiguration csvConfig)
        {
            this.streamReader = streamReader;
            this.csvConfig = csvConfig;
        }
    }
}