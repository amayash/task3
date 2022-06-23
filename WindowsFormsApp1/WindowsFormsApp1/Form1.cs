using lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Text;
                Array_first a1 = new Array_first(Convert.ToInt32(odnom.Text));
                Text = "Оригинальный массив - " + a1.Print() + "";
                original.Text=Text;


                String firstText;
                firstText = "Первое задание - " + a1.nom1() + "";
                firstTask.Text=firstText;

                secondTask.Text="";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondArrayButton_Click(object sender, EventArgs e)
        {
            try
            {
                String Text;
                Array_second a2 = new Array_second(Convert.ToInt32(dvumi.Text), Convert.ToInt32(dvumj.Text));
                Text = "Оригинальный массив\n";
                Text = Text + a2.Print();
                original.Text = Text;
                String firstText;

                firstText = "Второе задание\n";
                firstText = firstText + a2.nom2() + "";
                firstText = firstText + "";
                firstTask.Text = firstText;

                String secondText;
                secondText = "Третье задание\n";
                secondText = secondText + a2.nom3(a2.stroka()) + "";
                secondText = secondText + "";
                secondTask.Text = secondText;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dvumi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
