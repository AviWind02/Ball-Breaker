using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Ball_Breaker.Forms
{
    public partial class DebugWindow : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        public DebugWindow()
        {
            InitializeComponent();
            Debug.WriteLine("Debug window Initialized.");
        }

        private MainGame game = new MainGame();
        private void Debug_Load(object sender, EventArgs e)
        {
            mainLoop.Start();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(Form_MouseDown);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void mainLoop_Tick(object sender, EventArgs e)
        {
            //Speed
            textBoxSpeed.Text = "Ball speed: " + MainGame.speed.ToString();
            textBoxBallSpeedX.Text = "Ball speed X: " + MainGame.ballSpeedX.ToString();
            textBoxBallSpeedY.Text = "Ball speed X: " + MainGame.ballSpeedY.ToString();
            //Ball Stuff
            textBoxPosX.Text = "Ball POS X: " + MainGame.posXBall.ToString();
            textBoxPosY.Text = "Ball POS Y: " + MainGame.posYBall.ToString();
            textBoxBallRad.Text = "Ball radius: " + MainGame.ballRadius.ToString();
            //WallStuff
            textBoxBottomWall.Text = MainGame.bottomWall ? "Bottom wall touched" : "Bottom wall not touched" ;
            textBoxRightWall.Text = MainGame.rightWall ? "Right wall touched" : "Right wall not touched";
            textBoxLeftWall.Text = MainGame.leftWall ? "Left wall touched" : "Left wall not touched";
            textBoxTopWall.Text = MainGame.topWall ? "Top wall touched" : "Top wall not touched";
            textBoxLastWallTouched.Text = "Last wall touched: " + MainGame.lastWallHit;
            textBoxNumOfWallsHit.Text = "Number of hits: " + MainGame.wallhits.ToString();

        }
    }
}
