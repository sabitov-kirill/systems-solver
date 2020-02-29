using System;
using SystemsSolver.GUI.Forms;
using System.Windows.Forms;
using SystemsSolver.Logic.Model;

namespace SystemsSolver.GUI
{
    public partial class SolvingSyst2 : UserControl
    {
        double[,] coeffs = new double[2, 3];
        
        public SolvingSyst2()
        {
            InitializeComponent();
        }

        #region Поля ввода значений коэффициентов системы
        private void E1C1textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }

        private void E1C2textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }

        private void E1C3textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }

        private void E2C1textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }

        private void E2C2textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }

        private void E2C3textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }
        #endregion



        private void SolveButton_Click(object sender, EventArgs e)
        {
            if (E1C1textBox.Text == "" | E1C2textBox.Text == "" | E1C3textBox.Text == "" | E2C1textBox.Text == "" | E2C3textBox.Text == "" | E2C3textBox.Text == "")
            {
                MessageBox.Show("Введены не все коэффициенты уравнений в системе.", "Ошибка!");
            }
            else
            {
                coeffs[0, 0] = double.Parse(E1C1textBox.Text);
                coeffs[0, 1] = double.Parse(E1C2textBox.Text);
                coeffs[0, 2] = double.Parse(E1C3textBox.Text);
                coeffs[1, 0] = double.Parse(E2C1textBox.Text);
                coeffs[1, 1] = double.Parse(E2C2textBox.Text);
                coeffs[1, 2] = double.Parse(E2C3textBox.Text);
                char[] varChars = { 'x', 'y'};
                EquationSystem equationSystemWith2Eq = new EquationSystem(2, coeffs, varChars);
                MessageBox.Show($"{equationSystemWith2Eq.SolveEquationsSystem()}", "Решение");
            }
        }

        private void AllowOnlyNumberEntering(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void E1C1textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SolveButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
