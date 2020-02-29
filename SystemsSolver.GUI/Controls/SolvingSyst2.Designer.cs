namespace SystemsSolver.GUI
{
    partial class SolvingSyst2
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.E1C1textBox = new System.Windows.Forms.TextBox();
            this.E2C3textBox = new System.Windows.Forms.TextBox();
            this.E2C2textBox = new System.Windows.Forms.TextBox();
            this.E2C1textBox = new System.Windows.Forms.TextBox();
            this.E1C2textBox = new System.Windows.Forms.TextBox();
            this.E1C3textBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SolveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // E1C1textBox
            // 
            this.E1C1textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.E1C1textBox.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.E1C1textBox.Location = new System.Drawing.Point(97, 50);
            this.E1C1textBox.MaxLength = 4;
            this.E1C1textBox.Name = "E1C1textBox";
            this.E1C1textBox.Size = new System.Drawing.Size(40, 28);
            this.E1C1textBox.TabIndex = 0;
            this.E1C1textBox.TextChanged += new System.EventHandler(this.E1C1textBox_TextChanged);
            this.E1C1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E1C1textBox_KeyPress);
            // 
            // E2C3textBox
            // 
            this.E2C3textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.E2C3textBox.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.E2C3textBox.Location = new System.Drawing.Point(255, 105);
            this.E2C3textBox.MaxLength = 4;
            this.E2C3textBox.Name = "E2C3textBox";
            this.E2C3textBox.Size = new System.Drawing.Size(40, 28);
            this.E2C3textBox.TabIndex = 5;
            this.E2C3textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E2C3textBox_KeyPress);
            // 
            // E2C2textBox
            // 
            this.E2C2textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.E2C2textBox.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.E2C2textBox.Location = new System.Drawing.Point(175, 105);
            this.E2C2textBox.MaxLength = 4;
            this.E2C2textBox.Name = "E2C2textBox";
            this.E2C2textBox.Size = new System.Drawing.Size(40, 28);
            this.E2C2textBox.TabIndex = 4;
            this.E2C2textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E2C2textBox_KeyPress);
            // 
            // E2C1textBox
            // 
            this.E2C1textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.E2C1textBox.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.E2C1textBox.Location = new System.Drawing.Point(97, 105);
            this.E2C1textBox.MaxLength = 4;
            this.E2C1textBox.Name = "E2C1textBox";
            this.E2C1textBox.Size = new System.Drawing.Size(40, 28);
            this.E2C1textBox.TabIndex = 3;
            this.E2C1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E2C1textBox_KeyPress);
            // 
            // E1C2textBox
            // 
            this.E1C2textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.E1C2textBox.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.E1C2textBox.Location = new System.Drawing.Point(175, 50);
            this.E1C2textBox.MaxLength = 4;
            this.E1C2textBox.Name = "E1C2textBox";
            this.E1C2textBox.Size = new System.Drawing.Size(40, 28);
            this.E1C2textBox.TabIndex = 1;
            this.E1C2textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E1C2textBox_KeyPress);
            // 
            // E1C3textBox
            // 
            this.E1C3textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.E1C3textBox.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.E1C3textBox.Location = new System.Drawing.Point(255, 50);
            this.E1C3textBox.MaxLength = 4;
            this.E1C3textBox.Name = "E1C3textBox";
            this.E1C3textBox.Size = new System.Drawing.Size(40, 28);
            this.E1C3textBox.TabIndex = 2;
            this.E1C3textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.E1C3textBox_KeyPress);
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(391, 28);
            this.Title.TabIndex = 14;
            this.Title.Text = "Вы решате систему двух уравнений.";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SolveButton
            // 
            this.SolveButton.BackgroundImage = global::SystemsSolver.GUI.Properties.Resources.ButtonSolve;
            this.SolveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SolveButton.FlatAppearance.BorderSize = 0;
            this.SolveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SolveButton.Font = new System.Drawing.Font("GOST type A", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolveButton.ForeColor = System.Drawing.Color.White;
            this.SolveButton.Location = new System.Drawing.Point(146, 201);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(150, 48);
            this.SolveButton.TabIndex = 44;
            this.SolveButton.TabStop = false;
            this.SolveButton.Text = "Решить";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // SolvingSyst2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SystemsSolver.GUI.Properties.Resources.BackgroundImage2;
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.E1C3textBox);
            this.Controls.Add(this.E1C2textBox);
            this.Controls.Add(this.E2C3textBox);
            this.Controls.Add(this.E2C2textBox);
            this.Controls.Add(this.E2C1textBox);
            this.Controls.Add(this.E1C1textBox);
            this.Name = "SolvingSyst2";
            this.Size = new System.Drawing.Size(391, 257);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox E1C1textBox;
        private System.Windows.Forms.TextBox E2C3textBox;
        private System.Windows.Forms.TextBox E2C2textBox;
        private System.Windows.Forms.TextBox E2C1textBox;
        private System.Windows.Forms.TextBox E1C2textBox;
        private System.Windows.Forms.TextBox E1C3textBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button SolveButton;
    }
}
