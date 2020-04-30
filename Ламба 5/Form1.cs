using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ламба_5
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            productsBindingSource.DataSource = db.Products.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.pr = null;
            frm.db = db;
            DialogResult dr = frm.ShowDialog();


            if (dr == DialogResult.OK)
            {
                productsBindingSource.DataSource = db.Products.ToList();
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Products pr = (Products)productsBindingSource.Current;
            frm.db = db;
            frm.pr = pr;

            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productsBindingSource.DataSource = db.Products.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products pr = (Products)productsBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить учетную запись " + pr.ProductID + "?", "Удаление учетной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                db.Products.Remove(pr);

                try
                {
                    db.SaveChanges();
                    productsBindingSource.DataSource = db.Products.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.InnerException.Message);
                }
            }
        }
    }
}
    

