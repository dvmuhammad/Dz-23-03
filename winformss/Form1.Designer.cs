namespace winformss
{
    partial class CalculatorForm
    {
        /// <summary>
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// </summary>
        /// <param name="disposing">.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
      
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcScreen = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonMCClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "MR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonMRClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "MS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonMSClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "M+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonMPlusClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(175, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "M-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonMMinusClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(175, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 28);
            this.button6.TabIndex = 11;
            this.button6.Text = "√";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SqrtButtonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(134, 118);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 28);
            this.button7.TabIndex = 10;
            this.button7.Text = "±";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ChangeSignButtonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(93, 118);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 28);
            this.button8.TabIndex = 9;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(52, 118);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 28);
            this.button9.TabIndex = 8;
            this.button9.Text = "CE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.CEButtonClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(14, 118);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 28);
            this.button10.TabIndex = 7;
            this.button10.Text = "←";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.BackSpaceButtonClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(175, 151);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 28);
            this.button11.TabIndex = 16;
            this.button11.Text = "%";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ButtonPercentClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(134, 151);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 28);
            this.button12.TabIndex = 15;
            this.button12.Text = "/";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ButtonSignClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(93, 151);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 28);
            this.button13.TabIndex = 14;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(52, 151);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 28);
            this.button14.TabIndex = 13;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(14, 151);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 28);
            this.button15.TabIndex = 12;
            this.button15.Text = "7";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(175, 185);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 28);
            this.button16.TabIndex = 21;
            this.button16.Text = "1/x";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ButtonReverseDivideClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(134, 185);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(35, 28);
            this.button17.TabIndex = 20;
            this.button17.Text = "*";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.ButtonSignClick);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(93, 185);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(35, 28);
            this.button18.TabIndex = 19;
            this.button18.Text = "6";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(52, 185);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 28);
            this.button19.TabIndex = 18;
            this.button19.Text = "5";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(14, 185);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(35, 28);
            this.button20.TabIndex = 17;
            this.button20.Text = "4";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(134, 220);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(35, 28);
            this.button22.TabIndex = 25;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.ButtonSignClick);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(93, 220);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(35, 28);
            this.button23.TabIndex = 24;
            this.button23.Text = "3";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(52, 220);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(35, 28);
            this.button24.TabIndex = 23;
            this.button24.Text = "2";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(14, 220);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(35, 28);
            this.button25.TabIndex = 22;
            this.button25.Text = "1";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.Location = new System.Drawing.Point(175, 220);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(35, 63);
            this.button26.TabIndex = 31;
            this.button26.Text = "=";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.ButtonTotalClick);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(134, 255);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(35, 28);
            this.button27.TabIndex = 30;
            this.button27.Text = "+";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.ButtonSignClick);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.Location = new System.Drawing.Point(93, 255);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(35, 28);
            this.button28.TabIndex = 29;
            this.button28.Text = ",";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(14, 255);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(73, 28);
            this.button30.TabIndex = 27;
            this.button30.Text = "0";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.NumberCommaButtonClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 23);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(42, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Правка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(98, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Справка";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcScreen
            // 
            this.CalcScreen.BackColor = System.Drawing.Color.Lavender;
            this.CalcScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CalcScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcScreen.Location = new System.Drawing.Point(14, 31);
            this.CalcScreen.Name = "CalcScreen";
            this.CalcScreen.Size = new System.Drawing.Size(195, 50);
            this.CalcScreen.TabIndex = 33;
            this.CalcScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(224, 292);
            this.Controls.Add(this.CalcScreen);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label CalcScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

