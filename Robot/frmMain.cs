//MIS 330 Steven Green
// PA6_Robot
//Redesign the Jenny the robot program


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(Timer_Tick);

        }
        public int count = 0;
        private Robot robot;
        public void Timer_Tick(object sender, EventArgs eArgs)
        {
            if (sender == timer1)
            {
                try
                {
                    if (lstbxInstructions.Items.Count > count)
                    {
                        count++;
                        movementLogic();
                    }
                    else
                    {
                        MessageBox.Show("End of Run.");
                        timer1.Stop();
                        return;
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            newRobot();
        }
        private void btnN_Click(object sender, System.EventArgs e)
        {
            lstbxInstructions.Items.Add("RobotDirection.N");
        }
        private void btnS_Click(object sender, System.EventArgs e)
        {
            lstbxInstructions.Items.Add("RobotDirection.S");
        }
        private void btnW_Click(object sender, System.EventArgs e)
        {
            lstbxInstructions.Items.Add("RobotDirection.W");
        }
        private void btnE_Click(object sender, System.EventArgs e)
        {
            lstbxInstructions.Items.Add("RobotDirection.E");
        }
        private void btnGo1_Click(object sender, System.EventArgs e)
        {
            lstbxInstructions.Items.Add("MoveRobot(1)");
        }
        private void btnGo10_Click(object sender, System.EventArgs e)
        {
            lstbxInstructions.Items.Add("MoveRobot(10)");
            
        }
        private void MoveRobot(int units)
        {
            robot.Go(units);
            Point rp = robot.Position;
            lblRobot.Location = new Point(rp.X + 100, -rp.Y + 100);
            lblPosition.Text = rp.ToString();
        }
        private void CrashHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Crash!");
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void movementLogic()
        {
            string robotString = lstbxInstructions.SelectedIndex.ToString();
            switch (robotString)
            {
                    case "RobotDirection.N":
                        {
                        robot.Direction = RobotDirection.N;
                        lblRobot.Text = Convert.ToChar(233).ToString();// Up arrow
                        panel1.Refresh();
                        progressBar.PerformStep();
                        break;
                        }
                    case "RobotDirection.S":
                        {
                        robot.Direction = RobotDirection.S;
                        lblRobot.Text = Convert.ToChar(234).ToString();  // Down arrow
                        panel1.Refresh();
                        progressBar.PerformStep();
                        break;
                        }
                    case "RobotDirection.E":
                        {
                        robot.Direction = RobotDirection.E;
                        lblRobot.Text = Convert.ToChar(232).ToString();  // Right arrow
                        panel1.Refresh();
                        progressBar.PerformStep();
                        break;
                        }
                    case "RobotDirection.W":
                        {
                        robot.Direction = RobotDirection.W;
                        lblRobot.Text = Convert.ToChar(231).ToString();  // Left arrow
                        panel1.Refresh();
                        progressBar.PerformStep();
                        break;
                        }
                    case "MoveRobot(1)":
                        {
                        this.MoveRobot(1);
                        panel1.Refresh();
                        progressBar.PerformStep();
                        break;
                        }
                    case "MoveRobot(10)":
                        {
                        this.MoveRobot(10);
                        progressBar.PerformStep();
                        panel1.Refresh();
                        break;
                        }
                
            }
        }
        private void bntPlay_Click(object sender, EventArgs e)
        {
            if (bntPlay.Text == "Play")
            {
                    timer1.Interval = (300);
                    timer1.Enabled = true;
                    bntPlay.Text = "Stop";
                    progressBar.Maximum = lstbxInstructions.Items.Count;
                    progressBar.Step = (progressBar.Maximum / lstbxInstructions.Items.Count);
                    //while (ckbxLoop.Checked == true)
                    //{
                    //    movementLogic();
                    //}
                    //change controls (false) 
            }
            else if (bntPlay.Text == "Stop")
            {
                timer1.Enabled = false;
                bntPlay.Text = "Play";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstbxInstructions.Items.Clear();
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            robot = null;
            newRobot();
            panel1.Refresh();
            lblRobot.Location = new Point(100, 100);
        }

        private void newRobot()
        {
            robot = new Robot();
            robot.Crash += new EventHandler(CrashHandler);
            lblPosition.Text = robot.Position.ToString();
            lblRobot.Text = Convert.ToChar(233).ToString();
        }

        private void btnDataFill_Click(object sender, EventArgs e)
        {
            lstbxInstructions.Items.Add("MoveRobot(10)");
            lstbxInstructions.Items.Add("RobotDirection.E");
            lstbxInstructions.Items.Add("MoveRobot(10)");
            lstbxInstructions.Items.Add("RobotDirection.S");
            lstbxInstructions.Items.Add("MoveRobot(10)");
            lstbxInstructions.Items.Add("RobotDirection.W");
            lstbxInstructions.Items.Add("MoveRobot(10)");
            lstbxInstructions.Items.Add("RobotDirection.N");
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tbSpeed.Value;
        }
    }
}