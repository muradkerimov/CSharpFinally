using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinally.Interfaces
{
    interface ISales
    {
        //Satislar
        void Sales();
        //Satis elave etmek
        string AddSales();
        //Umumi satisin geri qaytarilmasi
        void AllSales();
        //Verilen tarix araligina gore hemin tarix araligina olan satislarin qaytarilmasi
        string SalesForData();
        //Verilen bir tarixe gore hemin tarix (il,ay,gun) ucun olan satislarin qaytarilmasi
        string SalesForExactData();
        //Verilmis mebleg araligina gore edilmis satislarin qaytarilmasi
        string SalesForPrice();
        //Verilmis nomreye esasen satisin qaytarilmasi
        string SalesForNumber();
    }
}
