using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cxapi;

namespace VerySploict
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void execute_Click(object sender, EventArgs e)
        {
            Api.Execute(fastColoredTextBox1.Text);
        }

        private void open_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void attach_Click(object sender, EventArgs e)
        {
            Api.Attach();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
