using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatChange
{
    public partial class NameDialog : Form
    {
        public event EventHandler OKButtonClick;
        public String ResultText
        {
            get
            {
                return textBox1.Text;
            }
        }
        public NameDialog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            okButton.Enabled = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            OKButtonClick.Invoke(this, null);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Close();
        }

        [SecurityPermission(SecurityAction.Demand,
        Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x112;
            const long SC_CLOSE = 0xF060L;

            if (m.Msg == WM_SYSCOMMAND &&
                (m.WParam.ToInt64() & 0xFFF0L) == SC_CLOSE)
            {
                return;
            }

            base.WndProc(ref m);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = textBox1.Text != "";
        }
    }
}
