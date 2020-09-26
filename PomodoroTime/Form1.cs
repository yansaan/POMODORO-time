using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PomodoroTime
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    readonly int work = 25;
    int breaks = 5;
    int longBreak = 15;

    bool breakEnabled = false;
    int workTime = 1;
    int breakTime = 0;

    int currentMin, currentSec;
    private void Form1_Load(object sender, EventArgs e)
    {
      MinLbl.Text = work.ToString("D2");
      ResetBtn.Enabled = false;

      currentMin = work;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      currentSec -= 1;
      if (currentSec < 0)
      {
        currentMin -= 1;
        currentSec = 59;
      } 
      else if (currentSec == 0)
      {
        if (currentMin == 0)
        {
          // Notifikasi

          timer1.Enabled = false;
          StartBtn.Text = "Start";

          currentSec = 0;
          SecLbl.Text = "00";

          if (breakEnabled == true)
          {
            breakEnabled = false;


            currentMin = workTime;
            if (workTime == 5)
            {
              workTime = 1;
              breakTime = 0;
            }
            else
            {
              workTime += 1;
            }
          } 
          else
          {
            breakEnabled = true;
            breakTime += 1;

            if (workTime == 4)
            {
              currentMin = longBreak;
            } 
            else
            {
              currentMin = breaks;
            }
          }
          MinLbl.Text = currentMin.ToString("D2");
          TimeLbl.Text = (breakEnabled) ?"Break " + breakTime.ToString() : "Pashe " + workTime.ToString();
        }
      }

      MinLbl.Text = currentMin.ToString("D2");
      SecLbl.Text = currentSec.ToString("D2");
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      StartBtn.Enabled = true;
      timer2.Enabled = false;
      if (StartBtn.Text == "Start")
      {
        StartBtn.Text = "Stop";
        timer1.Enabled = true;
      }
      else if (StartBtn.Text == "Stop")
      {
        StartBtn.Text = "Start";
      }
    }

    private void StartBtn_Click(object sender, EventArgs e)
    {
      StartBtn.Enabled = false;
      timer2.Enabled = true;

      if (StartBtn.Text == "Stop")
      {
        timer1.Enabled = false;
      }
    }
  }
}
