namespace CALC
{
    partial class Calc
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
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_4 = new Button();
            btn_5 = new Button();
            btn_6 = new Button();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_0 = new Button();
            button11 = new Button();
            btn_erase = new Button();
            btn_minus = new Button();
            point = new Button();
            btn_divide = new Button();
            button16 = new Button();
            btn_multiply = new Button();
            txt_display = new RichTextBox();
            SuspendLayout();
            // 
            // btn_1
            // 
            btn_1.BackColor = Color.Black;
            btn_1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_1.FlatStyle = FlatStyle.Flat;
            btn_1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_1.ForeColor = Color.FromArgb(0, 0, 64);
            btn_1.Location = new Point(12, 365);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(81, 69);
            btn_1.TabIndex = 1;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = false;
            btn_1.Click += btn_digit_click;
            // 
            // btn_2
            // 
            btn_2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_2.FlatStyle = FlatStyle.Flat;
            btn_2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_2.ForeColor = Color.FromArgb(0, 64, 0);
            btn_2.Location = new Point(99, 365);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(81, 69);
            btn_2.TabIndex = 2;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_digit_click;
            // 
            // btn_3
            // 
            btn_3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_3.FlatStyle = FlatStyle.Flat;
            btn_3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_3.ForeColor = Color.FromArgb(0, 64, 0);
            btn_3.Location = new Point(186, 365);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(81, 69);
            btn_3.TabIndex = 3;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_digit_click;
            // 
            // btn_4
            // 
            btn_4.BackColor = Color.Black;
            btn_4.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_4.FlatStyle = FlatStyle.Flat;
            btn_4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_4.ForeColor = Color.FromArgb(0, 0, 64);
            btn_4.Location = new Point(12, 288);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(81, 71);
            btn_4.TabIndex = 4;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = false;
            btn_4.Click += btn_digit_click;
            // 
            // btn_5
            // 
            btn_5.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_5.FlatStyle = FlatStyle.Flat;
            btn_5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_5.ForeColor = Color.FromArgb(0, 64, 0);
            btn_5.Location = new Point(99, 288);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(81, 71);
            btn_5.TabIndex = 5;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_digit_click;
            // 
            // btn_6
            // 
            btn_6.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_6.FlatStyle = FlatStyle.Flat;
            btn_6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_6.ForeColor = Color.FromArgb(0, 64, 0);
            btn_6.Location = new Point(186, 288);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(81, 71);
            btn_6.TabIndex = 6;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_digit_click;
            // 
            // btn_7
            // 
            btn_7.BackColor = Color.Black;
            btn_7.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_7.FlatStyle = FlatStyle.Flat;
            btn_7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_7.ForeColor = Color.FromArgb(0, 0, 64);
            btn_7.Location = new Point(12, 213);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(81, 69);
            btn_7.TabIndex = 7;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = false;
            btn_7.Click += btn_digit_click;
            // 
            // btn_8
            // 
            btn_8.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_8.FlatStyle = FlatStyle.Flat;
            btn_8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_8.ForeColor = Color.FromArgb(0, 64, 0);
            btn_8.Location = new Point(99, 213);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(81, 69);
            btn_8.TabIndex = 8;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_digit_click;
            // 
            // btn_9
            // 
            btn_9.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_9.FlatStyle = FlatStyle.Flat;
            btn_9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_9.ForeColor = Color.FromArgb(0, 64, 0);
            btn_9.Location = new Point(186, 213);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(81, 69);
            btn_9.TabIndex = 9;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_digit_click;
            // 
            // btn_0
            // 
            btn_0.BackColor = Color.Black;
            btn_0.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_0.FlatStyle = FlatStyle.Flat;
            btn_0.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_0.ForeColor = Color.FromArgb(0, 0, 64);
            btn_0.Location = new Point(12, 440);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(168, 73);
            btn_0.TabIndex = 10;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = false;
            btn_0.Click += btn_digit_click;
            // 
            // button11
            // 
            button11.BackColor = Color.Black;
            button11.BackgroundImageLayout = ImageLayout.None;
            button11.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button11.ForeColor = Color.FromArgb(192, 0, 0);
            button11.Location = new Point(273, 365);
            button11.Name = "button11";
            button11.Size = new Size(81, 148);
            button11.TabIndex = 11;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // btn_erase
            // 
            btn_erase.BackColor = Color.Black;
            btn_erase.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_erase.FlatStyle = FlatStyle.Flat;
            btn_erase.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_erase.ForeColor = Color.FromArgb(192, 0, 0);
            btn_erase.Location = new Point(273, 213);
            btn_erase.Name = "btn_erase";
            btn_erase.Size = new Size(81, 144);
            btn_erase.TabIndex = 12;
            btn_erase.Text = "+";
            btn_erase.UseVisualStyleBackColor = false;
            btn_erase.Click += btn_operator_click;
            // 
            // btn_minus
            // 
            btn_minus.BackColor = Color.Black;
            btn_minus.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_minus.FlatStyle = FlatStyle.Flat;
            btn_minus.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_minus.ForeColor = Color.FromArgb(0, 0, 64);
            btn_minus.Location = new Point(12, 138);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(81, 69);
            btn_minus.TabIndex = 13;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = false;
            btn_minus.Click += btn_operator_click;
            // 
            // point
            // 
            point.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            point.FlatStyle = FlatStyle.Flat;
            point.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            point.ForeColor = Color.FromArgb(0, 64, 0);
            point.Location = new Point(186, 440);
            point.Name = "point";
            point.Size = new Size(81, 73);
            point.TabIndex = 14;
            point.Text = ".";
            point.UseVisualStyleBackColor = true;
            point.Click += btn_digit_click;
            // 
            // btn_divide
            // 
            btn_divide.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_divide.FlatStyle = FlatStyle.Flat;
            btn_divide.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_divide.ForeColor = Color.FromArgb(0, 64, 0);
            btn_divide.Location = new Point(99, 138);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(81, 69);
            btn_divide.TabIndex = 15;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_operator_click;
            // 
            // button16
            // 
            button16.BackColor = Color.Black;
            button16.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button16.ForeColor = Color.FromArgb(192, 0, 0);
            button16.Location = new Point(273, 138);
            button16.Name = "button16";
            button16.Size = new Size(81, 69);
            button16.TabIndex = 16;
            button16.Text = "C";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.BackColor = Color.Black;
            btn_multiply.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btn_multiply.FlatStyle = FlatStyle.Flat;
            btn_multiply.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn_multiply.ForeColor = Color.FromArgb(192, 0, 0);
            btn_multiply.Location = new Point(186, 138);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(81, 69);
            btn_multiply.TabIndex = 17;
            btn_multiply.Text = "*";
            btn_multiply.UseVisualStyleBackColor = false;
            btn_multiply.Click += btn_operator_click;
            // 
            // txt_display
            // 
            txt_display.BackColor = Color.Black;
            txt_display.BorderStyle = BorderStyle.None;
            txt_display.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_display.ForeColor = Color.White;
            txt_display.Location = new Point(12, 12);
            txt_display.Name = "txt_display";
            txt_display.ReadOnly = true;
            txt_display.RightToLeft = RightToLeft.Yes;
            txt_display.Size = new Size(342, 120);
            txt_display.TabIndex = 18;
            txt_display.Text = "";
            // 
            // Calc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(365, 535);
            Controls.Add(txt_display);
            Controls.Add(btn_multiply);
            Controls.Add(button16);
            Controls.Add(btn_divide);
            Controls.Add(point);
            Controls.Add(btn_minus);
            Controls.Add(btn_erase);
            Controls.Add(button11);
            Controls.Add(btn_0);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Name = "Calc";
            Text = "CALC(slang for calculator)";
            ResumeLayout(false);
        }

        #endregion
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_4;
        private Button btn_5;
        private Button btn_6;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_0;
        private Button button11;
        private Button btn_erase;
        private Button btn_minus;
        private Button point;
        private Button btn_divide;
        private Button button16;
        private Button btn_multiply;
        private RichTextBox txt_display;
    }
}
