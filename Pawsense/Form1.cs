using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pawsense
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool isWindowVisible = true;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
            timer = new Timer();
            SetRandomTimerInterval();
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Activate();
            textBox1.Focus();
            textBox1.Multiline = false;
            textBox1.MaxLength = 9;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string pressedKey = e.KeyCode.ToString();
            textBox1.Text += pressedKey;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isWindowVisible)
            {
                this.Hide();
                isWindowVisible = false;
            }
            else
            {
                this.Show();
                isWindowVisible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().ToLower() == "terminate")
            {
                Application.Exit();
            }
            else if (textBox1.Text.Trim().ToLower() == "human")
            {
                this.Hide();
                isWindowVisible = false;
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":exploding_head:");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isWindowVisible)
            {
                this.Hide();
                isWindowVisible = false;
            }
            else
            {
                this.Show();
                isWindowVisible = true;
            }

            SetRandomTimerInterval();
        }
        private void SetRandomTimerInterval()
        {
            Random random = new Random();
            int randomInterval = random.Next(20000, 60001);
            timer.Interval = randomInterval;
        }
    }
}
