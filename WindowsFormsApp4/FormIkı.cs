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
    public partial class FormIki : Form
    {
        public static List<Kisi> kisiler = new List<Kisi>();
        public FormIki()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBir formBir = new FormBir();
            formBir.kisiler1 = kisiler;
            formBir.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            kisi.tamAd = textBox1.Text;
            kisi.yas =Convert.ToInt32(numericUpDown1.Value);
            kisiler.Add(kisi);  
        }
    }
}
