using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VatTu.Report;
using VatTu.SimpleForm;

namespace VatTu
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void RibbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Location = new Point(0, statusStrip1.Location.Y - panel2.Height);
        }

        private void BarButtonItem_ListEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frmChinh = this.CheckExists(typeof(FormNhanVien));
            if (frmChinh != null) frmChinh.Activate();
            else
            {
                FormNhanVien frmNhanVien = new FormNhanVien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.Show();
            }
        }

        private void BarButtonItem_donDatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frpt_PhieuNvLapTrongNamTheoLoai frmPNV = new Frpt_PhieuNvLapTrongNamTheoLoai();
            frmPNV.ShowDialog();
        }

        private void BarButtonItem_listProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormVatTu));
            if (form != null) form.Activate();
            else
            {
                FormVatTu frmVatTu = new FormVatTu();
                frmVatTu.MdiParent = this;
                frmVatTu.Show();
            }
        }

        private void BarButtonItem_ListKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormKho));
            if (form != null) form.Activate();
            else
            {
                FormKho frmKho = new FormKho();
                frmKho.MdiParent = this;
                frmKho.Show();
            }
        }

        private void btnLapPhieu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormLapPhieu));
            if (form != null) form.Activate();
            else
            {
                Program.formLapPhieu = new FormLapPhieu();
                Program.formLapPhieu.MdiParent = this;
                Program.formLapPhieu.Show();
                Program.formLapPhieu.btnSwitch.Links[0].Caption = "Đặt Hàng";
            }
        }

        private void BarButtonItem_CreateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (form != null) form.Activate();
            else
            {
                FormTaoTaiKhoan formTaoTaiKhoan = new FormTaoTaiKhoan();
                formTaoTaiKhoan.MdiParent = this;
                formTaoTaiKhoan.Show();
            }
        }

        private void BarButtonItem_out_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            Program.loginForm.Visible = true;
        }

        // ====== REPORT ======
        private void BarButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormSupportReport3_3));
            if (form != null) form.Activate();
            else
            {
                FormSupportReport3_3 f = new FormSupportReport3_3();
                f.ShowDialog();
            }
        }

        private void BarButtonItem_DHCPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormSupportReport));
            if (form != null) form.Activate();
            else
            {
                FormSupportReport f = new FormSupportReport(4);
                Program.formMain.Enabled = false;
                f.ShowDialog();
            }
        }

        private void BarButtonItem_DSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormSupportReport));
            if (form != null) form.Activate();
            else
            {
                FormSupportReport f = new FormSupportReport(1);
                Program.formMain.Enabled = false;
                f.ShowDialog();
            }
        }

        private void BarButtonItem_DSVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport_DSVatTu reportDSVT = new XtraReport_DSVatTu();
            ReportPrintTool rpt = new ReportPrintTool(reportDSVT);
            reportDSVT.ShowPreviewDialog();
        }

        private void BarButtonItem_THNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(FormSupportReport3_6));
            if (form != null) form.Activate();
            else
            {
                FormSupportReport3_6 f = new FormSupportReport3_6();
                f.ShowDialog();
            }
        }

        private void BarButtonItem_HDNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frpt_HoatDongCuaNhanVien = new Frpt_HoatDongCuaNhanVien();
            Program.frpt_HoatDongCuaNhanVien.Show();
            Program.formMain.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 30;
            if (panel2.Width >= 1400)
            {
                timer1.Stop();
                panel2.Width = 0;
            }
        }

        private void BarButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
