using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_mod5_1302210004
{
    internal class DataGeneric<T>
    {
        private T Data;
        public DataGeneric(T Data) 
        {
            this.Data = Data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + Data);
        }
    }
}
