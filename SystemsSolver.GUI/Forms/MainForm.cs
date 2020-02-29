using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemsSolver.GUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CleanAllTextBoxesIn(solvingSyst2);
            CleanAllTextBoxesIn(solvingSyst3);
            solvingSyst2.Hide();
            solvingSyst3.Hide();
            backButton.Hide();
        }

        private void eqQu2_Click(object sender, EventArgs e)
        {
            solvingSyst2.Show();
            solvingSyst2.BringToFront();
            solvingSyst2.Focus();
            backButton.Show();
            backButton.BringToFront();
        }

        private void eqQu3_Click(object sender, EventArgs e)
        {
            solvingSyst3.Show();
            solvingSyst3.BringToFront();
            solvingSyst3.Focus();
            backButton.Show();
            backButton.BringToFront();
        }

        private static void CleanAllTextBoxesIn(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;

                if (c.GetType() == typeof(GroupBox))
                    CleanAllTextBoxesIn(c);
            }
        }

        private void FeedbackButton_Click(object sender, EventArgs e)
        {
            FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.ShowDialog();
            feedbackForm.ShowInTaskbar = false;
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InforamationForm infoForm = new InforamationForm();
            infoForm.ShowDialog();
        }
    }
}
