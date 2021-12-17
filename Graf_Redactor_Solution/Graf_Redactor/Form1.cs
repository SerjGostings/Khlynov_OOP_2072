using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graf_Redactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics graphics;
        List<Figure> fig = new List<Figure>();
        List<Figure> tr = new List<Figure>();

        protected bool IsMouseDown = false;
        protected Point PointStart;
        protected Point PointEnd;
        GetPoint getPoint = new GetPoint(0, 0, 0, 0);
        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            graphics = GraphPanel.CreateGraphics();
           
            foreach (Figure figures in fig)
            {
               figures.Draw(graphics);
            }
        }
        private void GraphPanel_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            PointStart = e.Location;

            getPoint.PointStartX = PointStart.X;
            getPoint.PointStartY = PointStart.Y;
        }

        private void GraphPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                PointEnd = e.Location;
            }
            IsMouseDown = false;
            
            if (radioButton1.Checked)
            {
                Figure wagon = new Wagon(getPoint);
                fig.Add(wagon);
            }
            if (radioButton2.Checked)
            {
                Figure wagonC = new WagonCoal(getPoint);
                fig.Add(wagonC);
            }
            if (radioButton3.Checked)
            {
                Figure wagonS = new WagonSand(getPoint);
                fig.Add(wagonS);
            }
            if (radioButton4.Checked)
            {
                int wagon_count = Int32.Parse(TrainCountBox.Text);
                int wagonC_count = Int32.Parse(TrainCCountBox.Text);
                int wagonS_count = Int32.Parse(TrainSCountBox.Text);
                Figure train = new Train(getPoint, wagon_count, wagonC_count, wagonS_count);
                fig.Add(train);
                tr.Add(train);
            }
            if (radioButton5.Checked)
            {
                Figure rect = new MyRectangle(getPoint);
                fig.Add(rect);
            }
            if (radioButton6.Checked)
            {
                Figure circle = new MyCircle(getPoint);
                fig.Add(circle);
            }
            if (radioButton7.Checked)
            {
                Figure triangle = new Triangle(getPoint);
                fig.Add(triangle);
            }
            if (radioButton8.Checked)
            {
                
            }
            GraphPanel.Refresh();
            getPoint.Reset();
        }
        private void GraphPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                PointEnd = e.Location;
                getPoint.PointEndX = PointEnd.X;
                getPoint.PointEndY = PointEnd.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int weight_all = 0;
            foreach (Train trains in tr)
            {
                weight_all += trains.weight_all();
            }
            weightBox.Text = weight_all.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count_all = 0;
            foreach (Figure fig in fig)
            {
                count_all++; ;
            }
            figCountBox.Text = count_all.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fig.Clear();
            GraphPanel.Refresh();
        }
    }
}
