using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UIVSC03A
{
    public partial class Form4 : FormTemplate.Form1
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(@"C:\Users\Henry-YAB\Desktop\GDipSA\SA4102\Lectures\UIVSC\Image\ISS-NUS logo.jpg");
        }
    }
}
