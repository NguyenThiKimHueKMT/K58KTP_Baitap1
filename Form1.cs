using System;
using System.Windows.Forms;
using Tholibrary;   // DLL làm thơ

namespace ThoWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakePoem_Click(object sender, EventArgs e)
        {
            PoetryMaker maker = new PoetryMaker();
            maker.InputText = txtInput.Text;
            string poem = maker.MakePoem();
            txtOutput.Text = poem + Environment.NewLine + "--- Thơ của Tôi ---";
        }
    }
}
