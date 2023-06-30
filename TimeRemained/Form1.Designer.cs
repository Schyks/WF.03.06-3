namespace TimeRemained
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 68);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 3;
            label1.Text = "Поточна дата";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 151);
            label2.Name = "label2";
            label2.Size = new Size(186, 15);
            label2.TabIndex = 4;
            label2.Text = "Дата закінчення курсу WinForms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 231);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "Залишилося секунд";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(275, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.TabStop = false;
            dateTimePicker1.Value = new DateTime(2023, 6, 30, 21, 16, 47, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(275, 181);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 23);
            dateTimePicker2.TabIndex = 7;
            dateTimePicker2.TabStop = false;
            dateTimePicker2.Value = new DateTime(2023, 8, 19, 12, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Location = new Point(367, 270);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;

    }
}