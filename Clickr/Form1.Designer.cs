namespace Clickr
{
    partial class Form1
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.clickerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLeftDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.StartCount = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.cpsResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clickerButton
            // 
            this.clickerButton.Location = new System.Drawing.Point(12, 114);
            this.clickerButton.Name = "clickerButton";
            this.clickerButton.Size = new System.Drawing.Size(588, 176);
            this.clickerButton.TabIndex = 0;
            this.clickerButton.Text = "Clicks";
            this.clickerButton.UseVisualStyleBackColor = true;
            this.clickerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer";
            // 
            // timeLeftDisplay
            // 
            this.timeLeftDisplay.AutoSize = true;
            this.timeLeftDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftDisplay.Location = new System.Drawing.Point(12, 34);
            this.timeLeftDisplay.Name = "timeLeftDisplay";
            this.timeLeftDisplay.Size = new System.Drawing.Size(53, 25);
            this.timeLeftDisplay.TabIndex = 2;
            this.timeLeftDisplay.Text = "10 s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Result";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartCount
            // 
            this.StartCount.Interval = 1000;
            this.StartCount.Tick += new System.EventHandler(this.StartCount_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cpsResult
            // 
            this.cpsResult.AutoSize = true;
            this.cpsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpsResult.Location = new System.Drawing.Point(12, 84);
            this.cpsResult.Name = "cpsResult";
            this.cpsResult.Size = new System.Drawing.Size(91, 25);
            this.cpsResult.TabIndex = 7;
            this.cpsResult.Text = "0.0 CPS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 302);
            this.Controls.Add(this.cpsResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeLeftDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clickerButton);
            this.Name = "Form1";
            this.Text = "a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clickerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLeftDisplay;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer StartCount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label cpsResult;
    }
}

