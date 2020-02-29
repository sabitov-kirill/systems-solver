namespace SystemsSolver.GUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FeedbackButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.eqQu2 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.eqQu3 = new System.Windows.Forms.Button();
            this.emptyControl1 = new SystemsSolver.GUI.Controls.EmptyControl();
            this.solvingSyst2 = new SystemsSolver.GUI.SolvingSyst2();
            this.solvingSyst3 = new SystemsSolver.GUI.Controls.SolvingSyst3();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.FeedbackButton);
            this.panel1.Controls.Add(this.InfoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 261);
            this.panel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = global::SystemsSolver.GUI.Properties.Resources.ButtonClose;
            this.CloseButton.Location = new System.Drawing.Point(4, 223);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 35);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // FeedbackButton
            // 
            this.FeedbackButton.FlatAppearance.BorderSize = 0;
            this.FeedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeedbackButton.Image = global::SystemsSolver.GUI.Properties.Resources.ButtonFeedback;
            this.FeedbackButton.Location = new System.Drawing.Point(4, 44);
            this.FeedbackButton.Name = "FeedbackButton";
            this.FeedbackButton.Size = new System.Drawing.Size(35, 35);
            this.FeedbackButton.TabIndex = 1;
            this.FeedbackButton.TabStop = false;
            this.FeedbackButton.UseVisualStyleBackColor = true;
            this.FeedbackButton.Click += new System.EventHandler(this.FeedbackButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Image = global::SystemsSolver.GUI.Properties.Resources.ButtonInfo;
            this.InfoButton.Location = new System.Drawing.Point(4, 4);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(35, 35);
            this.InfoButton.TabIndex = 1;
            this.InfoButton.TabStop = false;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(43, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 4);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(391, 117);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите количесьтво уравнений в системе, чтобы приступить к ее решению.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eqQu2
            // 
            this.eqQu2.FlatAppearance.BorderSize = 0;
            this.eqQu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eqQu2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eqQu2.ForeColor = System.Drawing.Color.White;
            this.eqQu2.Image = global::SystemsSolver.GUI.Properties.Resources.Button2Eq;
            this.eqQu2.Location = new System.Drawing.Point(103, 133);
            this.eqQu2.Name = "eqQu2";
            this.eqQu2.Size = new System.Drawing.Size(120, 120);
            this.eqQu2.TabIndex = 4;
            this.eqQu2.TabStop = false;
            this.eqQu2.UseVisualStyleBackColor = false;
            this.eqQu2.Click += new System.EventHandler(this.eqQu2_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::SystemsSolver.GUI.Properties.Resources.ButtonBack;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Location = new System.Drawing.Point(135, 205);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(48, 48);
            this.backButton.TabIndex = 9;
            this.backButton.TabStop = false;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // eqQu3
            // 
            this.eqQu3.FlatAppearance.BorderSize = 0;
            this.eqQu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eqQu3.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eqQu3.ForeColor = System.Drawing.Color.White;
            this.eqQu3.Image = global::SystemsSolver.GUI.Properties.Resources.Button3Eq;
            this.eqQu3.Location = new System.Drawing.Point(264, 133);
            this.eqQu3.Name = "eqQu3";
            this.eqQu3.Size = new System.Drawing.Size(120, 120);
            this.eqQu3.TabIndex = 5;
            this.eqQu3.TabStop = false;
            this.eqQu3.UseVisualStyleBackColor = false;
            this.eqQu3.Click += new System.EventHandler(this.eqQu3_Click);
            // 
            // emptyControl1
            // 
            this.emptyControl1.BackColor = System.Drawing.Color.White;
            this.emptyControl1.Location = new System.Drawing.Point(40, 3);
            this.emptyControl1.Name = "emptyControl1";
            this.emptyControl1.Size = new System.Drawing.Size(391, 259);
            this.emptyControl1.TabIndex = 8;
            // 
            // solvingSyst2
            // 
            this.solvingSyst2.BackColor = System.Drawing.Color.White;
            this.solvingSyst2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("solvingSyst2.BackgroundImage")));
            this.solvingSyst2.Location = new System.Drawing.Point(43, 4);
            this.solvingSyst2.Name = "solvingSyst2";
            this.solvingSyst2.Size = new System.Drawing.Size(391, 257);
            this.solvingSyst2.TabIndex = 10;
            // 
            // solvingSyst3
            // 
            this.solvingSyst3.BackColor = System.Drawing.Color.White;
            this.solvingSyst3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("solvingSyst3.BackgroundImage")));
            this.solvingSyst3.Location = new System.Drawing.Point(43, 4);
            this.solvingSyst3.Name = "solvingSyst3";
            this.solvingSyst3.Size = new System.Drawing.Size(391, 257);
            this.solvingSyst3.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.eqQu2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.eqQu3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.emptyControl1);
            this.Controls.Add(this.solvingSyst3);
            this.Controls.Add(this.solvingSyst2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решатель Систем";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FeedbackButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button eqQu3;
        private System.Windows.Forms.Button eqQu2;
        private Controls.EmptyControl emptyControl1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private SolvingSyst2 solvingSyst2;
        private Controls.SolvingSyst3 solvingSyst3;
    }
}