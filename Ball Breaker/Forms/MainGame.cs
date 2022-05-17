using Ball_Breaker.Control;
using Ball_Breaker.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball_Breaker.Forms
{
    public partial class MainGame : Form
    {

        private shapes drawShape = new shapes();
        private control control = new control();
        public MainGame()
        {
            InitializeComponent();
            Debug.WriteLine("Initialized.");
        }

        //Screen size 1000, 500
        //Ball stuff
        public static int posXBall { get; set; } = 1000 / 2;
        public static int posYBall { get; set; } = 500 / 2;
        public static int speed { get; set; } = 6;
        public static int ballSpeedX { get; set; } = speed;
        public static int ballSpeedY { get; set; } = speed;
        public static int ballRadius { get; set; } = 20;
        public static bool topWall { get; set; }
        public static bool rightWall { get; set; }
        public static bool leftWall { get; set; }
        public static bool bottomWall { get; set; }
        public static string lastWallHit { get; set; }
        public static int wallhits { get; set; }
        public static int ballstopRangeRight { get; set; } = 970;
        public static int ballstopRangeTop{ get; set; } = 20;
        public static int ballstopRangeBottom { get; set; } = 440;
        public static int ballstopRangeLeft { get; set; } = 20;


        //paddle stuff
        public static int posXPaddle { get; set; } = 500;
        public static int posYPaddle { get; set; } = 446;
        public static int hPaddle { get; set; } = 10;
        public static int wPaddle { get; set; } = 100;
        public static int paddleSpeed { get; set; } = 5;
        public static int paddlestopRangeRight { get; set; } = 870;
        public static int paddleStopRangeLeft { get; set; } = 10;


        private void MainGame_Load(object sender, EventArgs e)
        {
            mainTick.Start();
            resetTick.Start();
            this.KeyDown += control.downKeyContol;
            this.KeyUp += control.upKeyContol;
            this.Paint += drawPaddle;
            this.Paint += drawBall;
            new DebugWindow().Show();
            Debug.WriteLine("Loaded.");
        }
        private void drawBall(object sender, PaintEventArgs e)
        {
            //Drawing twice to remove the disappering effect
            drawShape.FillCircle(e.Graphics, Brushes.DodgerBlue, posXBall, posYBall, ballRadius);
            drawShape.FillCircle(e.Graphics, Brushes.DodgerBlue, posXBall, posYBall, ballRadius);
        }
        private void drawPaddle(object sender, PaintEventArgs e)
        {
            //Drawing twice to remove the disappering effect
            drawShape.FillRectangle(e.Graphics, Brushes.Gold, posXPaddle, posYPaddle, wPaddle, hPaddle);
            drawShape.FillRectangle(e.Graphics, Brushes.Gold, posXPaddle, posYPaddle, wPaddle, hPaddle);

        }

        private void mainTick_Tick(object sender, EventArgs e)
        {
            /*
          * Anything here will tick every 50 milsecond.
          */
            posXBall += ballSpeedX;
            posYBall += ballSpeedY;
            if (posYBall > ballstopRangeBottom)
            {
                ballSpeedY -= speed;
                bottomWall = true;
                lastWallHit = "Bottom wall";
                wallhits +=1;
            }
            else if (posYBall < ballstopRangeTop)
            {
                ballSpeedY += speed;
                topWall = true;
                lastWallHit = "Top wall";

                wallhits += 1;
            }
            if (posXBall > ballstopRangeRight)
            {
                ballSpeedX -= speed;
                rightWall = true;
                lastWallHit = "Right wall";
                wallhits += 1;
            }
            else if (posXBall < ballstopRangeLeft)
            {
                ballSpeedX += speed;
                leftWall = true;
                lastWallHit = "Left wall";
                wallhits += 1;
            }
            paddleControl();
            Invalidate();
            Update();
        }

        private void resetTick_Tick(object sender, EventArgs e)
        {
            /*
             * Anything here will reset every one second.
             */
            leftWall = false;
            rightWall = false;
            topWall = false;
            bottomWall = false;
        }

        private void paddleControl()
        {
            if(control.isLeftDown)
            {
                if (posXPaddle < paddleStopRangeLeft)
                    return;

                posXPaddle -= paddleSpeed;
            }
            else if(control.isRightDown)
            {
                if (posXPaddle > paddlestopRangeRight)
                    return;
                posXPaddle += paddleSpeed;

            }
        }


    }
}
