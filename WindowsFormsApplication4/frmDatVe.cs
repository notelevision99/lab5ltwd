using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class frmDatVe : Form
    {
        public frmDatVe()
        {
            InitializeComponent();
        }
        List<Button> danhSachDaChon = new List<Button>();
        private void btnChooseASeat(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                danhSachDaChon.Add(btn);
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
                danhSachDaChon.Remove(btn);
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được đặt");
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            float hangDau = 0;
            float hangGiua = 0;
            float hangCuoi = 0;
            for (int i = 0; i < danhSachDaChon.Count; i++)
            {
                if (float.Parse(danhSachDaChon[i].Text) <= 5)
                {
                    hangDau++;
                }
                else if (float.Parse(danhSachDaChon[i].Text) > 5 && float.Parse(danhSachDaChon[i].Text) <= 10)
                {
                    hangGiua++;
                }
                else if (float.Parse(danhSachDaChon[i].Text) > 10)
                {
                    hangCuoi++;
                }
            }
            float Result = hangDau * 5000 + hangGiua * 6500 + hangCuoi * 8000;
            txtThanhTien.Text = Result.ToString();

            //Button btn = sender as Button;
            foreach (Button btn in danhSachDaChon)
            {
                btn.BackColor = Color.Yellow;
            }
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach(Button btn in danhSachDaChon)
            {
                btn.BackColor = Color.White;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn kết thúc hay không?", "Kết thúc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }
    }
}
