using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberHW12_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public string Label
        {
            get { return label_Iculc.Text; }
            set { label_Iculc.Text = value; }
        }

        public event EventHandler ResEvent = null;
        public event EventHandler NullEvent = null;

        public event EventHandler PlEvent = null;
        public event EventHandler MiEvent = null;
        public event EventHandler MyEvent = null;
        public event EventHandler SeEvent = null;

        public event EventHandler Num0Event = null;
        public event EventHandler Num1Event = null;
        public event EventHandler Num2Event = null;
        public event EventHandler Num3Event = null;
        public event EventHandler Num4Event = null;
        public event EventHandler Num5Event = null;
        public event EventHandler Num6Event = null;
        public event EventHandler Num7Event = null;
        public event EventHandler Num8Event = null;
        public event EventHandler Num9Event = null;

        private void button_pl_Click(object sender, EventArgs e)
        {
            PlEvent.Invoke(sender, e);
        }
        private void button_mi_Click(object sender, EventArgs e)
        {
            MiEvent.Invoke(sender, e);
        }
        private void button_my_Click(object sender, EventArgs e)
        {
            MyEvent.Invoke(sender, e);
        }
        private void button_se_Click(object sender, EventArgs e)
        {
            SeEvent.Invoke(sender, e);
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            ResEvent.Invoke(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Num9Event.Invoke(sender, e);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Num8Event.Invoke(sender, e);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Num7Event.Invoke(sender, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Num6Event.Invoke(sender, e);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Num5Event.Invoke(sender, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Num4Event.Invoke(sender, e);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Num3Event.Invoke(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Num2Event.Invoke(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Num1Event.Invoke(sender, e);
        }
        private void button0_Click(object sender, EventArgs e)
        {
            Num0Event.Invoke(sender, e);
        }

        private void buttonNull_Click(object sender, EventArgs e)
        {
            NullEvent.Invoke(sender, e);
        }
    }
}
