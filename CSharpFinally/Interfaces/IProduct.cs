using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinally.Interfaces
{
    interface IProduct
    {
        //Mehsullar
        void Products();
        //Satisdan mehsulun geri qaytarilmasi
        string ProductSales();
        //Yeni mehsul elave etmek
        void AddProducts();
        //Mehsulun adini,sayini ve meblegini,categoriyasini deyismek
        void ChangeProductsInfo();
        //Verilmis kateqoriyaya esasen hemin kateqoriyada olan mehsullarin qaytarilmasi
        string ProductForCatecory();
        //Verilmis qiymet araligina esasen hemin araliqda olan mehsullarin qaytarilmasi
        string ProductForPrice();
        //Verilmis ada esasen mehsullarin search edilib qaytarilmasi
        string ShowProductForName();
    }
}
