using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form2 : Form
    {
        public string path { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.Font = richTextBoxText.Font;

            if (fontDlg.ShowDialog() == DialogResult.OK)
                richTextBoxText.Font = fontDlg.Font;
        }
    }
}
