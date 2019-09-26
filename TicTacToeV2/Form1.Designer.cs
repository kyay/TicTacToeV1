
namespace TicTacToeV1
{
    partial class frmTicTacToe
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
            this.tmrPlayerTimeCounter = new System.Windows.Forms.Timer(this.components);
            this.tmrFader = new System.Windows.Forms.Timer(this.components);
            this.lblOScore = new System.Windows.Forms.Label();
            this.lblXScore = new System.Windows.Forms.Label();
            this.lblTile9 = new TicTacToeV1.FadingLabel();
            this.lblTile8 = new TicTacToeV1.FadingLabel();
            this.lblTile7 = new TicTacToeV1.FadingLabel();
            this.lblTile6 = new TicTacToeV1.FadingLabel();
            this.lblTile5 = new TicTacToeV1.FadingLabel();
            this.lblTile4 = new TicTacToeV1.FadingLabel();
            this.lblTile3 = new TicTacToeV1.FadingLabel();
            this.lblTile2 = new TicTacToeV1.FadingLabel();
            this.lblTile1 = new TicTacToeV1.FadingLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTile9);
            this.groupBox1.Controls.Add(this.lblTile8);
            this.groupBox1.Controls.Add(this.lblTile7);
            this.groupBox1.Controls.Add(this.lblTile6);
            this.groupBox1.Controls.Add(this.lblTile5);
            this.groupBox1.Controls.Add(this.lblTile4);
            this.groupBox1.Controls.Add(this.lblTile3);
            this.groupBox1.Controls.Add(this.lblTile2);
            this.groupBox1.Controls.Add(this.lblTile1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tmrPlayerTimeCounter
            // 
            this.tmrPlayerTimeCounter.Enabled = true;
            this.tmrPlayerTimeCounter.Interval = 1000;
            this.tmrPlayerTimeCounter.Tick += new System.EventHandler(this.trmPlayerTimeCounter_Tick);
            // 
            // tmrFader
            // 
            this.tmrFader.Enabled = true;
            this.tmrFader.Interval = 16;
            this.tmrFader.Tick += new System.EventHandler(this.tmrFader_Tick);
            // 
            // lblOScore
            // 
            this.lblOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.lblOScore.Location = new System.Drawing.Point(198, 133);
            this.lblOScore.Name = "lblOScore";
            this.lblOScore.Size = new System.Drawing.Size(305, 45);
            this.lblOScore.TabIndex = 2;
            this.lblOScore.Text = "Test: 99";
            // 
            // lblXScore
            // 
            this.lblXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.lblXScore.Location = new System.Drawing.Point(198, 23);
            this.lblXScore.Name = "lblXScore";
            this.lblXScore.Size = new System.Drawing.Size(305, 45);
            this.lblXScore.TabIndex = 1;
            this.lblXScore.Text = "Test: 99";
            // 
            // lblTile9
            // 
            this.lblTile9.Alpha = 0;
            this.lblTile9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile9.FadeSpeed = 42;
            this.lblTile9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile9.Location = new System.Drawing.Point(125, 125);
            this.lblTile9.Name = "lblTile9";
            this.lblTile9.Size = new System.Drawing.Size(50, 45);
            this.lblTile9.TabIndex = 8;
            this.lblTile9.Text = "X";
            this.lblTile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile9.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // lblTile8
            // 
            this.lblTile8.Alpha = 0;
            this.lblTile8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile8.FadeSpeed = 42;
            this.lblTile8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile8.Location = new System.Drawing.Point(65, 125);
            this.lblTile8.Name = "lblTile8";
            this.lblTile8.Size = new System.Drawing.Size(50, 45);
            this.lblTile8.TabIndex = 7;
            this.lblTile8.Text = "X";
            this.lblTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile8.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // lblTile7
            // 
            this.lblTile7.Alpha = 0;
            this.lblTile7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile7.FadeSpeed = 42;
            this.lblTile7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile7.Location = new System.Drawing.Point(5, 125);
            this.lblTile7.Name = "lblTile7";
            this.lblTile7.Size = new System.Drawing.Size(50, 45);
            this.lblTile7.TabIndex = 6;
            this.lblTile7.Text = "X";
            this.lblTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile7.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // lblTile6
            // 
            this.lblTile6.Alpha = 0;
            this.lblTile6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile6.FadeSpeed = 42;
            this.lblTile6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile6.Location = new System.Drawing.Point(125, 70);
            this.lblTile6.Name = "lblTile6";
            this.lblTile6.Size = new System.Drawing.Size(50, 45);
            this.lblTile6.TabIndex = 5;
            this.lblTile6.Text = "X";
            this.lblTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile6.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // lblTile5
            // 
            this.lblTile5.Alpha = 0;
            this.lblTile5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile5.FadeSpeed = 42;
            this.lblTile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile5.Location = new System.Drawing.Point(65, 70);
            this.lblTile5.Name = "lblTile5";
            this.lblTile5.Size = new System.Drawing.Size(50, 45);
            this.lblTile5.TabIndex = 4;
            this.lblTile5.Text = "X";
            this.lblTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile5.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // lblTile4
            // 
            this.lblTile4.Alpha = 0;
            this.lblTile4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile4.FadeSpeed = 42;
            this.lblTile4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile4.Location = new System.Drawing.Point(5, 70);
            this.lblTile4.Name = "lblTile4";
            this.lblTile4.Size = new System.Drawing.Size(50, 45);
            this.lblTile4.TabIndex = 3;
            this.lblTile4.Text = "X";
            this.lblTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile4.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // lblTile3
            // 
            this.lblTile3.Alpha = 0;
            this.lblTile3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile3.FadeSpeed = 42;
            this.lblTile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile3.Location = new System.Drawing.Point(125, 15);
            this.lblTile3.Name = "lblTile3";
            this.lblTile3.Size = new System.Drawing.Size(50, 45);
            this.lblTile3.TabIndex = 2;
            this.lblTile3.Text = "X";
            this.lblTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile3.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // lblTile2
            // 
            this.lblTile2.Alpha = 0;
            this.lblTile2.BackColor = System.Drawing.SystemColors.Control;
            this.lblTile2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile2.FadeSpeed = 42;
            this.lblTile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile2.Location = new System.Drawing.Point(65, 15);
            this.lblTile2.Name = "lblTile2";
            this.lblTile2.Size = new System.Drawing.Size(50, 45);
            this.lblTile2.TabIndex = 1;
            this.lblTile2.Text = "X";
            this.lblTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile2.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // lblTile1
            // 
            this.lblTile1.Alpha = 0;
            this.lblTile1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTile1.FadeSpeed = 42;
            this.lblTile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTile1.Location = new System.Drawing.Point(5, 15);
            this.lblTile1.Name = "lblTile1";
            this.lblTile1.Size = new System.Drawing.Size(50, 45);
            this.lblTile1.TabIndex = 0;
            this.lblTile1.Text = "X";
            this.lblTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTile1.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 209);
            this.Controls.Add(this.lblOScore);
            this.Controls.Add(this.lblXScore);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTicTacToe";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.frmTicTacToe_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private FadingLabel lblTile6;
        private FadingLabel lblTile5;
        private FadingLabel lblTile4;
        private FadingLabel lblTile3;
        private FadingLabel lblTile2;
        private FadingLabel lblTile1;
        private FadingLabel lblTile9;
        private FadingLabel lblTile8;
        private FadingLabel lblTile7;
        private System.Windows.Forms.Label lblXScore;
        private System.Windows.Forms.Label lblOScore;
        private System.Windows.Forms.Timer tmrPlayerTimeCounter;
        private System.Windows.Forms.Timer tmrFader;
    }
}

