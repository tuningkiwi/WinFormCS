using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormTest_Graphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FromImageImage1(PaintEventArgs e)
        {
            // Create image.
            Image imageFile = Image.FromFile("SampImag.jpg");

            // Create graphics object for alteration.
            Graphics newGraphics = Graphics.FromImage(imageFile);

            // Alter image.
            newGraphics.FillRectangle(new SolidBrush(Color.Black), 100, 50, 100, 100);

            // Draw image to screen.
            e.Graphics.DrawImage(imageFile, new PointF(0.0F, 0.0F));

            // Release graphics object.
            newGraphics.Dispose();
        }



    }
}
