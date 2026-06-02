using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Subiect3
{
    public class PieChartControl : Control
    {
        public List<double> Ponderi { get; set; } = new List<double>();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (Ponderi == null || Ponderi.Count == 0)
                return;

            double total = Ponderi.Sum();
            if (total == 0)
                return;

            float startAngle = 0;

            Rectangle r = new Rectangle(
                10, 10,
                Width - 20,
                Height - 20);

            Random rnd = new Random();

            for (int i = 0; i < Ponderi.Count; i++)
            {
                double p = Ponderi[i];

                float sweep = (float)(p / total * 360);

                using (Brush b = new SolidBrush(
                    Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))))
                {
                    e.Graphics.FillPie(b, r, startAngle, sweep);
                }

                startAngle += sweep;
            }
        }
    }
}