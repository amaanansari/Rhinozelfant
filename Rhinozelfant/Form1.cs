using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Rhinozelfant
{
    public partial class Rhinozelefant : Form
    {
        //  Rhinozelefant Form1 = new Form();
        

        public Rhinozelefant()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        public void BildEinlesen()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Bilder (*.BMP) (*.PNG) (*.JPG)|*.bmp;*.png;*.jpg|Alle Dateien (*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap bm = (Bitmap)Image.FromFile(of.FileName);
                    Stopwatch sW = new Stopwatch();
                    prb_working.Value = 0;
                    prb_working.Maximum = (bm.Height * bm.Width) / 100;
                    int ProgressBarZaehler = 0;

                    sW.Start();

                    for (int x = 1; x < bm.Width; x++)
                    {
                        for (int y = 1; y < bm.Height; y++)
                        {
                            if (bm.GetPixel(x, y) == bm.GetPixel(x - 1, y) || bm.GetPixel(x, y) == bm.GetPixel(x, y - 1))
                            {
                                bm.SetPixel(x, y, Color.White);
                            }
                            if (ProgressBarZaehler == 100) { prb_working.Value++; ProgressBarZaehler = 0; }
                            ProgressBarZaehler++;
                        }

                    }
                    pb_bild.Image = bm;
                    sW.Stop();
                    tb_time.Text = Convert.ToString(sW.ElapsedMilliseconds);
                }
                catch
                {
                    MessageBox.Show("Bitte wählen sie ein anderes Bild aus");
                    BildEinlesen();
                
                }

              }
        }

        private void bu_file_Click(object sender, EventArgs e)
        {
            BildEinlesen();

        }

    }
}
