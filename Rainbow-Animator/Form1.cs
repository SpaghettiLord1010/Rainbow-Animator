using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using System.Media;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Media.Imaging;

using Microsoft.Win32.SafeHandles;
using System.IO;
using Size = System.Drawing.Size;
using System.Drawing.Drawing2D;

namespace Rainbow_Animator
{


    public partial class RainbowAnimator : Form
    {
        public RainbowAnimator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
               "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|bmp files (*.bmp)|*.bmp|All files (*.*)|*.*";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.Title = "Select  the image to animate!";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fname = dialog.FileName;
                pictureBox1.Image = Image.FromFile(fname);
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }

        if (pictureBox1 != null)
            {
           
                    animate.Enabled = true;
                                
            }

        }

        private void animate_Click(object sender, EventArgs e)
        {
            System.Windows.Media.Imaging.GifBitmapEncoder gEnc = new GifBitmapEncoder();
            String filename = pictureBox1.ImageLocation;
            String Ordner = folderBrowserDialog1.SelectedPath;
            //-----------------------------------------------------------------------------
            string Datei;

            if (Ordner == "")
            {
                if (!Directory.Exists("RainbowAnimator\\Temp"))
                {
                    Directory.CreateDirectory("RainbowAnimator\\Temp");
                }
                Ordner = "RainbowAnimator\\Temp";
            }

            

            //Image copy = pictureBox1.Image;

            button1.Enabled = false;
            TempDir.Enabled = false;
            animate.Enabled = false;

            int addR = 256;
            int addG = 0;
            int addB = 0;

            for (int number = 0; number <= 120; number++)
            {
                System.Windows.Forms.Application.DoEvents();
                Bitmap bm = (Bitmap)pictureBox1.Image.Clone();
                //Bitmap bmp = (Bitmap)pictureBox1.Image;


                progressBar1.PerformStep();
                progressBar1.Refresh();

                switch (number)
                {
                    case int n when (n <= 20):
                        addB+=10;
                        break;
                    case int n when (n <= (20 * 2)):
                        addR-=10;
                        break;
                    case int n when (n <= (20 * 3)):
                        addG+=10;
                        break;
                    case int n when (n <= (20 * 4)):
                        addB-=10;
                        break;
                    case int n when (n <= (20 * 5)):
                        addR+=10;
                        break;
                    case int n when (n <= (20 * 6)):
                        addG-=10;
                        break;
                }
                //Console.WriteLine("number=" + number.ToString() + ": addR="+addR.ToString()+" addG="+addG.ToString()+" addB="+addB.ToString() );



                // ========================================================================================
                for (Int32 y = 0; y < bm.Height; y++)
                {
                    for (Int32 x = 0; x < bm.Width; x++)
                    {
                        Color PixelColor = bm.GetPixel(x, y);
                        int r = PixelColor.R;
                        int g = PixelColor.G;
                        int b = PixelColor.B;
                        //Console.WriteLine("number=" + number.ToString() + ": r=" + r.ToString() + " g="+g.ToString()+" b="+b.ToString() + " addR="+addR.ToString()+" addG="+addG.ToString()+" addB="+addB.ToString() );

                        r += addR;
                        g += addG;
                        b += addB;

                        if (r > 255) r = 255;
                        if (g > 255) g = 255;
                        if (b > 255) b = 255;

                        if (r < 30) r = 30;
                        if (g < 30) g = 30;
                        if (b < 30) b = 30;

                        Color NewColor;
                        NewColor = Color.FromArgb(r, g, b);
                        bm.SetPixel(x, y, NewColor);

                        //PixelColor = bmp.GetPixel(x, y);
                        //r = PixelColor.R;
                        //g = PixelColor.G;
                        //b = PixelColor.B;
                        //Console.WriteLine("NEU r=" + r.ToString() + " g=" + g.ToString() + " b=" + b.ToString() + " addR=" + addR.ToString() + " addG=" + addG.ToString() + " addB=" + addB.ToString());


                    }
                }
                // ========================================================================================
                Datei = Ordner + "\\Colorized" + number.ToString("0000") + ".png";
                bm.Save(Datei);

                //saving the Gif & adding the frames

                var bmp = bm.GetHbitmap();

                var src = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                bmp,
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());
                gEnc.Frames.Add(BitmapFrame.Create(src));




            }

            //---------------------------------------------------------------------------------------


            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter =
               "Animated Gif File (*.gif)|*.gif";
            dialog.Title = "Please select a directory and a filename!";
            dialog.ShowDialog();
            String path = dialog.FileName;
            if (path != null)
            { 
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    gEnc.Save(fs);

                    //open the finished gif
                    

                }
                progressBar1.Value = 0;
            }

            System.Diagnostics.Process.Start(path);

            button1.Enabled = true;
            TempDir.Enabled = true;
            animate.Enabled = true;

            




        }

        private void TempDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            String TempPath = folderBrowserDialog1.SelectedPath;


        }

        private void RainbowAnimator_Load(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }

}
