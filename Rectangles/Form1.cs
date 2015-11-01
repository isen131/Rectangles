using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        List<Rectangle> rectangles = new List<Rectangle>();

        public int[] GetSizes()
        {
            int[] sizes = new int[4];
            Random rnd = new Random();
            int width = rnd.Next(401);
            int height = rnd.Next(301);
            int x = rnd.Next(601);
            int y = rnd.Next(501);
            while (x + width > 600)
                x = rnd.Next(601);
            while (y + height > 500)
                y = rnd.Next(500);
            sizes[0] = x;
            sizes[1] = y;
            sizes[2] = width;
            sizes[3] = height;
            return sizes;
        }

        public Pen GetPen()
        {
            Random r = new Random();
            Color color = Color.FromArgb(255, r.Next(255), r.Next(255), r.Next(255));
            Pen pen = new Pen(color);
            return pen;
        }

        public int CountCrossings(Rectangle r)
        {
            int count = 0;
            foreach (Rectangle r1 in rectangles)
            {
                if (r1.IntersectsWith(r))
                    count++;
            }
            return count;
        }

        public void GetMaxCrossings()
        {
            int maxCrossings = 0;
            int currentCrossings = 0;
            foreach (Rectangle r in rectangles)
            {
                currentCrossings = CountCrossings(r);
                if (currentCrossings > maxCrossings)
                    maxCrossings = currentCrossings;
            }
            MaxCrossings_Label.Text = maxCrossings.ToString();
        }

        private void CreateRectangle_Button_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            int[] sizes = GetSizes();
            Rectangle r = new Rectangle(sizes[0], sizes[1], sizes[2], sizes[3]);
            Pen pen = GetPen();
            g.DrawRectangle(pen, r);
            rectangles.Add(r);
            GetMaxCrossings();
        }

        private void ClearAll_Button_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            MaxCrossings_Label.Text = null;
            rectangles.Clear();
        }


    }
}
