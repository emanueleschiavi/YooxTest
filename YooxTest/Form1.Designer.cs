namespace YooxTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lblScore1 = new Label();
            lblScore2 = new Label();
            btnRandom = new Button();
            btnPoint1 = new Button();
            btnPoint2 = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "Player 1 Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(603, 9);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Player 2 Score";
            // 
            // lblScore1
            // 
            lblScore1.AutoSize = true;
            lblScore1.Location = new Point(15, 36);
            lblScore1.Name = "lblScore1";
            lblScore1.Size = new Size(0, 15);
            lblScore1.TabIndex = 1;
            // 
            // lblScore2
            // 
            lblScore2.AutoSize = true;
            lblScore2.Location = new Point(603, 36);
            lblScore2.Name = "lblScore2";
            lblScore2.Size = new Size(0, 15);
            lblScore2.TabIndex = 1;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(285, 25);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(75, 23);
            btnRandom.TabIndex = 2;
            btnRandom.Text = "Play";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // btnPoint1
            // 
            btnPoint1.Location = new Point(103, 11);
            btnPoint1.Name = "btnPoint1";
            btnPoint1.Size = new Size(75, 23);
            btnPoint1.TabIndex = 3;
            btnPoint1.Text = "Point";
            btnPoint1.UseVisualStyleBackColor = true;
            btnPoint1.Click += btnPoint1_Click;
            // 
            // btnPoint2
            // 
            btnPoint2.Location = new Point(522, 12);
            btnPoint2.Name = "btnPoint2";
            btnPoint2.Size = new Size(75, 23);
            btnPoint2.TabIndex = 3;
            btnPoint2.Text = "Point";
            btnPoint2.UseVisualStyleBackColor = true;
            btnPoint2.Click += btnPoint2_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(285, 54);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnPoint2);
            Controls.Add(btnPoint1);
            Controls.Add(btnRandom);
            Controls.Add(lblScore2);
            Controls.Add(lblScore1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblScore1;
        private Label lblScore2;
        private Button btnRandom;
        private Button btnPoint1;
        private Button btnPoint2;
        private Button btnReset;
    }
}