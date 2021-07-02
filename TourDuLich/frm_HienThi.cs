using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;

namespace TourDuLich
{
    public partial class frm_HienThi : Form
    {
        MongoDatabase db;
        Form frm;
        BsonArray arrayKH = new BsonArray();
        BsonArray arrayDD = new BsonArray();
        BsonArray arrayNV = new BsonArray();
        public static string _id = "";
        string gia, matour, ngaydi, thoigian = null;
        public frm_HienThi()
        {
            InitializeComponent();

            var connectionString = "mongodb://localhost:27017/admin";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            db = server.GetDatabase("TravelAgency");
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm = new NhanVien();
            frm.Show();
            this.Hide();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            frm = new KhachHang();
            frm.Show();
            this.Hide();
        }

        private void btn_ThemTour_Click(object sender, EventArgs e)
        {
            frm = new Tour();
            frm.Show();
            this.Hide();
        }

        public DataTable readToTable(string databaseName, string collectionName)
        {
            string[] attribute = new string[] { "_id", "MATOUR", "GIA", "THOIGIAN", "NGAYDI", "PHUONGTIEN", "KHACHSAN" };
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
        public void loaddata()
        {
            gridTour.DataSource = readToTable("TravelAgency", "TOUR");
        }
        private void btn_Load_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridTour.SelectedRows.Count > 0)
            {
                var collection = db.GetCollection<BsonDocument>("TOUR");
                var query = new QueryDocument("_id", ObjectId.Parse(gridTour.CurrentRow.Cells[0].Value.ToString()));
                collection.Remove(query);
                DataTable dataTable = (DataTable)gridTour.DataSource;
                int index = gridTour.SelectedRows[0].Index;
                dataTable.Rows.RemoveAt(index);
            }
        }

        public DataTable loadDiaDiem(string _id)
        {
            DataTable dtb = new DataTable();
            var collection = db.GetCollection<BsonDocument>("TOUR");
            foreach (BsonDocument item in collection.Find(Query.EQ("_id", ObjectId.Parse(_id))))
            {
                arrayDD = item.GetElement("DIADIEM").Value.AsBsonArray;
            }
            string[] attribute = new string[] { "DIEMDEN" };
            DataTable datatable = new DataTable();
            //Create datatable
            for (int i = 0; i < attribute.Length; i++)
            {
                datatable.Columns.Add(attribute[i]);
            }
            try
            {
                foreach (BsonDocument item in arrayDD)
                {
                    DataRow newrow = datatable.NewRow();
                    for (int j = 0; j < attribute.Length; j++)
                    {
                        newrow[j] = item.GetElement(attribute[j]).Value.ToString();
                    }
                    datatable.Rows.Add(newrow);
                }
            }
            catch { }
            return datatable;
        }

        public DataTable loadKH(string _id)
        {
            DataTable dtb = new DataTable();
            var collection = db.GetCollection<BsonDocument>("TOUR");
            foreach (BsonDocument item in collection.Find(Query.EQ("_id", ObjectId.Parse(_id))))
            {
                arrayKH = item.GetElement("KHACHHANG").Value.AsBsonArray;
            }
            string[] attribute = new string[] { "TENKH", "DIENTHOAI", "DIACHI", "NGAYSINH", "GIOITINH", "CMND" };
            DataTable datatable = new DataTable();
            //Create datatable
            for (int i = 0; i < attribute.Length; i++)
            {
                datatable.Columns.Add(attribute[i]);
            }
            try
            {
                foreach (BsonDocument item in arrayKH)
                {
                    DataRow newrow = datatable.NewRow();
                    for (int j = 0; j < attribute.Length; j++)
                    {
                        newrow[j] = item.GetElement(attribute[j]).Value.ToString();
                    }
                    datatable.Rows.Add(newrow);
                }
            }
            catch
            {
            }
            return datatable;

        }

        public DataTable loadNV(string _id)
        {
            DataTable dtb = new DataTable();
            var collection = db.GetCollection<BsonDocument>("TOUR");
            foreach (BsonDocument item in collection.Find(Query.EQ("_id", ObjectId.Parse(_id))))
            {
                arrayNV = item.GetElement("NHANVIEN").Value.AsBsonArray;
            }
            string[] attribute = new string[] { "TENNV", "CHUCVU", "DIENTHOAI", "DIACHI", "NGAYSINH", "GIOITINH", };
            DataTable datatable = new DataTable();
            //Create datatable
            for (int i = 0; i < attribute.Length; i++)
            {
                datatable.Columns.Add(attribute[i]);
            }
            try
            {
                foreach (BsonDocument item in arrayNV)
                {
                    DataRow newrow = datatable.NewRow();
                    for (int j = 0; j < attribute.Length; j++)
                    {
                        newrow[j] = item.GetElement(attribute[j]).Value.ToString();
                    }
                    datatable.Rows.Add(newrow);
                }
            }
            catch
            {
            }
            return datatable;
        }

        private void gridTour_SelectionChanged(object sender, EventArgs e)
        {
            _id = gridTour.CurrentRow.Cells[0].Value.ToString();
            gridDiaDiem.DataSource = loadDiaDiem(gridTour.CurrentRow.Cells[0].Value.ToString());
            gridKhachHang.DataSource = loadKH(gridTour.CurrentRow.Cells[0].Value.ToString());
            gridNhanVien.DataSource = loadNV(gridTour.CurrentRow.Cells[0].Value.ToString());

        }
        public void timkiem(string ma)
        {
            string[] attribute = new string[] { "_id", "MATOUR", "GIA", "THOIGIAN", "NGAYDI", "PHUONGTIEN", "KHACHSAN" };
            DataTable datatable = new DataTable();
            //Create datatable
            for (int i = 0; i < attribute.Length; i++)
            {
                datatable.Columns.Add(attribute[i]);
            }
            var collection = db.GetCollection<BsonDocument>("TOUR");
            foreach (BsonDocument item in collection.Find(Query.EQ("MATOUR",ma)))
            {
                DataRow newrow = datatable.NewRow();
                for (int j = 0; j < attribute.Length; j++)
                {
                    newrow[j] = item.GetElement(attribute[j]).Value.ToString();
                }
                datatable.Rows.Add(newrow);
            }
            gridTour.DataSource = datatable;
        }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timkiem(txtTimKiem.Text);
            }
        }
       
        private void xoáKH_Click(object sender, EventArgs e)
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
            DataGridViewRow row = gridKhachHang.CurrentRow;
            var query = new QueryDocument("_id", _id);
            collection.Remove(query);
            BsonDocument khachhang = new BsonDocument().Add("TENKH", row.Cells[0].Value.ToString())
                .Add("DIENTHOAI", row.Cells[1].Value.ToString())
                .Add("DIACHI", row.Cells[2].Value.ToString())
                .Add("NGAYSINH", row.Cells[3].Value.ToString())
                .Add("GIOITINH", row.Cells[4].Value.ToString())
                .Add("CMND", row.Cells[5].Value.ToString());
            arrayKH.Remove(khachhang);
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
        }

        private void xoáNV_Click(object sender, EventArgs e)
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
            DataGridViewRow row = gridNhanVien.CurrentRow;
            var query = new QueryDocument("_id", _id);
            collection.Remove(query);
            BsonDocument nhanvien = new BsonDocument().Add("TENNV", row.Cells[0].Value.ToString())
                .Add("CHUCVU", row.Cells[1].Value.ToString())
                .Add("DIENTHOAI", row.Cells[2].Value.ToString())
                .Add("DIACHI", row.Cells[3].Value.ToString())
                .Add("NGAYSINH", row.Cells[4].Value.ToString())
                .Add("GIOITINH", row.Cells[5].Value.ToString());
            arrayNV.Remove(nhanvien);
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
        }

        private void sửaTour_Click(object sender, EventArgs e)
        {
            new SuaTour().Show();
        }
    }
}
