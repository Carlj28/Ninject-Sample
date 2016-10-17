using Ninject_Sample.Interfaces;
using System;

namespace Ninject_Sample
{
    public class DataAnalyzer
    {
        private IDBConection dbConection;
        public DataAnalyzer(IDBConection dbConection)
        {
            if (dbConection == null)
                throw new ArgumentNullException(nameof(dbConection));

            this.dbConection = dbConection;
        }

        public void DownloadData()
        {
            dbConection.DownloadDataFromDB();
        }
    }
}
