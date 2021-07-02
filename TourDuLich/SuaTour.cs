using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
namespace TourDuLich
{
    public partial class SuaTour : Form
    {
        MongoDatabase db;
        string _id = frm_HienThi._id;
        BsonArray arrayKH = new BsonArray();
        BsonArray arrayDD = new BsonArray();
        BsonArray arrayNV = new BsonArray();
        string gia, matour, ngaydi, thoigian = null;
        public SuaTour()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            db = server.GetDatabase("TravelAgency");
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var collection = db.GetCollection<BsonDocument>("TOUR");
            BsonArray arrayKH = new BsonArray();
            BsonArray arrayDD = new BsonArray();
            BsonArray arrayNV = new BsonArray();
            BsonArray pt = new BsonArray();
            BsonArray ks = new BsonArray();

            foreach (BsonDocument item in collection.Find(Query.EQ("_id", ObjectId.Parse(_id))))
            {
                arrayKH = item.GetElement("KHACHHANG").Value.AsBsonArray;
                arrayDD = item.GetElement("DIADIEM").Value.AsBsonArray;
                arrayNV = item.GetElement("NHANVIEN").Value.AsBsonArray;
                pt = item.GetElement("PHUONGTIEN").Value.AsBsonArray;
                ks = item.GetElement("KHACHSAN").Value.AsBsonArray;
                gia = item.GetElement("GIA").Value.ToString();
                matour = item.GetElement("MATOUR").Value.ToString();
                ngaydi = item.GetElement("NGAYDI").Value.ToString();
                thoigian = item.GetElement("THOIGIAN").Value.ToString();
            }
            if (txtGia.Text != string.Empty)
            {
                gia = txtGia.Text;
            }
            if (txtTG.Text != string.Empty)
            {
                thoigian = txtTG.Text;
            }
            ngaydi = txtND.Text;
            var query = new QueryDocument("_id", _id);
            collection.Remove(query);
            BsonDocument document = new BsonDocument()
            .Add("_id", ObjectId.Parse(_id))
            .Add("MATOUR", matour)
            .Add("DIADIEM", arrayDD)
            .Add("GIA", double.Parse(gia))
            .Add("THOIGIAN", thoigian)
            .Add("NGAYDI", ngaydi)
            .Add("PHUONGTIEN", pt)
            .Add("KHACHSAN", ks)
            .Add("NHANVIEN", arrayNV)
            .Add("KHACHHANG", arrayKH);
            collection.Save(document);
            this.Close();
        }
    }
}
