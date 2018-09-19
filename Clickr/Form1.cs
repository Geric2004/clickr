using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickr
{
    public partial class Form1 : Form
    {

        //Decleration of important variables
        int startCount = 3;
        int timeLeft = 10;
        int clicks;
        Double cps;
        

        public Form1()
        {
            InitializeComponent();
            clickerButton.Enabled = false;
        }

        //Countdown timer before starting main timer/time left
        private void StartCount_Tick(object sender, EventArgs e)
        {
            if(startCount > 0)
            {
                startCount = startCount - 1;
                button2.Text = startCount.ToString();
            }

            if(startCount == 0)
            {
                clickerButton.Enabled = true;
                Timer.Start();
                StartCount.Stop();

               
            }
        }

        //Time Left
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLeftDisplay.Text = timeLeft + " s";
            }
            if(timeLeft == 0)
            {
                clickerButton.Enabled = false;
                Timer.Stop();
                cps = clicks / 10;
                cpsResult.Text = cps.ToString() + " CPS";

            }

        }

        //Clicks Button
        private void button1_Click(object sender, EventArgs e)
        {
            clicks = clicks + 1;
            clickerButton.Text = clicks.ToString();
            
        }

        //Start Button
        private void button2_Click(object sender, EventArgs e)
        {
            StartCount.Start();
        }

        //Reset Button
        private void button3_Click(object sender, EventArgs e)
        {
            timeLeft = 10;
            Timer.Stop();
            startCount = 3;
            StartCount.Stop();
            clicks = 0;
            clickerButton.Enabled = true;
            button2.Text = "Start";
            clickerButton.Text = "Clicks";
        }
    }
}
