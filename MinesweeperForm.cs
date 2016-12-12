using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Minesweeper
{
    
    public class MinesweeperForm : Form
    {
        private Panel panel;
        private Game game;

        private Button startBtn;
        private Label minesLabel;
        private Label timeLabel;
 
        

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public MinesweeperForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.minesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(25, 51);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(225, 225);
            this.panel.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Blue;
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(84, 8);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(112, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "New Game!";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Blue;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(211, 8);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(50, 23);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "0";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minesLabel
            // 
            this.minesLabel.BackColor = System.Drawing.Color.Blue;
            this.minesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minesLabel.ForeColor = System.Drawing.Color.White;
            this.minesLabel.Location = new System.Drawing.Point(16, 8);
            this.minesLabel.Name = "minesLabel";
            this.minesLabel.Size = new System.Drawing.Size(50, 23);
            this.minesLabel.TabIndex = 3;
            this.minesLabel.Text = "15";
            this.minesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinesweeperForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(277, 300);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.minesLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.timeLabel);
            this.MaximizeBox = false;
            this.Name = "MinesweeperForm";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MinesweeperForm());
        }

        private void startBtn_Click(object sender, System.EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            game = new Game(this.panel, 9, 0);
             
            game.start();

        }
    }
}
