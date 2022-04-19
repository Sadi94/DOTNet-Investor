using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = InvestorService.GetNames();
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }
        }
    }
}
