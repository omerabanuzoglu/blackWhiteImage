using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_White_Image
{
    class islem
    {
        public Bitmap negative(Bitmap bitmap)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            Color firstColor, secondColor;
            int r, g, b;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    firstColor = bitmap.GetPixel(i, j);
                    r = 255 - firstColor.R;
                    g = 255 - firstColor.G;
                    b = 255 - firstColor.B;

                    secondColor = Color.FromArgb(r, g, b);

                    sonuc.SetPixel(i, j, secondColor);
                }
            }
            return sonuc;
        }

        public Bitmap griCevir(Bitmap bitmap)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            int ton;
            Color color;
            Color color2;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    ton = Convert.ToInt32(color.R * 0.299) + Convert.ToInt32(color.G * 0.587) + Convert.ToInt32(color.B * 0.114);
                    color2 = Color.FromArgb(ton, ton, ton);
                    sonuc.SetPixel(i, j, color2);
                }
            }
            return sonuc;
        }

        public Bitmap siyahBeyaz(Bitmap bitmap, int esik)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            Color color;
            Color color2;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    if (color.R >= esik)
                    {
                        color2 = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        color2 = Color.FromArgb(0, 0, 0);
                    }
                    sonuc.SetPixel(i, j, color2);
                }
            }
            return sonuc;
        }
    }
}
