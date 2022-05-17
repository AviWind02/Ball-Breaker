namespace Ball_Breaker.Forms
{
    partial class DebugWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPosX = new System.Windows.Forms.TextBox();
            this.textBoxPosY = new System.Windows.Forms.TextBox();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxBallSpeedX = new System.Windows.Forms.TextBox();
            this.textBoxBallSpeedY = new System.Windows.Forms.TextBox();
            this.textBoxBallRad = new System.Windows.Forms.TextBox();
            this.textBoxTopWall = new System.Windows.Forms.TextBox();
            this.textBoxBottomWall = new System.Windows.Forms.TextBox();
            this.textBoxRightWall = new System.Windows.Forms.TextBox();
            this.textBoxLeftWall = new System.Windows.Forms.TextBox();
            this.textBoxLastWallTouched = new System.Windows.Forms.TextBox();
            this.textBoxNumOfWallsHit = new System.Windows.Forms.TextBox();
            this.mainLoop = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNumOfWallsHit);
            this.groupBox1.Controls.Add(this.textBoxLastWallTouched);
            this.groupBox1.Controls.Add(this.textBoxLeftWall);
            this.groupBox1.Controls.Add(this.textBoxRightWall);
            this.groupBox1.Controls.Add(this.textBoxBottomWall);
            this.groupBox1.Controls.Add(this.textBoxTopWall);
            this.groupBox1.Controls.Add(this.textBoxBallRad);
            this.groupBox1.Controls.Add(this.textBoxBallSpeedY);
            this.groupBox1.Controls.Add(this.textBoxBallSpeedX);
            this.groupBox1.Controls.Add(this.textBoxSpeed);
            this.groupBox1.Controls.Add(this.textBoxPosY);
            this.groupBox1.Controls.Add(this.textBoxPosX);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug Box";
            // 
            // textBoxPosX
            // 
            this.textBoxPosX.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPosX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPosX.ForeColor = System.Drawing.Color.Red;
            this.textBoxPosX.Location = new System.Drawing.Point(6, 19);
            this.textBoxPosX.Name = "textBoxPosX";
            this.textBoxPosX.Size = new System.Drawing.Size(313, 22);
            this.textBoxPosX.TabIndex = 0;
            this.textBoxPosX.Text = "POS X";
            // 
            // textBoxPosY
            // 
            this.textBoxPosY.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxPosY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPosY.ForeColor = System.Drawing.Color.Red;
            this.textBoxPosY.Location = new System.Drawing.Point(6, 47);
            this.textBoxPosY.Name = "textBoxPosY";
            this.textBoxPosY.Size = new System.Drawing.Size(313, 22);
            this.textBoxPosY.TabIndex = 1;
            this.textBoxPosY.Text = "POS Y";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpeed.ForeColor = System.Drawing.Color.Red;
            this.textBoxSpeed.Location = new System.Drawing.Point(6, 75);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(313, 22);
            this.textBoxSpeed.TabIndex = 2;
            this.textBoxSpeed.Text = "ballSpeed";
            // 
            // textBoxBallSpeedX
            // 
            this.textBoxBallSpeedX.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxBallSpeedX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBallSpeedX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBallSpeedX.ForeColor = System.Drawing.Color.Red;
            this.textBoxBallSpeedX.Location = new System.Drawing.Point(6, 103);
            this.textBoxBallSpeedX.Name = "textBoxBallSpeedX";
            this.textBoxBallSpeedX.Size = new System.Drawing.Size(313, 22);
            this.textBoxBallSpeedX.TabIndex = 3;
            this.textBoxBallSpeedX.Text = "ballSpeedX";
            // 
            // textBoxBallSpeedY
            // 
            this.textBoxBallSpeedY.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxBallSpeedY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBallSpeedY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBallSpeedY.ForeColor = System.Drawing.Color.Red;
            this.textBoxBallSpeedY.Location = new System.Drawing.Point(6, 131);
            this.textBoxBallSpeedY.Name = "textBoxBallSpeedY";
            this.textBoxBallSpeedY.Size = new System.Drawing.Size(313, 22);
            this.textBoxBallSpeedY.TabIndex = 4;
            this.textBoxBallSpeedY.Text = "ballSpeedY";
            // 
            // textBoxBallRad
            // 
            this.textBoxBallRad.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxBallRad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBallRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBallRad.ForeColor = System.Drawing.Color.Red;
            this.textBoxBallRad.Location = new System.Drawing.Point(6, 159);
            this.textBoxBallRad.Name = "textBoxBallRad";
            this.textBoxBallRad.Size = new System.Drawing.Size(313, 22);
            this.textBoxBallRad.TabIndex = 5;
            this.textBoxBallRad.Text = "ballRad";
            // 
            // textBoxTopWall
            // 
            this.textBoxTopWall.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxTopWall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTopWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTopWall.ForeColor = System.Drawing.Color.Red;
            this.textBoxTopWall.Location = new System.Drawing.Point(6, 299);
            this.textBoxTopWall.Name = "textBoxTopWall";
            this.textBoxTopWall.Size = new System.Drawing.Size(313, 22);
            this.textBoxTopWall.TabIndex = 6;
            this.textBoxTopWall.Text = "topWall";
            // 
            // textBoxBottomWall
            // 
            this.textBoxBottomWall.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxBottomWall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBottomWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBottomWall.ForeColor = System.Drawing.Color.Red;
            this.textBoxBottomWall.Location = new System.Drawing.Point(6, 271);
            this.textBoxBottomWall.Name = "textBoxBottomWall";
            this.textBoxBottomWall.Size = new System.Drawing.Size(313, 22);
            this.textBoxBottomWall.TabIndex = 7;
            this.textBoxBottomWall.Text = "bottomWall";
            // 
            // textBoxRightWall
            // 
            this.textBoxRightWall.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxRightWall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRightWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRightWall.ForeColor = System.Drawing.Color.Red;
            this.textBoxRightWall.Location = new System.Drawing.Point(6, 243);
            this.textBoxRightWall.Name = "textBoxRightWall";
            this.textBoxRightWall.Size = new System.Drawing.Size(313, 22);
            this.textBoxRightWall.TabIndex = 8;
            this.textBoxRightWall.Text = "rightWall";
            // 
            // textBoxLeftWall
            // 
            this.textBoxLeftWall.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxLeftWall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLeftWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLeftWall.ForeColor = System.Drawing.Color.Red;
            this.textBoxLeftWall.Location = new System.Drawing.Point(6, 215);
            this.textBoxLeftWall.Name = "textBoxLeftWall";
            this.textBoxLeftWall.Size = new System.Drawing.Size(313, 22);
            this.textBoxLeftWall.TabIndex = 9;
            this.textBoxLeftWall.Text = "leftWall";
            // 
            // textBoxLastWallTouched
            // 
            this.textBoxLastWallTouched.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxLastWallTouched.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastWallTouched.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastWallTouched.ForeColor = System.Drawing.Color.Red;
            this.textBoxLastWallTouched.Location = new System.Drawing.Point(6, 187);
            this.textBoxLastWallTouched.Name = "textBoxLastWallTouched";
            this.textBoxLastWallTouched.Size = new System.Drawing.Size(313, 22);
            this.textBoxLastWallTouched.TabIndex = 10;
            this.textBoxLastWallTouched.Text = "lastWallTouched";
            // 
            // textBoxNumOfWallsHit
            // 
            this.textBoxNumOfWallsHit.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxNumOfWallsHit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumOfWallsHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumOfWallsHit.ForeColor = System.Drawing.Color.Red;
            this.textBoxNumOfWallsHit.Location = new System.Drawing.Point(6, 327);
            this.textBoxNumOfWallsHit.Name = "textBoxNumOfWallsHit";
            this.textBoxNumOfWallsHit.Size = new System.Drawing.Size(313, 22);
            this.textBoxNumOfWallsHit.TabIndex = 11;
            this.textBoxNumOfWallsHit.Text = "numofHitsOnWall";
            // 
            // mainLoop
            // 
            this.mainLoop.Tick += new System.EventHandler(this.mainLoop_Tick);
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(349, 386);
            this.Controls.Add(this.groupBox1);
            this.Name = "DebugWindow";
            this.Load += new System.EventHandler(this.Debug_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPosX;
        private System.Windows.Forms.TextBox textBoxRightWall;
        private System.Windows.Forms.TextBox textBoxBottomWall;
        private System.Windows.Forms.TextBox textBoxTopWall;
        private System.Windows.Forms.TextBox textBoxBallRad;
        private System.Windows.Forms.TextBox textBoxBallSpeedY;
        private System.Windows.Forms.TextBox textBoxBallSpeedX;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxPosY;
        private System.Windows.Forms.TextBox textBoxLastWallTouched;
        private System.Windows.Forms.TextBox textBoxLeftWall;
        private System.Windows.Forms.TextBox textBoxNumOfWallsHit;
        private System.Windows.Forms.Timer mainLoop;
    }
}