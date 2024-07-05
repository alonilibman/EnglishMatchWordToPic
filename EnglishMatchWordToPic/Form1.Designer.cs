using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace EnglishMatchWordToPic
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        private Dictionary<Button, int> buttonGlowIntensity = new Dictionary<Button, int>();
        private Dictionary<Button, (float, float)> buttonAnimationState = new Dictionary<Button, (float, float)>();


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.QuestionNum = new System.Windows.Forms.Label();
            this.WelcomeTxt = new System.Windows.Forms.RichTextBox();
            this.WelcomeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(471, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 405);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(471, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 68);
            this.button1.TabIndex = 11;
            this.button1.Tag = "1";
            this.button1.Text = "Option 1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(813, 626);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 68);
            this.button2.TabIndex = 10;
            this.button2.Tag = "2";
            this.button2.Text = "Option 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            this.button2.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Violet;
            this.button3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(471, 716);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 67);
            this.button3.TabIndex = 9;
            this.button3.Tag = "3";
            this.button3.Text = "Option 3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            this.button3.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button4.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(813, 715);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 68);
            this.button4.TabIndex = 8;
            this.button4.Tag = "4";
            this.button4.Text = "Option 4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            this.button4.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(471, 527);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuestion.Size = new System.Drawing.Size(579, 69);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "אֵיזוֹ חַיָּה מוֹפִיעָה בַּתְּמוּנָה ?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(471, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(579, 69);
            this.label2.TabIndex = 7;
            this.label2.Text = "חִידוֹן חַיּוֹת בְּשָׂפָה הָאַנְגְּלִית";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ExitButton.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(646, 851);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(238, 67);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Tag = "3";
            this.ExitButton.Text = "יציאה";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            // 
            // QuestionNum
            // 
            this.QuestionNum.BackColor = System.Drawing.Color.Transparent;
            this.QuestionNum.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNum.ForeColor = System.Drawing.Color.Black;
            this.QuestionNum.Location = new System.Drawing.Point(471, 799);
            this.QuestionNum.Name = "QuestionNum";
            this.QuestionNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QuestionNum.Size = new System.Drawing.Size(580, 49);
            this.QuestionNum.TabIndex = 13;
            this.QuestionNum.Text = "Question number";
            this.QuestionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuestionNum.Visible = false;
            // 
            // WelcomeTxt
            // 
            this.WelcomeTxt.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.WelcomeTxt.ForeColor = System.Drawing.Color.Black;
            this.WelcomeTxt.Location = new System.Drawing.Point(205, 267);
            this.WelcomeTxt.Name = "WelcomeTxt";
            this.WelcomeTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WelcomeTxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.WelcomeTxt.Size = new System.Drawing.Size(1019, 210);
            this.WelcomeTxt.TabIndex = 14;
            this.WelcomeTxt.Text = resources.GetString("WelcomeTxt.Text");
            // 
            // WelcomeBtn
            // 
            this.WelcomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WelcomeBtn.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBtn.Location = new System.Drawing.Point(616, 528);
            this.WelcomeBtn.Name = "WelcomeBtn";
            this.WelcomeBtn.Size = new System.Drawing.Size(238, 68);
            this.WelcomeBtn.TabIndex = 15;
            this.WelcomeBtn.Tag = "1";
            this.WelcomeBtn.Text = "בּוֹאוּ נַתְחִיל";
            this.WelcomeBtn.UseVisualStyleBackColor = false;
            this.WelcomeBtn.Click += new System.EventHandler(this.ShowGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1532, 930);
            this.Controls.Add(this.WelcomeBtn);
            this.Controls.Add(this.WelcomeTxt);
            this.Controls.Add(this.QuestionNum);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "חִידוֹן חַיּוֹת בְּשָׂפָה הָאַנְגְּלִית";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label2;


        protected override void OnPaint(PaintEventArgs e) // removed white edges on buttons
        {
            base.OnPaint(e);
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        path.AddArc(0, 0, 20, 20, 180, 90);
                        path.AddArc(btn.Width - 20, 0, 20, 20, 270, 90);
                        path.AddArc(btn.Width - 20, btn.Height - 20, 20, 20, 0, 90);
                        path.AddArc(0, btn.Height - 20, 20, 20, 90, 90);
                        btn.Region = new Region(path);
                    }
                }
            }
        }
        private void Button_Paint(object sender, PaintEventArgs e) // buttons style
        {
            Button btn = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, 20, 20, 180, 90);
                path.AddArc(btn.Width - 20, 0, 20, 20, 270, 90);
                path.AddArc(btn.Width - 20, btn.Height - 20, 20, 20, 0, 90);
                path.AddArc(0, btn.Height - 20, 20, 20, 90, 90);

                // Draw the button background
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    g.FillPath(brush, path);
                }

                // Draw glow effect if the mouse is over the button
                if (btn.ClientRectangle.Contains(btn.PointToClient(Control.MousePosition)))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        using (Pen pen = new Pen(Color.FromArgb(20 - i * 2, Color.White), 2 + i))
                        {
                            g.DrawPath(pen, path);
                        }
                    }
                }

                // Draw the text
                TextRenderer.DrawText(g, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private Button ExitButton;
        private Label QuestionNum;
        private RichTextBox WelcomeTxt;
        private Button WelcomeBtn;
    }


    partial class CongratulationsForm // the message after the kid finishes the quiz
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCongrats = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCongrats
            // 
            this.lblCongrats.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCongrats.Location = new System.Drawing.Point(12, 9);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(300, 100);
            this.lblCongrats.TabIndex = 0;
            this.lblCongrats.Text = "כָּל הַכָּבוֹד! הִרְוַחְתָּ {score} נְקוּדוֹת";
            this.lblCongrats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(97, 130);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(125, 40);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "?נְשַׂחֵק שׁוּב";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);

            // 
            // CongratulationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 182);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblCongrats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CongratulationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Congratulations!";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Button btnPlayAgain;
    }


}
