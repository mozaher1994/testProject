﻿namespace ShutDownRestartLockLogOff
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
            this.shutdownBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.logOffBtn = new System.Windows.Forms.Button();
            this.lockBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shutdownBtn
            // 
            this.shutdownBtn.Location = new System.Drawing.Point(172, 176);
            this.shutdownBtn.Name = "shutdownBtn";
            this.shutdownBtn.Size = new System.Drawing.Size(113, 23);
            this.shutdownBtn.TabIndex = 0;
            this.shutdownBtn.Text = "Count Down";
            this.shutdownBtn.UseVisualStyleBackColor = true;
            this.shutdownBtn.Click += new System.EventHandler(this.shutdownBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(331, 51);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(113, 23);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // logOffBtn
            // 
            this.logOffBtn.Location = new System.Drawing.Point(331, 103);
            this.logOffBtn.Name = "logOffBtn";
            this.logOffBtn.Size = new System.Drawing.Size(113, 23);
            this.logOffBtn.TabIndex = 2;
            this.logOffBtn.Text = "Log off";
            this.logOffBtn.UseVisualStyleBackColor = true;
            this.logOffBtn.Visible = false;
            this.logOffBtn.Click += new System.EventHandler(this.logOffBtn_Click);
            // 
            // lockBtn
            // 
            this.lockBtn.Location = new System.Drawing.Point(331, 159);
            this.lockBtn.Name = "lockBtn";
            this.lockBtn.Size = new System.Drawing.Size(113, 23);
            this.lockBtn.TabIndex = 3;
            this.lockBtn.Text = "Lock";
            this.lockBtn.UseVisualStyleBackColor = true;
            this.lockBtn.Visible = false;
            this.lockBtn.Click += new System.EventHandler(this.lockBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 292);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lockBtn);
            this.Controls.Add(this.logOffBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.shutdownBtn);
            this.Name = "Form1";
            this.Text = "Shut Down";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shutdownBtn;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button logOffBtn;
        private System.Windows.Forms.Button lockBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

