namespace Ball_Breaker.Forms
{
    partial class MainGame
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
            this.mainTick = new System.Windows.Forms.Timer(this.components);
            this.resetTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // mainTick
            // 
            this.mainTick.Interval = 1;
            this.mainTick.Tick += new System.EventHandler(this.mainTick_Tick);
            // 
            // resetTick
            // 
            this.resetTick.Interval = 500;
            this.resetTick.Tick += new System.EventHandler(this.resetTick_Tick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer mainTick;
        private System.Windows.Forms.Timer resetTick;
    }
}