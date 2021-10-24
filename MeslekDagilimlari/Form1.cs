using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeslekDagilimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ogrenciEkle_Click(object sender, EventArgs e)
        {
            if (tbx_ogrenciEkle.Text != "")
            {
                lbx_ogrenciler.Items.Add(tbx_ogrenciEkle.Text);
                tbx_ogrenciEkle.Text = "";
            }
        }

        private void btn_meslekEkle_Click(object sender, EventArgs e)
        {
            if (tbx_meslekEkle.Text != "")
            {
                lbx_meslekler.Items.Add(tbx_meslekEkle.Text);
                tbx_meslekEkle.Text = "";
            }
        }

        Random random = new Random();
        int ogrenciAl = 0;
        int meslekAl = 0;
        private void btn_dagilim_Click(object sender, EventArgs e)
        {

            foreach (var item in lbx_ogrenciler.Items)
            {


            }

            while (true)
            {
                ogrenciAl = random.Next(lbx_ogrenciler.Items.Count);
                meslekAl = random.Next(lbx_meslekler.Items.Count);
                lbx_dagilim.Items.Add(
                    lbx_ogrenciler.Items[ogrenciAl] +
                    " ---> " +
                    lbx_meslekler.Items[meslekAl]);

                lbx_ogrenciler.Items.RemoveAt(ogrenciAl);

                if (lbx_ogrenciler.Items.Count <= 0) break;
            }
        }
    }
}
