using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba5
{
    public partial class Form1 : Form

    {
        static bool swich = true;
        void Add_Button(Point point)
        {
            Button button = new Button();
            button.Location = point;
            int x = button.Location.X;
            int y = button.Location.Y;
            button.Text = x.ToString() + " " + y.ToString();
            this.Controls.Add(button);
        }
       
        void ClickEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Add_Button(e.Location); 
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseClick += ClickEvent;
        }
    }
}
