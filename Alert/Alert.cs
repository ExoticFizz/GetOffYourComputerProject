using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Xml;
using System.IO;

namespace Alert
    {
    public partial class Alert : Form
        {
        private Boolean jStart = new Boolean();
        public Stopwatch s = new Stopwatch();
        public Alert()
            {
            if (File.Exists(@"C:\Users\Public\file.txt"))
                {
                jStart = true;
                // int.Parse(File.ReadAllText(@"C:\Users\Public\file.txt"));
                string timeFrom = File.ReadAllText(@"C:\Users\Public\file.txt");

                try
                    {
                    s.Elapsed.Add(TimeSpan.FromTicks(long.Parse(timeFrom)));
                    }
                catch (FormatException e)
                    {
                    MessageBox.Show("File Is Corrupt:\n" + e.Source + "\n" + e.StackTrace +"\n" + e.Message + "\n" + "Program will recreate the file.","",MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                    }

                
                }
            else
                {
                MessageBox.Show("Hello");
                }
            InitializeComponent();

            }

        
        public bool dragging = false;
        public Point dragCursorPoint;
        public Point dragFormPoint;

        public void Alert_MouseDown(object sender, MouseEventArgs e)
            {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            }

        public void Alert_MouseMove(object sender, MouseEventArgs e)
            {
            if (dragging)
                {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
                }
            }

        public void Alert_MouseUp(object sender, MouseEventArgs e)
            {
            dragging = false;
            }


        public void Alert_Load(object sender, EventArgs e)
            {
            
            }

        public void thread2()
            {
            while (true)
                {
                this.TopMost = true;
                Thread.Sleep(10);
                }
            }

        public void Alert_Shown(object sender, EventArgs e)
            {
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(thread2);
            this.TopMost = true;
            t1.Start();
            //t2.Start();
            }
     
        public void Thread1()
            {
            
            while (s.ElapsedMilliseconds <= 540000)
                {
                if (this.Visible)
                    {

                    }
                jStart = false;
                s.Start();
                TimeSpan ts = s.Elapsed;
                DirectoryInfo d = new DirectoryInfo(@"C:\Users\Public");
                d.GetAccessControl();

                File.WriteAllText(Path.Combine(d.FullName, "file.txt"), ts.Ticks.ToString());

                SetText(String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10));
                Thread.Sleep(1000); 
                }
            //Takes 1 millisecond to do s.Stop();
            s.Stop();
            }















        delegate void SetTextCallback(string text);

        public void SetText(string text)
            {
            if (this.lblGetOffTime.InvokeRequired && jStart == false)
                {

                SetTextCallback d = new SetTextCallback(SetText);
            this.Invoke(d, new object[] { text });
                }
            else
                {
                this.lblGetOffTime.Text = text;
                }
            }

        public void Alert_FormClosed(object sender, FormClosedEventArgs e)
            {
            
            }

        public void Alert_FormClosing(object sender, FormClosingEventArgs e)
            {
            e.Cancel = true;
            }
        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            }









        public void panel1_MouseDown(object sender, MouseEventArgs e)
            {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            }

        public void panel1_MouseMove(object sender, MouseEventArgs e)
            {
            if (dragging)
                {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
                }
            }

        public void panel1_MouseUp(object sender, MouseEventArgs e)
            {
            dragging = false;
            }

        private void niTrayMain_MouseClick(object sender, MouseEventArgs e)
            {
            if (this.Visible)
                {
                this.Hide();
                }
            else if(!this.Visible)
                {
                this.Show();
                }
            }

        







        }
    }
