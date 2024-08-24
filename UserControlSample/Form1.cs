using System;
using System.Windows.Forms;

namespace UserControlSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserControl1_OkButtonClicked(object sender, EventArgs e)
        {
            // OKボタンがクリックされたときの処理
            label1.Text = "OKボタンが押されました";
            userControl1.OkButtonText = "UpDateOK";
        }

        private void UserControl1_CancelButtonClicked(object sender, EventArgs e)
        {
            // キャンセルボタンがクリックされたときの処理
            label1.Text = "キャンセルボタンが押されました";
            userControl1.CancelButtonText = "UpdateCancel";
        }
    }
}
