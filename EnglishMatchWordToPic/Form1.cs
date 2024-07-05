using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishMatchWordToPic
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();         
            askQuestion(questionNumber);
            totalQuestions = 15;
            UpdateQuestionNumber();
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if ((buttonTag==correctAnswer))
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                using (CongratulationsForm congratsForm = new CongratulationsForm(score))
                {
                    if (congratsForm.ShowDialog() == DialogResult.OK)
                    {
                        score = 0;
                        questionNumber = 0; // Adjust to start from the first question again
                        askQuestion(questionNumber);
                    }
                }
            }



            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            UpdateQuestionNumber();
            switch (qnum) // question number
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.bat;
                    button1.Text = "Dog";
                    button2.Text = "Fish";
                    button3.Text = "Shark";
                    button4.Text = "Bat";
                    correctAnswer = 4;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.bee;
                    button1.Text = "Frog";
                    button2.Text = "Koala";
                    button3.Text = "Bee";
                    button4.Text = "Tiger";
                    correctAnswer = 3;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.bird;
                    button1.Text = "Bird";
                    button2.Text = "Monkey";
                    button3.Text = "Cat";
                    button4.Text = "Dolphin";
                    correctAnswer = 1;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.cat;
                    button1.Text = "Owl";
                    button2.Text = "Zebra";
                    button3.Text = "Shark";
                    button4.Text = "Cat";
                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.crab;
                    button1.Text = "Penguin";
                    button2.Text = "Crab";
                    button3.Text = "Bird";
                    button4.Text = "Lion";
                    correctAnswer = 2;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.dog;
                    button1.Text = "Dog";
                    button2.Text = "Giraffe";
                    button3.Text = "Lizard";
                    button4.Text = "Frog";
                    correctAnswer = 1;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.duck;
                    button1.Text = "Cat";
                    button2.Text = "Snake";
                    button3.Text = "Duck";
                    button4.Text = "Bat";
                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.fish;
                    button1.Text = "Crocodile";
                    button2.Text = "Fish";
                    button3.Text = "Shark";
                    button4.Text = "Cheetah";
                    correctAnswer = 2;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.frog;
                    button1.Text = "Elephant";
                    button2.Text = "Whale";
                    button3.Text = "Ant";
                    button4.Text = "Frog";
                    correctAnswer = 4;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.horse;
                    button1.Text = "Horse";
                    button2.Text = "Rhino";
                    button3.Text = "Bee";
                    button4.Text = "Panther";
                    correctAnswer = 1;

                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.mouse;
                    button1.Text = "Mouse";
                    button2.Text = "Pig";
                    button3.Text = "Lizard";
                    button4.Text = "Dog";
                    correctAnswer = 1;

                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.panda;
                    button1.Text = "Kangaroo";
                    button2.Text = "Octopus";
                    button3.Text = "Panda";
                    button4.Text = "Bat";
                    correctAnswer = 3;

                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.snake;
                    button1.Text = "Leopard";
                    button2.Text = "Snake";
                    button3.Text = "Whale";
                    button4.Text = "Deer";
                    correctAnswer = 2;

                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.tiger;
                    button1.Text = "Koala";
                    button2.Text = "Fish";
                    button3.Text = "Gorilla";
                    button4.Text = "Tiger";
                    correctAnswer = 4;

                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.zebra;
                    button1.Text = "Zebra";
                    button2.Text = "Bear";
                    button3.Text = "Parrot";
                    button4.Text = "Monkey";
                    correctAnswer = 1;

                    break;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

            Application.Exit();           
        }

        private void UpdateQuestionNumber()
        {
            QuestionNum.Text = "שְׁאֵלָה מְסַפֵּר " + (questionNumber) + " מִתּוֹךְ " + (totalQuestions);
        }

        private void ShowGame(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            lblQuestion.Visible = true;
            label2.Visible = true;
            ExitButton.Visible = true;
            QuestionNum.Visible = true;
            WelcomeTxt.Visible = false;
            WelcomeBtn.Visible = false;
        }
    }

    public partial class CongratulationsForm : Form // the message user gets when finishes to play
    {
        private int score;

        public CongratulationsForm(int score)
        {
            InitializeComponent();
            this.score = score;
            lblCongrats.Text = $"כָּל הַכָּבוֹד! הִרְוַחְתָּ {score} נְקוּדוֹת";
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }


}
