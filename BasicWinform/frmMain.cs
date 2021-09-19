using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWinform
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {

                var soThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nSoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ nhất",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuHai,out temp))
                    nSoThuHai = double.Parse(soThuHai);
                else
                {
                    MessageBox.Show(
                    $"Vui lòng nhập lại số thứ hai",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                var ketQua = nSoThuNhat + nSoThuHai;

                lblKetQua.Text = ketQua.ToString("N0");
            }
            #region Catch error
            catch (FormatException ex)
            {
                MessageBox.Show(
                    $"Lỗi định dạng. Vui lòng nhập số. Chi tiết lỗi: {ex.Message}",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                    $"Lỗi tràn số. Vui lòng nhập số ngắn lại. Chi tiết lỗi: {ex.Message}",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi rồi bạn ơi. Chi tiết lỗi: {ex.Message}",
                    "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } 
            #endregion
        }

        private void btnTru_Click(object sender, EventArgs e)
        {

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {

        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
