using System.Windows.Forms;

namespace Map_Creator
{
    public partial class Form1 : Form
    {
        bool mousedown;
        readonly List<Point> points = [];
        readonly List<Point> clusters = [];
        public Form1()
        {
            InitializeComponent();
            Draw.Paint += Generate_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Buttons //

        private void ChangeSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
        ////////////

        private void Generate_Click(object sender, EventArgs e)
        {
            points.Clear();
            clusters.Clear();
            Random rnd = new();

            if (!int.TryParse(Density.Text, out int numCluster)) numCluster = 0;

            for (int c = 0; c < numCluster; c++)
            {
                int clusterX = rnd.Next(0, Draw.Width);
                int clusterY = rnd.Next(0, Draw.Height);
                clusters.Add(new Point(clusterX, clusterY));
            }

            if (!int.TryParse(AmountSearch.Text, out int amount)) amount = 500;

            if (!int.TryParse(Multiplier.Text, out int MultiplierVal)) MultiplierVal = 1;

            int baseSpread = 10;

            if (clusters.Count == 0)
            {
                for (int i = 0; i < amount; i++)
                {
                    int x = rnd.Next(0, Draw.Width);
                    int y = rnd.Next(0, Draw.Height);
                    points.Add(new Point(x, y));
                }
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    bool UseCluster =  clusters.Count > 0 && rnd.NextDouble() < 0.5; // 70% chance to use a cluster

                    int x, y;

                    if (UseCluster)
                    {
                        Point cluster = clusters[rnd.Next(clusters.Count)];
                        int Spread = baseSpread * MultiplierVal;

                        x = cluster.X + rnd.Next(-Spread, Spread + 1);
                        y = cluster.Y + rnd.Next(-Spread, Spread + 1);
                    }
                    else
                    {
                        x = rnd.Next(0, Draw.Width);
                        y = rnd.Next(0, Draw.Height);
                    }

                    
                    x = Math.Clamp(x, 0, Draw.Width);
                    y = Math.Clamp(y, 0, Draw.Height);
                    points.Add(new Point(x, y));
                }
            }
            Draw.Invalidate();
        }

        private void Generate_Paint(object sender, PaintEventArgs e)
        {
            foreach (Point point in points)
            {
                e.Graphics.FillEllipse(Brushes.White, point.X, point.Y, 5, 5);
            }
        }

        private void Clear_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            points.Clear();
            Draw.Invalidate();
        }

        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
