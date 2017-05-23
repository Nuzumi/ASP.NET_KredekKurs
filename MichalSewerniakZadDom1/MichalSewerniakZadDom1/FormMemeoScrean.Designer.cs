namespace MichalSewerniakZadDom1
{
    partial class FormMemeoScrean
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
            this.components = new System.ComponentModel.Container();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.textBoxPlayField = new System.Windows.Forms.TextBox();
            this.timerStartGame = new System.Windows.Forms.Timer(this.components);
            this.textBoxRules = new System.Windows.Forms.TextBox();
            this.textBoxMinimumNumber = new System.Windows.Forms.TextBox();
            this.labelMinimum = new System.Windows.Forms.Label();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.textBoxMaximumNumber = new System.Windows.Forms.TextBox();
            this.buttonOkMinimum = new System.Windows.Forms.Button();
            this.buttonOkMaximum = new System.Windows.Forms.Button();
            this.timerAnswerTime = new System.Windows.Forms.Timer(this.components);
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(228, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(35, 13);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "label1";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(211, 114);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(75, 23);
            this.buttonStartGame.TabIndex = 1;
            this.buttonStartGame.Text = "Play";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonWelcome_Click);
            // 
            // textBoxPlayField
            // 
            this.textBoxPlayField.Location = new System.Drawing.Point(12, 12);
            this.textBoxPlayField.Multiline = true;
            this.textBoxPlayField.Name = "textBoxPlayField";
            this.textBoxPlayField.ReadOnly = true;
            this.textBoxPlayField.Size = new System.Drawing.Size(495, 297);
            this.textBoxPlayField.TabIndex = 2;
            this.textBoxPlayField.Visible = false;
            // 
            // timerStartGame
            // 
            this.timerStartGame.Interval = 1000;
            this.timerStartGame.Tick += new System.EventHandler(this.timerStartGame_Tick);
            // 
            // textBoxRules
            // 
            this.textBoxRules.Location = new System.Drawing.Point(159, 28);
            this.textBoxRules.Multiline = true;
            this.textBoxRules.Name = "textBoxRules";
            this.textBoxRules.Size = new System.Drawing.Size(185, 64);
            this.textBoxRules.TabIndex = 3;
            this.textBoxRules.Text = "teraz pokaże ci kilka numerkow postaraj sie je zapamietac\r\n \r\n";
            // 
            // textBoxMinimumNumber
            // 
            this.textBoxMinimumNumber.Location = new System.Drawing.Point(67, 329);
            this.textBoxMinimumNumber.Name = "textBoxMinimumNumber";
            this.textBoxMinimumNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinimumNumber.TabIndex = 4;
            // 
            // labelMinimum
            // 
            this.labelMinimum.AutoSize = true;
            this.labelMinimum.Location = new System.Drawing.Point(14, 333);
            this.labelMinimum.Name = "labelMinimum";
            this.labelMinimum.Size = new System.Drawing.Size(47, 13);
            this.labelMinimum.TabIndex = 5;
            this.labelMinimum.Text = "minimum";
            // 
            // labelMaximum
            // 
            this.labelMaximum.AutoSize = true;
            this.labelMaximum.Location = new System.Drawing.Point(294, 332);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(50, 13);
            this.labelMaximum.TabIndex = 6;
            this.labelMaximum.Text = "maximum";
            // 
            // textBoxMaximumNumber
            // 
            this.textBoxMaximumNumber.Location = new System.Drawing.Point(350, 329);
            this.textBoxMaximumNumber.Name = "textBoxMaximumNumber";
            this.textBoxMaximumNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaximumNumber.TabIndex = 6;
            // 
            // buttonOkMinimum
            // 
            this.buttonOkMinimum.Location = new System.Drawing.Point(173, 328);
            this.buttonOkMinimum.Name = "buttonOkMinimum";
            this.buttonOkMinimum.Size = new System.Drawing.Size(29, 23);
            this.buttonOkMinimum.TabIndex = 5;
            this.buttonOkMinimum.Text = "ok";
            this.buttonOkMinimum.UseVisualStyleBackColor = true;
            this.buttonOkMinimum.Click += new System.EventHandler(this.buttonOkMinimum_Click);
            // 
            // buttonOkMaximum
            // 
            this.buttonOkMaximum.Location = new System.Drawing.Point(456, 328);
            this.buttonOkMaximum.Name = "buttonOkMaximum";
            this.buttonOkMaximum.Size = new System.Drawing.Size(28, 23);
            this.buttonOkMaximum.TabIndex = 7;
            this.buttonOkMaximum.Text = "ok";
            this.buttonOkMaximum.UseVisualStyleBackColor = true;
            this.buttonOkMaximum.Click += new System.EventHandler(this.buttonOkMaximum_Click);
            // 
            // timerAnswerTime
            // 
            this.timerAnswerTime.Interval = 7000;
            this.timerAnswerTime.Tick += new System.EventHandler(this.timerAnswerTime_Tick);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(184, 143);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(124, 20);
            this.textBoxPassword.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(208, 119);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "podaj hasło";
            // 
            // buttonPassword
            // 
            this.buttonPassword.Location = new System.Drawing.Point(211, 179);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(75, 23);
            this.buttonPassword.TabIndex = 10;
            this.buttonPassword.Text = "OK";
            this.buttonPassword.UseVisualStyleBackColor = true;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // FormMemeoScrean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 358);
            this.Controls.Add(this.buttonPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonOkMaximum);
            this.Controls.Add(this.buttonOkMinimum);
            this.Controls.Add(this.textBoxMaximumNumber);
            this.Controls.Add(this.labelMaximum);
            this.Controls.Add(this.labelMinimum);
            this.Controls.Add(this.textBoxMinimumNumber);
            this.Controls.Add(this.textBoxRules);
            this.Controls.Add(this.textBoxPlayField);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMemeoScrean";
            this.Text = "FormMemeoScrean";
            this.Load += new System.EventHandler(this.FormMemeoScrean_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.TextBox textBoxPlayField;
        private System.Windows.Forms.Timer timerStartGame;
        private System.Windows.Forms.TextBox textBoxRules;
        private System.Windows.Forms.TextBox textBoxMinimumNumber;
        private System.Windows.Forms.Label labelMinimum;
        private System.Windows.Forms.Label labelMaximum;
        private System.Windows.Forms.TextBox textBoxMaximumNumber;
        private System.Windows.Forms.Button buttonOkMinimum;
        private System.Windows.Forms.Button buttonOkMaximum;
        private System.Windows.Forms.Timer timerAnswerTime;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonPassword;
    }
}