using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Stopwatch : Form
    {
        bool started = false;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (started == false)
            {
                started = true;
                counterLoop();
                startButton.Text = "Stop";
            }
            else
            {
                started = false;
                startButton.Text = "Start";
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            started = false;
            startButton.Text = "Start";
            minutes = 0;
            seconds = 0;
            hours = 0;            
        }

        private void counterLoop()
        {
            while (started == true)
            {
                seconds += 1;
                if (seconds > 59)
                {
                    minutes += 1;
                    seconds = 0;
                }
                if (minutes > 59)
                {
                    hours += 1;
                    minutes = 0;
                }
                
            }
        }

    }
}
