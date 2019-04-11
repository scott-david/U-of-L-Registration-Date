namespace Program_2
{
    partial class Form1
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradeLevelLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.gradeGroupBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.sophomoreRadioButton = new System.Windows.Forms.RadioButton();
            this.freshmanRadioButton = new System.Windows.Forms.RadioButton();
            this.registrationDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.gradeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(190, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter first letter of last name:";
            // 
            // gradeLevelLabel
            // 
            this.gradeLevelLabel.AutoSize = true;
            this.gradeLevelLabel.Location = new System.Drawing.Point(26, 83);
            this.gradeLevelLabel.Name = "gradeLevelLabel";
            this.gradeLevelLabel.Size = new System.Drawing.Size(120, 17);
            this.gradeLevelLabel.TabIndex = 1;
            this.gradeLevelLabel.Text = "Enter grade level:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(29, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 2;
            // 
            // gradeGroupBox
            // 
            this.gradeGroupBox.Controls.Add(this.seniorRadioButton);
            this.gradeGroupBox.Controls.Add(this.juniorRadioButton);
            this.gradeGroupBox.Controls.Add(this.sophomoreRadioButton);
            this.gradeGroupBox.Controls.Add(this.freshmanRadioButton);
            this.gradeGroupBox.Location = new System.Drawing.Point(29, 103);
            this.gradeGroupBox.Name = "gradeGroupBox";
            this.gradeGroupBox.Size = new System.Drawing.Size(200, 155);
            this.gradeGroupBox.TabIndex = 7;
            this.gradeGroupBox.TabStop = false;
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(6, 108);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(70, 21);
            this.seniorRadioButton.TabIndex = 3;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.Location = new System.Drawing.Point(6, 81);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(68, 21);
            this.juniorRadioButton.TabIndex = 2;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadioButton
            // 
            this.sophomoreRadioButton.AutoSize = true;
            this.sophomoreRadioButton.Location = new System.Drawing.Point(6, 54);
            this.sophomoreRadioButton.Name = "sophomoreRadioButton";
            this.sophomoreRadioButton.Size = new System.Drawing.Size(102, 21);
            this.sophomoreRadioButton.TabIndex = 1;
            this.sophomoreRadioButton.TabStop = true;
            this.sophomoreRadioButton.Text = "Sophomore";
            this.sophomoreRadioButton.UseVisualStyleBackColor = true;
            // 
            // freshmanRadioButton
            // 
            this.freshmanRadioButton.AutoSize = true;
            this.freshmanRadioButton.Location = new System.Drawing.Point(6, 27);
            this.freshmanRadioButton.Name = "freshmanRadioButton";
            this.freshmanRadioButton.Size = new System.Drawing.Size(92, 21);
            this.freshmanRadioButton.TabIndex = 0;
            this.freshmanRadioButton.TabStop = true;
            this.freshmanRadioButton.Text = "Freshman";
            this.freshmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // registrationDateButton
            // 
            this.registrationDateButton.Location = new System.Drawing.Point(87, 264);
            this.registrationDateButton.Name = "registrationDateButton";
            this.registrationDateButton.Size = new System.Drawing.Size(145, 44);
            this.registrationDateButton.TabIndex = 8;
            this.registrationDateButton.Text = "View Registration Time and Date:";
            this.registrationDateButton.UseVisualStyleBackColor = true;
            this.registrationDateButton.Click += new System.EventHandler(this.registrationDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(87, 314);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(145, 45);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.registrationDateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(319, 371);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.registrationDateButton);
            this.Controls.Add(this.gradeGroupBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.gradeLevelLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.gradeGroupBox.ResumeLayout(false);
            this.gradeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradeLevelLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox gradeGroupBox;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophomoreRadioButton;
        private System.Windows.Forms.RadioButton freshmanRadioButton;
        private System.Windows.Forms.Button registrationDateButton;
        private System.Windows.Forms.Button clearButton;
    }
}

