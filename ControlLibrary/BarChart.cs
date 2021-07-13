using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class BarChart : Control
    {
        private List<BarChartValue> data;
        public List<BarChartValue> Data
        {
            get { return data; }
            set
            {
                data = value;
                Invalidate();   // the chart is no longer good. redraw it!
            }
        }
        public BarChart()
        {
            InitializeComponent();
            Data = new List<BarChartValue>()
            {
            new BarChartValue("Default Currency1", 20),
            new BarChartValue("Default Currency2", 20),
            new BarChartValue("Default Currency3", 20)
            };
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            foreach (var bcv in Data)
            {
                if (bcv.Label.Contains("Default"))
                {
                    return;
                }
            }
            base.OnPaint(pe);
            Graphics graphics = pe.Graphics;
            Rectangle rectangle = pe.ClipRectangle;

            //width bar = width divided by number of bars
            var barWidth = rectangle.Width / Data.Count;
            // so it won't reach the top
            var maxBarHeight = rectangle.Height * 0.9;  //ex 640px // calculate the scale using the highest bar
            var maxValue = Data.Max(x => x.Value);
            var scalingFactor = maxBarHeight / maxValue;    // 640px / 80 = 8 scaling factor


            // REMEMBER - CENTER OF COORDINATES FOR SCREEN - UPPER LEFT CORNER
            for (int i = 0; i < Data.Count; i++)
            {
                var barHeight = Data[i].Value * scalingFactor;
                graphics.FillRectangle(
                    Brushes.Red,
                    i * barWidth + (0.25f * barWidth),   // add a quarter of a bar
                    rectangle.Height - (float)barHeight,
                    barWidth * 0.5f,
                    (float)barHeight
                    );
                graphics.DrawRectangle(
                    Pens.Black,
                    i * barWidth + (0.25f * barWidth),   // add a quarter of a bar
                    rectangle.Height - (float)barHeight,
                    barWidth * 0.5f,
                    (float)barHeight
                    );
                graphics.DrawString(($"{Data[i].Label} - {Data[i].Value}"), Font, Brushes.Black, 
                    i * barWidth + (0.25f * barWidth),(rectangle.Height - (float)barHeight)*1.1f );
            }

            Pen pen = new Pen(Color.Black, 5);
            graphics.DrawRectangle(pen, 0, 0, rectangle.Width - 1, rectangle.Height - 1);
            

        }
    }
}
