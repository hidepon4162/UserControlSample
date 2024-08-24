using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace UserControlSample
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        // OKボタンのテキストプロパティ
        [Category("ボタン設定")]
        [Description("OKボタンに表示するテキストを設定します。")]
        public string OkButtonText
        {
            get => okButton.Text;
            set => okButton.Text = value;
        }

        // キャンセルボタンのテキストプロパティ
        [Category("ボタン設定")]
        [Description("キャンセルボタンに表示するテキストを設定します。")]
        public string CancelButtonText
        {
            get => cancelButton.Text;
            set => cancelButton.Text = value;
        }

        // OKボタンのClickイベントを外部から登録可能にするイベント
        public event EventHandler OkButtonClick
        {
            add => okButton.Click += value;
            remove => okButton.Click -= value;
        }

        // キャンセルボタンのClickイベントを外部から登録可能にするイベント
        public event EventHandler CancelButtonClick
        {
            add => cancelButton.Click += value;
            remove => cancelButton.Click -= value;
        }
    }
}