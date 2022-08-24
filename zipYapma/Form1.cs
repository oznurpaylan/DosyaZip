using Ionic.Zip;
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
using System.IO.Compression;


namespace zipYapma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Ionic.Zip.ZipFile zf = new Ionic.Zip.ZipFile("‪.\\NewZip.zip"); //‪C:\\Users\\B.ismi\\Desktop\\NewZip.zip
                zf.AddFile(ofd.FileName, "");
                zf.Save(".\\NewZip.zip");
            }
        }
    }
}
