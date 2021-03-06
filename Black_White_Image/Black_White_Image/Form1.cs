﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_White_Image
{
    public partial class Form1 : Form
    {

        islem islemler = new islem();

        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFile = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap asilResim = (Bitmap)Image.FromFile(openFile.FileName);
            Bitmap gelenResim = null;

            switch (comboBox1.SelectedItem)
            {
                case "negatif":
                    gelenResim = islemler.negative((Bitmap)asilResim);
                    break;
                case "gri":
                    gelenResim = islemler.griCevir((Bitmap)asilResim);
                    break;
                case "SiyahBeyazTonu":
                    gelenResim = islemler.griCevir((Bitmap)asilResim);
                    gelenResim = islemler.siyahBeyaz((Bitmap)gelenResim, 128);
                    break;
            }
            pictureBox2.Image = gelenResim;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Negatif")
                {
                    Bitmap bitmap;
                    bitmap = (Bitmap)pictureBox1.Image;

                    Color color = bitmap.GetPixel(e.X, e.Y);
                    pictureBox2.BackColor = color;
                }
            }
        }
    }
}
