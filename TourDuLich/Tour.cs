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
    public partial class Tour : Form
    {
        Form frm;

        MongoDatabase db;
        public Tour()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            db = server.GetDatabase("TravelAgency");
            loaddata();
        }

        public void loaddata()
        {
            //gridTour.DataSource = readToTable("TravelAgency", "TOUR");
        }

        public DataTable readToTable(string databaseName, string collectionName)
        {
            string[] attribute = new string[] {"_id", "MATOUR", "DIADIEM", "GIA", "THOIGIAN", "NGAYDI", "PHUONGTIEN", "KHACHSAN", "NHANVIEN", "KHACHHANG" };
            DataTable datatable = new DataTable();
            //Create datatable
            for (int i = 0; i < attribute.Length; i++)
            {
                datatable.Columns.Add(attribute[i]);
            }
            var collection = db.GetCollection<BsonDocument>(collectionName);
            foreach (BsonDocument item in collection.FindAll())
            {
                DataRow newrow = datatable.NewRow();
                for (int j = 0; j < attribute.Length; j++)
                {
                    newrow[j] = item.GetElement(attribute[j]).Value.ToString();
                }
                datatable.Rows.Add(newrow);
            }
            return datatable;
        }


        public BsonArray TachDiaDiem(string text)
        {
            string[] a = text.Split(',');
            BsonArray diadiem = new BsonArray();
            for (int i = 0; i < a.Length; i++)
            {
                diadiem.Add(new BsonDocument {{"DIEMDEN",a[i] }});
            }
            return diadiem;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var collection = db.GetCollection<BsonDocument>("TOUR");
            BsonDocument document = new BsonDocument() { { "MATOUR", txtMa.Text }, { "DIADIEM", TachDiaDiem(txtDD.Text) }, 
            { "GIA", int.Parse(txtGia.Text) },{"THOIGIAN",txtTG.Text},{"NGAYDI",txtND.Text},
            {"PHUONGTIEN",new BsonArray{new BsonDocument{{"TENPT",txtPT.Text},{"SUCCHUA",30}}}},
            {"KHACHSAN",new BsonArray{new BsonDocument{{"TENKS",txtKS.Text},{"DIACHI","xyz"},{"DIENTHOAI","0123456789"}}}},
            {"NHANVIEN",new BsonArray{}},{"KHACHHANG",new BsonArray{}}};
            collection.Insert(document);
            loaddata();
            clear();
        }

        public void clear()
        {
            txtMa.Clear();
            txtDD.Clear();
            txtGia.Clear();
            txtTG.Clear();
            txtPT.Clear();
            txtKS.Clear();
            txtMa.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Tour_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.hienthi.Show();
        }

       


        
    
    }
}
