using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int rSayi;
        byte hak = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rSayi = rnd.Next(1,  10);
           // lblHak.Text = Convert.ToString(rSayi); hile kodu

        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {   
            int tahminSayisi = Convert.ToInt32(tbTahmin.Text);
            if( tahminSayisi==rSayi && hak>0)
            {      
                MessageBox.Show("Bildiniz", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbTahmin.Enabled = false;
                btnTahmin.Enabled = false;
            }
            else
            {
                hak--;
                lblHak.Text = "Kalan hakkınız:" + hak;
                MessageBox.Show("Bilemediniz", "Tekrar Deneyin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(hak==0)
                {
                    MessageBox.Show("Hakkınız bitti", "Oyundan Çıktınız", MessageBoxButtons.OK);
                    tbTahmin.Enabled = false;
                    btnTahmin.Enabled = false;

                }
            }
        }
    }
}
