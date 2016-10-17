using Ninject_Sample.Interfaces;
using System;

namespace Ninject_Sample.DB
{
    public class ProductionDB : IDBConection
    {
        public void DownloadDataFromDB()
        {
            Console.WriteLine("Data downloaded from production database!");
        }
    }
}
