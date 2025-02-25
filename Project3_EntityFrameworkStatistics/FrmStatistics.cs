using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        Db3Project20Entities db = new Db3Project20Entities();
        //Entity Framework'de Context (DbContext), veritabanı ile uygulama arasındaki iletişimi sağlayan en önemli bileşendir.
        //Veritabanındaki tablolar ile C# içerisindeki entity (varlık) sınıfları arasında bir köprü görevi gör
        private void Form1_Load(object sender, EventArgs e)
        {
            //Toplam Kategori
            int totalcategory = db.TBLCATEGORY.Count();
            lbltotalcategory.Text = totalcategory.ToString();
            //Toplam Ürün
            int totalproduct = db.TBLPRODUCT.Count();
            lbltotalproduct.Text = totalproduct.ToString();
            //Total Müşteri 
            int totalcustomer = db.TBLCUSTOMER.Count();
            lbltotalcustomer.Text = totalcustomer.ToString();
            //Total Sipariş
            int totalorder = db.TBLORDER.Count();
            lbltotalorder.Text = totalorder.ToString();
            //Toplam Stock 
            var totalstock = db.TBLPRODUCT.Sum(x => x.ProductStock);
            lblproducttotalstock.Text = totalstock.ToString();
            //Ortalama Ürün Fiyatı
            var avarageproductprice = db.TBLPRODUCT.Average(x => x.ProductPrice);
            lblproductaverageprice.Text = avarageproductprice.ToString();
            //Toplam Meyve Stoğu
            var totalfruitproduct = db.TBLPRODUCT.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
            lbltotalfruitstock.Text = totalfruitproduct.ToString();
            //Gazozdan kazanılan toplam para
            var productgazoztotalprice1 = db.TBLPRODUCT.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductStock).FirstOrDefault();
            var productgazoztotalprice2 = db.TBLPRODUCT.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
            var price = (productgazoztotalprice1 * productgazoztotalprice2);
            lblproductgazoztotalprice.Text = price.ToString();
            //Stok sayısı 100 den az ürün sayısı
            var productstocksmallerthan100count = db.TBLPRODUCT.Where(x => x.ProductStock < 100).Count();
            lblproductstocksmallerthan100.Text = productstocksmallerthan100count.ToString();
            //Aktif peynir Stoğu
            var activeproductcheesecountstock = db.TBLPRODUCT.Where(b => b.CategoryId == (db.TBLCATEGORY.Where(z => z.CategoryName == "Peynir").Select(w => w.CategoryID).FirstOrDefault()) && b.ProductStatus == true).Sum(y => y.ProductStock);
            lblactiveproductstockcheese.Text = activeproductcheesecountstock.ToString();
            // Türkiye den Gelen Sipariş Sayısı(SQL)
            var orderbyturkeycount = db.Database.SqlQuery<int>("select Count(*) from TBLORDER where CustomerId In \r\n(select CustomerId from TBLCUSTOMER where CustomerCountry='Türkiye')").FirstOrDefault();
                    //SqlQuery metodu ham SQL sorguları çalıştırmak için kullanılır, ancak dönen veriyi uygun bir türde alman gerekir.
                    //Eğer ilişkili tablolar(FK ilişkisi) olmasaydı ve doğrudan CustomerId’yi biliyor olsaydık, WHERE CustomerId = X kullanabilirdik.
                    //Ama burada Türkiye’den olan tüm müşterileri seçmek gerektiği için iç içe sorgu(subquery) kullanıldı.
            lblorderbyTurkeycount.Text = orderbyturkeycount.ToString();
            // Türkiye den Gelen Sipariş Sayısı(EF)
            var turkishcustomerIds = db.TBLCUSTOMER.Where(y => y.CustomerCountry=="Türkiye").Select(k => k.CustomerId).ToList();
            var orderfromturkeycount = db.TBLORDER.Count(y => turkishcustomerIds.Contains(y.CustomerId.Value));
            lblorderbyTurkeycountEF.Text = orderfromturkeycount.ToString();
            //Meyveden kazanılan toplam kazanç (SQL)
            var totalpricebyproductfruit = db.Database.SqlQuery<decimal>("select sum(o.totalprice) as Totalprice from TBLORDER o \r\njoin TBLPRODUCT p on o.ProductId = p.ProductId\r\njoin TBLCATEGORY c on p.CategoryId =c.CategoryID where c.CategoryName ='Meyve'").FirstOrDefault();
            lbltotalpricebyproductfruit.Text = totalpricebyproductfruit.ToString();
            //Meyveden kazanılan toplam kazanç (EF)
            var totalpricebyproductfruitef = (from o in db.TBLORDER
                                              join p in db.TBLPRODUCT on o.ProductId equals p.ProductId
                                              join c in db.TBLCATEGORY on p.CategoryId equals c.CategoryID
                                              where c.CategoryName == "Meyve"
                                              select o.TotalPrice).Sum();
            totalpricebyproductfruitEf.Text = totalpricebyproductfruitef.ToString();
            //Son Eklenen Ürün
                    //OrderBy() → Küçükten büyüğe sıralar (A-Z, 0-9)
                    //OrderByDescending() → Büyükten küçüğe sıralar(Z - A, 9 - 0)
            var lastproductname = db.TBLPRODUCT.OrderByDescending(x => x.ProductId).Select(y =>y.ProductName).FirstOrDefault();
            lbllastproductname.Text = lastproductname.ToString();   
            //Eklenen son ürünün kategorisi
            var lastproductcategoryId = db.TBLPRODUCT.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var lastproductcategoryname = db.TBLCATEGORY.Where(x => x.CategoryID == lastproductcategoryId).Select(y => y.CategoryName).FirstOrDefault();
            lbllastproductcategoryname.Text = lastproductcategoryname.ToString();
            //Aktif Ürün Sayısı
            var activeproductname = db.TBLPRODUCT.Where(x => x.ProductStatus == true).Count();
            lblactiveproductcount.Text = activeproductname.ToString();
            //Dondurmadan Kazanılan total para
            var iceCreamStock = db.TBLPRODUCT.Where(x => x.ProductName == "Dondurma").Select(y => y.ProductStock).FirstOrDefault();
            var iceCreamPrice = db.TBLPRODUCT.Where(x => x.ProductName == "Dondurma").Select(y => y.ProductPrice).FirstOrDefault();
            var totalpriceforicecream = iceCreamPrice * iceCreamStock;
            lbltotalpriceforicecream.Text = totalpriceforicecream + "";
            //Sipariş Veren Son Müşteri
            var lastcustomerıd = db.TBLORDER.OrderByDescending(x => x.OrderId).Select(y => y.CustomerId).FirstOrDefault();
            var lastcustomername = db.TBLCUSTOMER.Where(x => x.CustomerId == lastcustomerıd).Select(y => y.CustomerName).FirstOrDefault();
            lbllastcustomerbyorder.Text = lastcustomername.ToString();
            //Farklı Ülke Sayısı
            var differentcountry = db.TBLCUSTOMER.Select(x => x.CustomerCountry).Distinct().Count();
            lbldifferentcountry.Text = differentcountry + "";
        }
    }
}
