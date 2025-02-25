using MongoDB.Bson;
using MongoDB.Driver;
using Project9_MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderlist = connection.GetOrders();
            var newItem = new BsonDocument
            {
                {"CustomerName",order.CustomerName },
                {"City",order.City },
                {"District",order.District },
                {"TotalPrice",order.TotalPrice }
            };
            orderlist.InsertOne(newItem);
        }

        public List<Order> GetAllOrders() 
        {
            var connection = new MongoDbConnection();
            var ordercollection = connection.GetOrders();
            var orders = ordercollection.Find(new BsonDocument()).ToList();
            List<Order> Orderlist = new List<Order>();

            foreach (var order in orders)
            {
                Orderlist.Add(new Order
                {
                    City = order["City"].ToString(),
                    CustomerName = order["CustomerName"].ToString(),
                    District = order["District"].ToString(),
                    TotalPrice = decimal.Parse(order["TotalPrice"].ToString()),
                    OrderId = order["_id"].ToString(),
                });
            }
            return Orderlist;
        }

        public void DeleteOrder(string orderId)
        {
            //var:	C# derleyicisi (compiler), değişkenin türünü otomatik olarak belirler.
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrders();
            //Yani koleksiyon kendisi bir tablo gibi düşünülebilir ama içindeki verilere erişmek için bir işlem yapmalıyız. 🚀
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
            //builders:uMongoDB’de sorgular (query) oluşturmayı sağlayan bir yardımcı sınıftır.
            //MongoDB’de veri arama, güncelleme ve sıralama işlemleri yapmamızı sağlayan bir yardımcıdır.
            orderCollection.DeleteOne(filter);
        }

        public void UpdateOrder(Order order)
        {
            /*JSON, bir Excel tablosu gibi verileri saklamak için kullanılan metin tabanlı bir formattır.
            MongoDB, JSON gibi çalışır ama arka planda "BSON" formatında saklar.
            C# ile MongoDB’de çalışırken BsonDocument kullanarak JSON verileri ile işlem yaparız.
            🚀 Kısaca JSON, verileri "tablo yerine metin olarak" saklamamızı sağlayan bir sistemdir! */
            var connection = new MongoDbConnection();
            var ordercollection = connection.GetOrders();
            var filterId = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName",order.CustomerName)
                .Set("City",order.City)
                .Set("District",order.District)
                .Set("TotalPrice",order.TotalPrice);
            ordercollection.UpdateOne(filterId,updatedValue);
        }

        public Order GetByOrder( string id)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrders();
            var filterId = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var result = orderCollection.Find(filterId).FirstOrDefault();
            if (result != null)
            {
                return new Order
                {
                    City = result["City"].ToString(),
                    CustomerName = result["CustomerName"].ToString(),
                    District = result["District"].ToString(),
                    TotalPrice = decimal.Parse(result["TotalPrice"].ToString()),
                    OrderId = result["_id"].ToString()
                };
            }
            else
            {
                return null;
            }

        }
    }
}
