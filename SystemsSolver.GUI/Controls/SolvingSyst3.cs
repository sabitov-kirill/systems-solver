using System;
using SystemsSolver.Logic.Model;
using SystemsSolver.GUI.Forms;
using System.Windows.Forms;

namespace SystemsSolver.GUI.Controls
{
    public partial class SolvingSyst3 : UserControl
    {
        double[,] coeffs = new double[3, 4];

        public SolvingSyst3()
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
        private void E1C4textBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void E2C4textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }
        private void E3C1textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }
        private void E3C2textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }
        private void E3C3textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }
        private void E3C4textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumberEntering(e);
        }
        #endregion

        private void SolveButton_Click(object sender, EventArgs e)
        {
            if (E1C1textBox.Text == "" | E1C2textBox.Text == "" | E1C3textBox.Text == "" | E1C4textBox.Text == "" | E2C1textBox.Text == "" | E2C2textBox.Text == "" | E2C3textBox.Text == "" | E2C4textBox.Text == "" | E3C1textBox.Text == "" | E3C2textBox.Text == "" | E3C3textBox.Text == "" | E3C4textBox.Text == "")
            {
                MessageBox.Show("Введены не все коэффициенты уравнений в системе.", "Ошибка!");
            }
            else
            {
                coeffs[0, 0] = double.Parse(E1C1textBox.Text);
                coeffs[0, 1] = double.Parse(E1C2textBox.Text);
                coeffs[0, 2] = double.Parse(E1C3textBox.Text);
                coeffs[0, 3] = double.Parse(E1C4textBox.Text);

                coeffs[1, 0] = double.Parse(E2C1textBox.Text);
                coeffs[1, 1] = double.Parse(E2C2textBox.Text);
                coeffs[1, 2] = double.Parse(E2C3textBox.Text);
                coeffs[1, 3] = double.Parse(E2C4textBox.Text);

                coeffs[2, 0] = double.Parse(E3C1textBox.Text);
                coeffs[2, 1] = double.Parse(E3C2textBox.Text);
                coeffs[2, 2] = double.Parse(E3C3textBox.Text);
                coeffs[2, 3] = double.Parse(E3C4textBox.Text);

                char[] varChars = { 'x', 'y', 'z' };
                EquationSystem equationSystemWith3Eq = new EquationSystem(3, coeffs, varChars);
                MessageBox.Show($"{equationSystemWith3Eq.SolveEquationsSystem()}", "Решение");
            }
        }

        private void AllowOnlyNumberEntering(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
