using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_kullanimi_1_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrtalamaNotUret_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lbNotlar.Items.Clear();
            for(int i = 0; i<= 14; i++)
            {
                int puan = rnd.Next( 0,100);
                lbNotlar.Items.Add(puan);
            }
           
        }

        private void btnGecmeKalmaDurum_Click(object sender, EventArgs e)
        {
            int kaldi = 0, duz = 0, tesekkur = 0, takdir = 0;
            for (int i = 0; i < lbNotlar.Items.Count; i++)
            {
                int puan = Convert.ToInt32(lbNotlar.Items[i]); // i. sıradaki notu alır.

                if (puan < 50)
                {
                    kaldi++;
                }
                else if (puan >= 50 && puan < 80)
                {
                    duz++;
                }
                else if (puan >= 80 && puan < 90)
                {
                    tesekkur++;
                }
                else
                {
                    takdir++;
                }
                lblKalan.Text = "kalan öğrenci sayısı:" + Convert.ToString(kaldi);
                lblDuzGecen.Text = "düz geçen öğrenci sayısı:" + Convert.ToString(duz);
                lblTakdir.Text = "takdir sayısı:" + Convert.ToString(takdir);
                lblTesekkur.Text = "teşekkür sayısı:" + Convert.ToString(tesekkur);
            }
        }
    }
}
