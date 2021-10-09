using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh2
{
    public partial class Form1 : Form
    {
        int TongTC = 0;
        double TongDiem = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void cbTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTenMon.SelectedIndex)
            {
                case 0 :
                    txtTinChi.Text = "2"; 
                    break;
                case 1:
                    txtTinChi.Text = "3";
                    break;
                case 2:
                    txtTinChi.Text = "3";
                    break;
                case 3:
                    txtTinChi.Text = "2";
                    break;
                case 4:
                    txtTinChi.Text = "3";
                    break;
                default:
                    break;

            }

        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            if(txtDiem.Text != "")
            {
                double d;
                bool isNumeric = double.TryParse(txtDiem.Text, out d);
                if (isNumeric)
                {
                    if(d <= 10 && d >= 0)
                    {
                        lstDS.Items.Add(cbTenMon.SelectedItem.ToString() + "    " + txtTinChi.Text + "-" + txtDiem.Text);
                        TongTC += int.Parse(txtTinChi.Text);
                        txtTongTC.Text = TongTC.ToString();

                        TongDiem += int.Parse(txtTinChi.Text) * double.Parse(txtDiem.Text);
                        txtTongDiem.Text = TongDiem.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Điểm phải trong khoảng [0, 10]");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập sai điểm");
                }  
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập điểm");
            }
            
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            txtDiemTB.Text = (double.Parse(txtTongDiem.Text) / double.Parse(txtTongTC.Text)).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thoát ?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
    }
}
