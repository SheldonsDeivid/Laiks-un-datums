using System;
using System.Windows.Forms;
using System.IO;

namespace Laiks_un_datums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime theDate;
            theDate = DateTime.Now;
            MessageBox.Show(theDate.ToString());
           File.AppendAllText("LaiksunDatums.txt", theDate.ToString());
            
            
        }
        
    }
}
