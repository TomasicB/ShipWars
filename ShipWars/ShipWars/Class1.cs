using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ShipWars
{
    class Squareup
    {
        private int len = 33;
        private Pen pen = new Pen(Color.Black, 1);
        private SolidBrush brushh = new SolidBrush(Color.Green);
        private SolidBrush brushm = new SolidBrush(Color.Red);
        private SolidBrush brush = new SolidBrush(Color.Gray);
        private SolidBrush brushs = new SolidBrush(Color.LightBlue);
        public int xp;
        public int yp;
        public int id;
        public bool full;
        public bool shot;
        public Rectangle rec;

        public Squareup(int ID, int X, int Y)
        {
            xp = X;
            yp = Y;
            id = ID;
            full = false;
            shot = false;
            rec = new Rectangle(xp, yp, len, len);
        }

        public void Draw(Graphics gra)
        {
            gra.DrawRectangle(pen, rec);
        }
        public void FillS(Graphics gra)
        {
            gra.FillRectangle(brushs, rec);
        }
        public void Fill(Graphics gra)
        {
            gra.FillRectangle(brush, rec);
        }

        public void FillH(Graphics gra)
        {
            gra.FillRectangle(brushm, rec);
        }
        public void FillM(Graphics gra)
        {
            gra.FillRectangle(brushh, rec);
        }
    }
    class Squaredown
    {
        private int len = 38;
        private Pen pen = new Pen(Color.Black, 1);
        private SolidBrush brush = new SolidBrush(Color.Gray);
        private SolidBrush brushs = new SolidBrush(Color.LightBlue);
        private SolidBrush brushh = new SolidBrush(Color.Green);
        private SolidBrush brushm = new SolidBrush(Color.Red);
        public int xp;
        public int yp;
        public int id;
        public bool full;
        public bool shot;
        public Rectangle rec;

        public Squaredown(int ID, int X, int Y)
        {
            xp = X;
            yp = Y;
            id = ID;
            full = false;
            shot = false;
            rec = new Rectangle(xp, yp, len, len);
        }

        public void Draw(Graphics gra)
        {
            gra.DrawRectangle(pen, rec);
        }
        public void Fill(Graphics gra)
        {
            gra.FillRectangle(brush, rec);
        }
        public void FillS(Graphics gra)
        {
            gra.FillRectangle(brushs, rec);
        }
        public void FillM(Graphics gra)
        {
            gra.FillRectangle(brushh, rec);
        }
        public void FillH(Graphics gra)
        {
            gra.FillRectangle(brushm, rec);
        }
    }

}