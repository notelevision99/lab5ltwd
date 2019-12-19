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
    public partial class frmQuanLiThongTinTaiKhoan : Form
    {
        public frmQuanLiThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        private Account GetAccount()
        {
            Account acc = new Account();
            acc.soTK = txtSTK.Text;
            acc.tenKH = txtTenKH.Text;
            acc.diaChiKH = txtDiaChiKH.Text;
            acc.soTienTrongTK = double.Parse(txtSoTienTrongTK.Text);
            return acc;
        }
        private List<Account> GetListAccount()
        {
            List<Account> list = new List<Account>();
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                Account acc = new Account();
                acc.soTK = listView1.Items[i].SubItems[1].Text;
                acc.tenKH = listView1.Items[i].SubItems[2].Text;
                acc.diaChiKH = listView1.Items[i].SubItems[3].Text;
                acc.soTienTrongTK = double.Parse(listView1.Items[i].SubItems[4].Text);
                list.Add(acc);
            }
            return list;
        }

        private void frmQuanLiThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            //DataTable
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSTK.Text == "" || txtTenKH.Text == "" || txtDiaChiKH.Text == "" || txtSoTienTrongTK.Text == "")
                {
                    MessageBox.Show("Vui lòng điền thông tin đầy đủ");
                }
                List<Account> listAccount = GetListAccount();
                Account findAccount = listAccount.FirstOrDefault(p => p.soTK == txtSTK.Text);
                if (findAccount == null)
                {
                    findAccount = GetAccount();
                }
            }
            catch { }
        }
    }
}
