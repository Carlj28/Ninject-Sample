using Ninject_Sample.Interfaces;

namespace Ninject_Sample
{
    public class DataAnalyzer
    {
        private IDBConection dbConection;
        public DataAnalyzer(IDBConection dbConection)
        {
            this.dbConection = dbConection;
        }

        public void DownloadData()
        {
            dbConection.DownloadDataFromDB();
        }
    }
}
