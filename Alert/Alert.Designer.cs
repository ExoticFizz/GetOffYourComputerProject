using System.Diagnostics;
namespace Alert
    {
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.timMain = new System.Windows.Forms.Timer(this.components);
            this.niTrayMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblGetOfIn = new System.Windows.Forms.Label();
            this.lblGetOffTime = new System.Windows.Forms.Label();
            this.lblGetOnTime = new System.Windows.Forms.Label();
            this.lblGetBackOnIn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // niTrayMain
            // 
            this.niTrayMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niTrayMain.Icon")));
            this.niTrayMain.Text = "Get Of Your Computer";
            this.niTrayMain.Visible = true;
            this.niTrayMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.niTrayMain_MouseClick);
            // 
            // lblGetOfIn
            // 
            this.lblGetOfIn.AutoSize = true;
            this.lblGetOfIn.ForeColor = System.Drawing.Color.White;
            this.lblGetOfIn.Location = new System.Drawing.Point(13, 13);
            this.lblGetOfIn.Name = "lblGetOfIn";
            this.lblGetOfIn.Size = new System.Drawing.Size(86, 13);
            this.lblGetOfIn.TabIndex = 0;
            this.lblGetOfIn.Text = "Time To Get Off:";
            // 
            // lblGetOffTime
            // 
            this.lblGetOffTime.AutoSize = true;
            this.lblGetOffTime.ForeColor = System.Drawing.Color.White;
            this.lblGetOffTime.Location = new System.Drawing.Point(106, 13);
            this.lblGetOffTime.Name = "lblGetOffTime";
            this.lblGetOffTime.Size = new System.Drawing.Size(52, 13);
            this.lblGetOffTime.TabIndex = 1;
            this.lblGetOffTime.Text = "Initializing";
            // 
            // lblGetOnTime
            // 
            this.lblGetOnTime.AutoSize = true;
            this.lblGetOnTime.ForeColor = System.Drawing.Color.White;
            this.lblGetOnTime.Location = new System.Drawing.Point(133, 41);
            this.lblGetOnTime.Name = "lblGetOnTime";
            this.lblGetOnTime.Size = new System.Drawing.Size(52, 13);
            this.lblGetOnTime.TabIndex = 3;
            this.lblGetOnTime.Text = "Initializing";
            // 
            // lblGetBackOnIn
            // 
            this.lblGetBackOnIn.AutoSize = true;
            this.lblGetBackOnIn.ForeColor = System.Drawing.Color.White;
            this.lblGetBackOnIn.Location = new System.Drawing.Point(13, 41);
            this.lblGetBackOnIn.Name = "lblGetBackOnIn";
            this.lblGetBackOnIn.Size = new System.Drawing.Size(114, 13);
            this.lblGetBackOnIn.TabIndex = 2;
            this.lblGetBackOnIn.Text = "Time To Get Back On:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 63);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(374, 63);
            this.Controls.Add(this.lblGetOnTime);
            this.Controls.Add(this.lblGetBackOnIn);
            this.Controls.Add(this.lblGetOffTime);
            this.Controls.Add(this.lblGetOfIn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alert_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Alert_FormClosed);
            this.Load += new System.EventHandler(this.Alert_Load);
            this.Shown += new System.EventHandler(this.Alert_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Alert_MouseDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Alert_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Alert_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Alert_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Timer timMain;
        private System.Windows.Forms.NotifyIcon niTrayMain;
        private System.Windows.Forms.Label lblGetOfIn;
        private System.Windows.Forms.Label lblGetOffTime;
        private System.Windows.Forms.Label lblGetOnTime;
        private System.Windows.Forms.Label lblGetBackOnIn;
        private System.Windows.Forms.Panel panel1;


        }
    }

