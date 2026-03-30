using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Lab1txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAssign1.Clear();
            txtAssign2.Clear();
            txtSW1.Clear();
            txtSW2.Clear();
            txtrecite.Clear();
            txtlab1.Clear();
            txtlab2.Clear();
            txtlab3.Clear();
            txtlab4.Clear();
            txtQ1.Clear();
            txtQ2.Clear();
            txtlabexam1.Clear();
            txtLabexam2.Clear();
            txtPrelimexam.Clear();
            txtmidassign1.Clear();
            txtmidassign2.Clear();
            txtmidSW1.Clear();
            txtmidSW2.Clear();
            txtmidrecite.Clear();
            txtmidlab1.Clear();
            txtmidlab2.Clear();
            txtmidlab3.Clear();
            txtmidlab4.Clear();
            txtmidQ1.Clear();
            txtmidQ2.Clear();
            txtmidQ3.Clear();
            txtmidlabexam1.Clear();
            txtmidlabexam2.Clear();
            txtmidexam.Clear();
            txtFassign1.Clear();
            txtFassign2.Clear();
            txtFSW1.Clear();
            txtFSW2.Clear();
            txtFrecite.Clear();
            txtFlab1.Clear();
            txtFlab2.Clear();
            txtFlab3.Clear();
            txtFlab4.Clear();
            txtFinalQ1.Clear();
            txtFinalQ2.Clear();
            txtFinalQ3.Clear();
            txtFlabexam1.Clear();
            txtFlabexam2.Clear();
            txtFinalexam.Clear();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Are you sure you want to exit?",
       "Exit",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Assign1, Assign2, SW1, SW2, recite, recite2, lab1, lab2, lab3, lab4, Q1, Q2,Q3, labexam1, labexam2, Prelimexam;
            double midassign1, midassign2, midSW1, midSW2, midrecite, midrecite2, midlab1, midlab2, midlab3, midlab4, midQ1, midQ2, midQ3, midlabexam1, midlabexam2, midexam;
            double Fassign1, Fassign2, FSW1, FSW2, Frecite, Frecite2, Flab1, Flab2, Flab3, Flab4, FinalQ1, FinalQ2, FinalQ3, Flabexam1, Flabexam2, Finalexam;

            double.TryParse(txtAssign1.Text, out Assign1);
            double.TryParse(txtAssign2.Text, out Assign2);
            double.TryParse(txtSW1.Text, out SW1);
            double.TryParse(txtSW2.Text, out SW2);
            double.TryParse(txtrecite.Text, out recite);
            double.TryParse(txtrecite2.Text, out recite2);
            double.TryParse(txtlab1.Text, out lab1);
            double.TryParse(txtlab2.Text, out lab2);
            double.TryParse(txtlab3.Text, out lab3);
            double.TryParse(txtlab4.Text, out lab4);

            
            double.TryParse(txtQ1.Text, out Q1);
            double.TryParse(txtQ2.Text, out Q2);
            double.TryParse(txtQ3.Text, out Q3);

           
            double.TryParse(txtlabexam1.Text, out labexam1);
            double.TryParse(txtLabexam2.Text, out labexam2);

            double exam = 0;
            double.TryParse(txtPrelimexam.Text, out exam);

            double cpPrelim = (Assign1 + Assign2 + SW1 + SW2 + recite + recite2) / 6 * 0.10;
            double labPrelim = (lab1 + lab2 + lab3 + lab4) / 4 * 0.10;
            double quizPrelim = (Q1 + Q2 + Q3) / 3 * 0.20;
            double labExamPrelim = (labexam1 + labexam2) / 2 * 0.20;
            double writtenExamPrelim = exam * 0.40;
            double prelimGrade = cpPrelim + labPrelim + quizPrelim + labExamPrelim + writtenExamPrelim;

            double.TryParse(txtmidassign1.Text, out midassign1);
            double.TryParse(txtmidassign2.Text, out midassign2);
            double.TryParse(txtmidSW1.Text, out midSW1);
            double.TryParse(txtmidSW2.Text, out midSW2);
            double.TryParse(txtmidrecite.Text, out midrecite);
            double.TryParse(txtmidrecite2.Text, out midrecite2);

            double.TryParse(txtmidlab1.Text, out midlab1);
            double.TryParse(txtmidlab2.Text, out midlab2);
            double.TryParse(txtmidlab3.Text, out midlab3);
            double.TryParse(txtmidlab4.Text, out midlab4);
            double.TryParse(txtmidQ1.Text, out midQ1);
            double.TryParse(txtmidQ2.Text, out midQ2);
            double.TryParse(txtmidQ3.Text, out midQ3);

            double.TryParse(txtmidlabexam1.Text, out midlabexam1);
            double.TryParse(txtmidlabexam2.Text, out midlabexam2);

            double.TryParse(txtmidexam.Text, out midexam);

            double cpMid = (midassign1 + midassign2 + midSW1 + midSW2 + midrecite + midrecite2) / 6 * 0.10;
            double labMid = (midlab1 + midlab2 + midlab3 + midlab4) / 4 * 0.10;
            double quizMid = (midQ1 + midQ2 + midQ3) / 3 * 0.20;
            double labExamMid = (midlabexam1 + midlabexam2) / 2 * 0.20;
            double writtenExamMid = midexam * 0.40;
            double midtermGrade = cpMid + labMid + quizMid + labExamMid + writtenExamMid;

            double.TryParse(txtFassign1.Text, out Fassign1);
            double.TryParse(txtFassign2.Text, out Fassign2);
            double.TryParse(txtFSW1.Text, out FSW1);
            double.TryParse(txtFSW2.Text, out FSW2);
            double.TryParse(txtFrecite.Text, out Frecite);
            double.TryParse(txtFrecite2.Text, out Frecite2);
            double.TryParse(txtFlab1.Text, out Flab1);
            double.TryParse(txtFlab2.Text, out Flab2);
            double.TryParse(txtFlab3.Text, out Flab3);
            double.TryParse(txtFlab4.Text, out Flab4);
            double.TryParse(txtFinalQ1.Text, out FinalQ1);
            double.TryParse(txtFinalQ2.Text, out FinalQ2);
            double.TryParse(txtFinalQ3.Text, out FinalQ3);
            double.TryParse(txtFlabexam1.Text, out Flabexam1);
            double.TryParse(txtFlabexam2.Text, out Flabexam2);
            double.TryParse(txtFinalexam.Text, out Finalexam);

            double cpFinal = (Fassign1 + Fassign2 + FSW1 + FSW2 +Frecite + Frecite2 ) / 6 * 0.10;
            double labFinal = (Flab1 + Flab2 + Flab3 + Flab4) / 4 * 0.10;
            double quizFinal = (FinalQ1 + FinalQ2 + FinalQ3) / 3 * 0.20;
            double labExamFinal = (Flabexam1 + Flabexam2) / 2 * 0.20;
            double writtenExamFinal = Finalexam * 0.40;
            double finalExamGrade = cpFinal + labFinal + quizFinal + labExamFinal + writtenExamFinal;

            double finalGrade = (prelimGrade * 0.33) + (midtermGrade * 0.33) + (finalExamGrade * 0.33);


            // ===== SHOW IN MESSAGEBOX =====
            string message = $"Prelim Grade: {prelimGrade:0.00}\n" +
                    $"Midterm Grade: {midtermGrade:0.00}\n" +
                    $"Final Grade: {finalExamGrade:0.00}\n" +
                    $"Final Computed Grade: {finalGrade:0.00}";

            MessageBox.Show(message, "Grades");




        }

        private void Flabexam2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmidSW1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
