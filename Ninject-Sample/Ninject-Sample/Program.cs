using Ninject;
using Ninject_Sample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ninject_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var dbConection = kernel.Get<IDBConection>();

            var dataAnalyzer = new DataAnalyzer(dbConection);
            dataAnalyzer.DownloadData();

            Console.ReadKey();
        }
    }
}
