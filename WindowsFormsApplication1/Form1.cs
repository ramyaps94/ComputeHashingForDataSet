using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        System.Data.OleDb.OleDbConnection MyConnection;
        System.Data.DataSet DtSet;
        System.Data.OleDb.OleDbDataAdapter MyCommand;
        public Form1()
        {
            InitializeComponent();            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                               
                MyConnection = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='"+textBox1.Text+"';Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\"");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView1.DataSource = DtSet.Tables[0];
                dataGridView1.Show();
                MyConnection.Close();
                btnCompute.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void browseFilebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "Excel files(*.xls)|*.xls";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(theDialog.FileName.ToString());
            }
            textBox1.Text = theDialog.FileName.ToString();
            readExcelbtn.Enabled = true;
        }

        public DataTable DataSetToObject(DataSet ds) 
        {
            ds.Tables[0].Columns.Add("hashValue", typeof(System.Int32));
            int count = 0;
            Hashing.BookPublication bookPub = new Hashing.BookPublication();
            foreach (DataRow dr in ds.Tables[0].Rows) 
            {
                count++;
                long id = 0;
                bool idResult = Int64.TryParse(dr["id"].ToString(), NumberStyles.Integer, CultureInfo.CurrentCulture,out id);
                string title = dr["title"].ToString();
                string author = "";
                if(!string.IsNullOrEmpty(dr["author"].ToString()))
                author = dr["author"].ToString();
                string publication = dr["publication"].ToString();
                DateTime date = default(DateTime);
                if (!string.IsNullOrEmpty(dr["date"].ToString()) && dr["date"].ToString().Length<=10)
                date = DateTime.ParseExact(dr["date"].ToString().Substring(0,10),"dd-MM-yyyy",CultureInfo.CurrentCulture);
                Hashing.BookPublication bp = new Hashing.BookPublication(id,title,author,publication,date);
                dr["hashValue"] = bp.GetHashCode();
                Int32 key = Int32.Parse(dr["hashValue"].ToString());
                Hashing.HashTableOfBook.ComputeHashtable(key, bp);
            }
            return ds.Tables[0];
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataSetToObject(DtSet);
            MessageBox.Show("Hash Value is computed to GRID, Look into the last column", "Hashing Completed");
            dataGridView1.Show();            
            groupBox1.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hashing.BookPublication bookPub = new Hashing.BookPublication();
            int key = Int32.Parse(textBox2.Text);
            bookPub = bookPub.GetDetailsfromKey(key, Hashing.HashTableOfBook.bookTable);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BookId : " + bookPub.BookId.ToString());
            sb.AppendLine("Title : " + bookPub.Title.ToString());
            sb.AppendLine("Author : " + bookPub.Author.ToString());
            sb.AppendLine("Publication : " + bookPub.Publication.ToString());
            sb.AppendLine("Date : " + bookPub.Date.ToString());
            richTextBox1.Text = sb.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
