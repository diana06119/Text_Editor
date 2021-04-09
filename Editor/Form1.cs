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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RichTextBox GetTextBox()
        {
            RichTextBox rtb = null;

            if (ActiveMdiChild != null)
            {
                rtb = (RichTextBox)ActiveMdiChild.Controls[0];
            }

            return rtb;
        }

        //private void openToolStripMenuItem3_Click(object sender, EventArgs e)
        //{
        //    if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
        //    {
        //        Form2 frm = new Form2 { MdiParent = this, path = ofd.FileName };
        //        frm.Show();
        //    }
        //}

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2 { MdiParent = this };
            frm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                Form2 frm = new Form2 { MdiParent = this, path = ofd.FileName };
                frm.Show();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GetTextBox() == null)
                return;

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                GetTextBox().SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTextBox().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTextBox().Copy();
        }

        private void pasteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GetTextBox().Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTextBox().SelectAll();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
