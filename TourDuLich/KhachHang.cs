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
    public partial class KhachHang : Form
    {
        Form frm;
        MongoDatabase db;
        BsonArray arrayKH = new BsonArray();
        BsonArray arrayDD = new BsonArray();
        BsonArray arrayNV = new BsonArray();
        BsonArray pt = new BsonArray();
        BsonArray ks = new BsonArray();
        string gia, matour, ngaydi, thoigian = null;
        public KhachHang()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            db = server.GetDatabase("TravelAgency");
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string ma = frm_HienThi._id;
            var collection = db.GetCollection<BsonDocument>("TOUR");
            string gioitinh = "";
            foreach (Control item in groupBox2.Controls)
            {
                if (item.GetType() == typeof(RadioButton))
                {
                    if (((RadioButton)item).Checked == true)
                    {
                        gioitinh = item.Text;
                    }
                }
            }
            
            foreach (BsonDocument item in collection.Find(Query.EQ("_id", ObjectId.Parse(ma))))
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
            var query = new QueryDocument("_id", ma);
            collection.Remove(query);
            BsonDocument khachhang = new BsonDocument().Add("TENKH", txtHoTen.Text).Add("DIENTHOAI", txtDT.Text).Add("DIACHI", txtDC.Text).Add("NGAYSINH", txtNS.Text).Add("GIOITINH", gioitinh).Add("CMND", txtCMND.Text);
            BsonDocument document = new BsonDocument()
            .Add("_id", ObjectId.Parse(ma))
            .Add("MATOUR", matour)
            .Add("DIADIEM", arrayDD)
            .Add("GIA", double.Parse(gia))
            .Add("THOIGIAN", thoigian)
            .Add("NGAYDI", ngaydi)
            .Add("PHUONGTIEN", pt)
            .Add("KHACHSAN", ks)
            .Add("NHANVIEN", arrayNV)
            .Add("KHACHHANG", arrayKH.Add(khachhang));
            collection.Save(document);
            this.Close();

        }

        private void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.hienthi.Show();
        }
    }
}
