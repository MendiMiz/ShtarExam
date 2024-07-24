namespace ShtarXml
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLabel = new Label();
            WeekDayComboBox = new ComboBox();
            MonthDayComboBox = new ComboBox();
            MonthComboBox = new ComboBox();
            YearComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddButton = new Button();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(237, 38);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(109, 21);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "כתיבת תאריך";
            // 
            // WeekDayComboBox
            // 
            WeekDayComboBox.FormattingEnabled = true;
            WeekDayComboBox.Location = new Point(437, 132);
            WeekDayComboBox.Name = "WeekDayComboBox";
            WeekDayComboBox.RightToLeft = RightToLeft.No;
            WeekDayComboBox.Size = new Size(78, 23);
            WeekDayComboBox.TabIndex = 1;
            // 
            // MonthDayComboBox
            // 
            MonthDayComboBox.FormattingEnabled = true;
            MonthDayComboBox.Location = new Point(318, 132);
            MonthDayComboBox.Name = "MonthDayComboBox";
            MonthDayComboBox.RightToLeft = RightToLeft.No;
            MonthDayComboBox.Size = new Size(78, 23);
            MonthDayComboBox.TabIndex = 1;
            // 
            // MonthComboBox
            // 
            MonthComboBox.FormattingEnabled = true;
            MonthComboBox.Location = new Point(207, 132);
            MonthComboBox.Name = "MonthComboBox";
            MonthComboBox.RightToLeft = RightToLeft.No;
            MonthComboBox.Size = new Size(78, 23);
            MonthComboBox.TabIndex = 1;
            // 
            // YearComboBox
            // 
            YearComboBox.FormattingEnabled = true;
            YearComboBox.Location = new Point(86, 132);
            YearComboBox.Name = "YearComboBox";
            YearComboBox.RightToLeft = RightToLeft.No;
            YearComboBox.Size = new Size(78, 23);
            YearComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 114);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "היום בחודש";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 114);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "היום בשבוע";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 114);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 114);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 2;
            label4.Text = "שנה";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(237, 190);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(117, 28);
            AddButton.TabIndex = 3;
            AddButton.Text = "הוסף";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 337);
            Controls.Add(AddButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(YearComboBox);
            Controls.Add(MonthComboBox);
            Controls.Add(MonthDayComboBox);
            Controls.Add(WeekDayComboBox);
            Controls.Add(TitleLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private ComboBox WeekDayComboBox;
        private ComboBox MonthDayComboBox;
        private ComboBox MonthComboBox;
        private ComboBox YearComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddButton;
    }
}
