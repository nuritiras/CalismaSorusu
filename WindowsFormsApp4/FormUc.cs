using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormUc : Form
    {
        public List<Kisi> kisiler2 = new List<Kisi>();
        public int indeksNo1=0;
        public FormUc()
        {
            InitializeComponent();
        }
        public int yas;
        private void button1_Click(object sender, EventArgs e)
        {
            FormBir formBir = new FormBir();
            formBir.Show();
            this.Close();
        }

        private void FormUc_Load(object sender, EventArgs e)
        {
            foreach (var kisi in kisiler2)
            {
                if (kisi.yas == kisiler2[indeksNo1].yas)
                {
                    label1.Text = kisi.yas.ToString();
                    label2.Text = kisi.tamAd;
                    break;
                }
                
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kisiler2;

        }
    }
}
