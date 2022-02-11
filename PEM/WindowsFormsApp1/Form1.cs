using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = open.FileName;
                textBox1.Clear();
                textBox1.Text = filename;
            }
        }

        private static void GenKey_SaveInContainer(string containerName)
        {
            // Create the CspParameters object and set the key container
            // name used to store the RSA key pair.
            var parameters = new CspParameters
            {
                KeyContainerName = containerName
            };

            // Create a new instance of RSACryptoServiceProvider that accesses
            // the key container MyKeyContainerName.
            RSA rsa = new RSACryptoServiceProvider(parameters);

            // Display the key information to the console.
            Console.WriteLine($"Key added to container: \n  {rsa.ToXmlString(true)}");
        }

    }
}
