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

        private void label1_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show
                    (
                        $"Vui lòng nhập số thứ nhất",
                        "Thông báo lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuHai, out temp))
                    nSoThuHai = Convert.ToDouble(soThuHai);
                else
                {
                    MessageBox.Show(
                         $"Vui lòng nhập số thứ hai",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    return;
                }

                var KetQua = nSoThuNhat + nSoThuHai;
                lblKetQua.Text = KetQua.ToString("N0");

            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                         $"lỗi định dạng. vui lòng nhập số: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                         $"lỗi tràn số. Vui lòng nhập ngắn lại: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                         $"lỗi. Chi tiết lỗi: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nSoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show
                    (
                        $"Vui lòng nhập số thứ nhất",
                        "Thông báo lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuHai, out temp))
                    nSoThuHai = Convert.ToDouble(soThuHai);
                else
                {
                    MessageBox.Show(
                         $"Vui lòng nhập số thứ hai",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    return;
                }

                var KetQua = nSoThuNhat - nSoThuHai;
                lblKetQua.Text = KetQua.ToString("N0");

            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                         $"lỗi định dạng. vui lòng nhập số: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                         $"lỗi tràn số. Vui lòng nhập ngắn lại: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                         $"lỗi. Chi tiết lỗi: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nSoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show
                    (
                        $"Vui lòng nhập số thứ nhất",
                        "Thông báo lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuHai, out temp))
                    nSoThuHai = Convert.ToDouble(soThuHai);
                else
                {
                    MessageBox.Show(
                         $"Vui lòng nhập số thứ hai",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    return;
                }

                var KetQua = nSoThuNhat * nSoThuHai;
                lblKetQua.Text = KetQua.ToString("N0");

            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                         $"lỗi định dạng. vui lòng nhập số: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                         $"lỗi tràn số. Vui lòng nhập ngắn lại: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                         $"lỗi. Chi tiết lỗi: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                double temp = 0, nSoThuNhat = 0, nSoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nSoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show
                    (
                        $"Vui lòng nhập số thứ nhất",
                        "Thông báo lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                var soThuHai = txtSoThuHai.Text;
                if (double.TryParse(soThuHai, out temp))
                    nSoThuHai = Convert.ToDouble(soThuHai);
                else
                {
                    MessageBox.Show(
                         $"Vui lòng nhập số thứ hai",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    return;
                }

                var KetQua = nSoThuNhat / nSoThuHai;
                lblKetQua.Text = KetQua.ToString("N0");

            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                         $"lỗi định dạng. vui lòng nhập số: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(
                         $"lỗi tràn số. Vui lòng nhập ngắn lại: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                         $"lỗi. Chi tiết lỗi: {ex.Message}",
                         "Thông báo lỗi",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
            }
        }
    }
}
