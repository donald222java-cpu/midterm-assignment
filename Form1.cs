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
            double Assign1, Assign2, SW1, SW2, recite, lab1, lab2, lab3, lab4, Q1, Q2, labexam1, Labexam2, Prelimexam;
            double midassign1, midassign2, midSW1, midSW2, midrecite, midlab1, midlab2, midlab3, midlab4, midQ1, midQ2, midQ3, midlabexam1, midlabexam2, midexam;
            double Fassign1, Fassign2, FSW1, FSW2, Frecite, Flab1, Flab2, Flab3, Flab4, FinalQ1, FinalQ2, FinalQ3, Flabexam1, Flabexam2, Finalexam;

            double a1, a2, s1, s2, Recite;

            double.TryParse(txtAssign1.Text, out a1);
            double.TryParse(txtAssign2.Text, out a2);
            double.TryParse(txtSW1.Text, out s1);
            double.TryParse(txtSW2.Text, out s2);
            double.TryParse(txtrecite.Text, out recite);

           

            double l1, l2, l3, l4, q1, q2,q3, le1, le2, pe;
            
            double.TryParse(txtlab1.Text, out lab1);
            double.TryParse(txtlab2.Text, out lab2);
            double.TryParse(txtlab3.Text, out lab3);
            double.TryParse(txtlab4.Text, out lab4);

            
            double.TryParse(txtQ1.Text, out q1);
            double.TryParse(txtQ2.Text, out q2);
            double.TryParse(txtQ3.Text, out q3);

           
            double.TryParse(txtlabexam1.Text, out le1);
            double.TryParse(txtLabexam2.Text, out le2);

            double exam = 0;
            double.TryParse(txtPrelimexam.Text, out exam);

            double cpPrelim = (a1 + a2 + s1 + s2 + recite) / 5 * 0.10;
            double labPrelim = (lab1 + lab2 + lab3 + lab4) / 4 * 0.10;
            double quizPrelim = (q1 + q2 + q3) / 3 * 0.20;
            double labExamPrelim = (le1 + le2) / 2 * 0.20;
            double writtenExamPrelim = exam * 0.40;
            double prelimGrade = cpPrelim + labPrelim + quizPrelim + labExamPrelim + writtenExamPrelim;

            double ma1 = 0, ma2 = 0, msw1 = 0, msw2 = 0, mrecite = 0;
            double.TryParse(txtmidassign1.Text, out ma1);
            double.TryParse(txtmidassign2.Text, out ma2);
            double.TryParse(txtmidSW1.Text, out msw1);
            double.TryParse(txtmidSW2.Text, out msw2);
            double.TryParse(txtmidrecite.Text, out mrecite);

            double mlab1 = 0, mlab2 = 0, mlab3 = 0, mlab4 = 0;
            double.TryParse(txtmidlab1.Text, out mlab1);
            double.TryParse(txtmidlab2.Text, out mlab2);
            double.TryParse(txtmidlab3.Text, out mlab3);
            double.TryParse(txtmidlab4.Text, out mlab4);

            double mq1 = 0, mq2 = 0, mq3 = 0;
            double.TryParse(txtmidQ1.Text, out mq1);
            double.TryParse(txtmidQ2.Text, out mq2);
            double.TryParse(txtmidQ3.Text, out mq3);

            double mle1 = 0, mle2 = 0;
            double.TryParse(txtmidlabexam1.Text, out mle1);
            double.TryParse(txtmidlabexam2.Text, out mle2);

            double mexam = 0;
            double.TryParse(txtmidexam.Text, out mexam);

            double cpMid = (ma1 + ma2 + msw1 + msw2 + mrecite) / 5 * 0.10;
            double labMid = (mlab1 + mlab2 + mlab3 + mlab4) / 4 * 0.10;
            double quizMid = (mq1 + mq2 + mq3) / 3 * 0.20;
            double labExamMid = (mle1 + mle2) / 2 * 0.20;
            double writtenExamMid = mexam * 0.40;
            double midtermGrade = cpMid + labMid + quizMid + labExamMid + writtenExamMid;

            double fa1 = 0, fa2 = 0, fsw1 = 0, fsw2 = 0, frecite = 0;
            double.TryParse(txtFassign1.Text, out fa1);
            double.TryParse(txtFassign2.Text, out fa2);
            double.TryParse(txtFSW1.Text, out fsw1);
            double.TryParse(txtFSW2.Text, out fsw2);
            double.TryParse(txtFrecite.Text, out frecite);

            double flab1 = 0, flab2 = 0, flab3 = 0, flab4 = 0;
            double.TryParse(txtFlab1.Text, out flab1);
            double.TryParse(txtFlab2.Text, out flab2);
            double.TryParse(txtFlab3.Text, out flab3);
            double.TryParse(txtFlab4.Text, out flab4);

            double fq1 = 0, fq2 = 0, fq3 = 0;
            double.TryParse(txtFinalQ1.Text, out fq1);
            double.TryParse(txtFinalQ2.Text, out fq2);
            double.TryParse(txtFinalQ3.Text, out fq3);

            double fle1 = 0, fle2 = 0;
            double.TryParse(txtFlabexam1.Text, out fle1);
            double.TryParse(txtFlabexam2.Text, out fle2);

            double fexam = 0;
            double.TryParse(txtFinalexam.Text, out fexam);

            double cpFinal = (fa1 + fa2 + fsw1 + fsw2 + frecite) / 5 * 0.10;
            double labFinal = (flab1 + flab2 + flab3 + flab4) / 4 * 0.10;
            double quizFinal = (fq1 + fq2 + fq3) / 3 * 0.20;
            double labExamFinal = (fle1 + fle2) / 2 * 0.20;
            double writtenExamFinal = fexam * 0.40;
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
    }
}
