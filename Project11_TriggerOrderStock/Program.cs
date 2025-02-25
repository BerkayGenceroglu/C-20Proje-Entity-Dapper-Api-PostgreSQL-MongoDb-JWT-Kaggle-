using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Project11_TriggerOrderStock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Sipariş Sistemi ###");
            Console.WriteLine();
            Console.WriteLine("1-Ürün Listesi");
            Console.WriteLine("2-Sipariş Listesi");
            Console.WriteLine("3-Kasa Durumu");
            Console.WriteLine("4-Yeni ürün Satışı");
            Console.WriteLine("5-İşlem Sayacı");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            string number;
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz:");
            number = Console.ReadLine();
            Console.WriteLine();

            Db11Project20Entities db = new Db11Project20Entities();
            if (number == "1")
            {
                Console.WriteLine("------Ürün Listesi -----------");
                var values = db.TBLPRODUCT.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.ProductId + "--"+ "Ürün Adı: " + item.ProductName + " Stok Sayısı: "
                        + item.ProductStock +" Fiyat " + item.ProductPrice + " TL");
                }
            }

            if (number == "2")
            {
                Console.WriteLine("------Sipariş Listesi -----------");
                var values = db.TBLORDER.ToList();
                foreach (var item in values)
                {
                    Console.WriteLine(item.OrderId + "--" + "Ürün Adı: " + item.TBLPRODUCT.ProductName + " birim fiyat: "
                        + item.UnitPrice + " Adet " + item.Quantity + " Toplam Fiyat " + item.TotalPrice);
                }
            }

            if (number == "3")
            {
                Console.WriteLine("------ Kasa Durumu -----------");
                Console.WriteLine();
                var values = db.TBLCASHREGİSTER.Select(x => x.Balance).FirstOrDefault();
                Console.WriteLine("Kasadaki Toplam Tutar:" + values + "TL");
            }

            if (number == "4")
            {
                Console.WriteLine("---- Yeni Ürün Sipariş Girişi ------");
                Console.WriteLine();
                Console.Write("Müşteri Adı: ");
                string customer = Console.ReadLine();

                Console.Write("Ürün Id: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Ürün Adedi: ");
                 int quantity = int.Parse(Console.ReadLine());



                Console.WriteLine("-----ÜRÜN BİLGİLERİ--------");
                Console.WriteLine();

                var productname = db.TBLPRODUCT.Where(x => x.ProductId == productId).Select(x=> x.ProductName).FirstOrDefault();    
                Console.WriteLine("Ürün Adı: " + productname);
                Console.WriteLine();
                var producUnitPrice = db.TBLPRODUCT.Where(x => x.ProductId == productId).Select(y => y.ProductPrice).FirstOrDefault();
                Console.WriteLine("Birim Fiyat:" + producUnitPrice);
                Console.WriteLine();

                var totalPrice = quantity * producUnitPrice;
                Console.WriteLine("Toplam Fiyat: " + totalPrice);

                Console.WriteLine();
                Console.WriteLine("-----ÜRÜN BİLGİLERİ--------");

                TBLORDER tBLORDER = new TBLORDER();
                tBLORDER.Customer = customer;
                tBLORDER.ProductId = productId;
                tBLORDER.Quantity = quantity;
                tBLORDER.UnitPrice = producUnitPrice;
                tBLORDER.TotalPrice = totalPrice;
                db.TBLORDER.Add(tBLORDER);
                db.SaveChanges();
                Console.WriteLine();
            }

            if (number == "5")
            {
                var process = db.TBLPROCESS.Select(x => x.Process).FirstOrDefault();
                Console.WriteLine("Toplam işlem sayısı: " + process);
            }

            Console.Read();
        }
    }
}
