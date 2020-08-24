using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    interface IPdfFormatter
    {
        void ToPdf();
    }

    interface IExcelFormatter
    {
        void ToExcel();
    }

    class Report : IPdfFormatter, IExcelFormatter
    {
        public void ToExcel()
        {
            Console.WriteLine("Plik Excel wygenerowany!");
        }

        public void ToPdf()
        {
            Console.WriteLine("Plik Pdf Wygenerowany");
        }
    }

    class Poem : IPdfFormatter
    {
        public void ToPdf()
        {
            Console.WriteLine("Plik Pdf Wygenerowany");
        }
    }
}
