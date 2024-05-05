using System;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public string IPAddress
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Port
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public Form2(string currentIPAddress, string currentPort)
        {
            InitializeComponent();
            IPAddress = currentIPAddress;
            Port = currentPort;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}