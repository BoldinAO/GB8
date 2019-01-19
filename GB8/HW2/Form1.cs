//Болдин
/*
Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompareAnswere;

namespace HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LbQuestion.Text = GetRandomQuestion.GetQuestion();
        }

        private void BtGiveAnswer_Click(object sender, EventArgs e)
        {
            //List<Questions> questions = new List<Questions>();
            //questions.Add(new Questions("1 вопрос", true));
            //questions.Add(new Questions("2 вопрос", false));
            //File.Serialize(questions);
            MessageBox.Show(Compare.Answers(TbAnswer.Text).ToString());
            LbQuestion.Text = GetRandomQuestion.GetQuestion();
        }
    }
}
