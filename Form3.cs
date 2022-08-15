using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using វចនានុក្រម.Models;
namespace វចនានុក្រម
{
    public partial class Form3 : Form
    {
        public List<DBModel> DB { get; set; }
        public List<DBModel> DB2 { get; set; }
        public Form3(List<DBModel> db)
        {
            this.DB = db;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DB2 = new List<DBModel>();
            //DB = new List<DBModel>();
            //DB2.Add(new DBModel { word = "jojo", description = "koka" });
            DataSet ds = new DataSet();
            DataTable table = new DataTable("dictionary");
            table.Columns.Add("Id",typeof(int));
            table.Columns.Add("word");
            table.Columns.Add("description");
            int i = 0;
            foreach (DBModel data in this.DB)
            {
                i += 1;
                table.Rows.Add(i, data.word, data.description);
                DB2.Add(new DBModel { word = data.word, description = data.description });
            }
            //table.Rows.Add(1,"name","good");
            ds.Tables.Add(table);
            dataGridView1.DataSource = ds.Tables["dictionary"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
