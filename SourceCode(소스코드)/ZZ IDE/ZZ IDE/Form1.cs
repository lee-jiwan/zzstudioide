using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace ZZ_IDE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //텍스트 지우기
            fastColoredTextBox1.Text = "";
        }
        private void OpneDlg()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "HTML File|*.html|Any File|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                fastColoredTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = of.FileName;
            }
        }
        private void 붙여넣ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void 열기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpneDlg();
        }

        private void 저장하ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
            catch
            {
                OpneDlg();
            }
        }
        private void SaveDlg()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "HTML File|*.html|Lua File|*.lua|PHP File|*.php|JS File|*.js|Any File|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(sf.FileName);
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
        }
        private void 다른이름으로저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void 자르기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void 복사하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void 배경색상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.BackColor = cd.Color;
            }
        }

        private void 글씨색상ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = cd.Color;
            }
        }

        private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zZIDE정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mainForm1 = new Form2();
            mainForm1.Show();
        }

        private void luaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
        }

        private void cSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;
        }

        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL;
        }

        private void cUSTOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
