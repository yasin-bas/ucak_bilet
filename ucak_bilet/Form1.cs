using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucak_bilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaydet_button1_Click(object sender, EventArgs e)
        {
            kayıtliste_listBox1.Items.Add("Rota:" + nereden_comboBox1.Text + "-" + nereye_comboBox2.Text + "Tarih: "+tarih_dateTimePicker1.Text+ "Saat:"+saat_maskedTextBox1.Text+"Yolcu Bilgileri - Ad:"+yolcuad_maskedTextBox2.Text+ "Tc:"+tc_maskedTextBox3.Text+ "Telefon: "+tel_maskedTextBox4.Text);
            MessageBox.Show("Kayıt Alındı");
                
        }
    }
}
