using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LineaCurva
{
    public partial class Form1 : Form
    {
        List<Point> puntos = new List<Point>();
        Point[] misPuntos;
        byte c = 0;
        Graphics g;
        Bitmap areaDibujo = new Bitmap(636, 429);
        Pen pt = new Pen(Color.Black);
        string color;
        float tamaño;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDibujar.Enabled = false;
            listTamanio.SelectedIndex = 0;
           

        }

        private void picDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            g = Graphics.FromImage(areaDibujo);
            if (e.Button == MouseButtons.Left)
            {

                if (c < 4)
                {
                    puntos.Add(e.Location);
                    g.DrawEllipse(pt, e.X, e.Y, 1, 1);
                    picDibujo.Image = areaDibujo;
                    c++;
                }
                else
                {
                    MessageBox.Show("Ya puedes dibujar");
                    btnDibujar.Enabled = true;
                }

            }
        }

        private Color seleccionDeColor(string color)
        {
            if (color.Equals("Rojo"))
            {
                return Color.Red;
            }
            if (color.Equals("Azul"))
            {
                return Color.Blue;
            }
            if (color.Equals("Cyan"))
            {
                return Color.Cyan;
            }
            if (color.Equals("Verde"))
            {
                return Color.Green;
            }
            if (color.Equals("Amarillo"))
            {
                return Color.Yellow;
            }
            if (color.Equals("Gris"))
            {
                return Color.Gray;
            }
            return Color.Black;
        }



        private void btnDibujar_Click(object sender, EventArgs e)
        {
            color = cmbColor.Text.ToString();
            tamaño = float.Parse(listTamanio.Text.ToString());

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen lapiz = new Pen(seleccionDeColor(color),tamaño);
            misPuntos = new Point[puntos.Count];
            puntos.CopyTo(misPuntos);
            g.DrawBeziers(lapiz, misPuntos);
            picDibujo.Image = areaDibujo;
            c = 0;
            puntos.Clear();
            btnDibujar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            picDibujo.Image = null;
            areaDibujo.Dispose();
            areaDibujo = new Bitmap(636, 429);
            c = 0;
            puntos.Clear();
            btnDibujar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

            sfd.ShowDialog();
            string filename = sfd.FileName;
            areaDibujo.Save(filename);
        }
    }
}
