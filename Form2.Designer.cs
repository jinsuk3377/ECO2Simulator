using System.Windows.Forms;
using System;
using System.Drawing;

namespace ADR2013AppCS01
{
    partial class Form2
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
           // Form2 form2 = new Form2();

            string[] property = { "열관류율", "연면적", "외피, 벽제창", "층수" };

            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.textBox_3 = new System.Windows.Forms.TextBox();
            this.textBox_4 = new System.Windows.Forms.TextBox();

            this.comboBox_1 = new System.Windows.Forms.ComboBox();
            this.comboBox_2 = new System.Windows.Forms.ComboBox();
            this.comboBox_3 = new System.Windows.Forms.ComboBox();
            this.comboBox_4 = new System.Windows.Forms.ComboBox();

            this.submit_Button = new System.Windows.Forms.Button();

            // textBox_1 - 열관류율
            // 
            this.textBox_1.Location = new System.Drawing.Point(180, 30);
            this.textBox_1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_1.Multiline = true;
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(160, 20);
            this.textBox_1.TabIndex = 1;
            this.textBox_1.Click += new System.EventHandler(Mouse_Click_Heat);

            // comboBox_1 - 열관류율
            //
            this.comboBox_1.Location = new System.Drawing.Point(80, 30);
            //this.textBox_1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_1.Size = new System.Drawing.Size(90, 50);
            this.comboBox_1.Name = "comboBox_1";
            this.comboBox_1.TabIndex = 5;
            this.comboBox_1.Items.AddRange(property);   // dropdownlist 여부 확인하기!!!
            this.comboBox_1.SelectedIndex = 0;
            

            // textBox_2 - 연면적
            // 
            this.textBox_2.Location = new System.Drawing.Point(180, 70);
            this.textBox_2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_2.Multiline = true;
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(160, 20);
            this.textBox_2.TabIndex = 2;
            this.textBox_2.Click += new System.EventHandler(Mouse_Click_Volumn);


            // comboBox_2 - 연면적
            //
            this.comboBox_2.Location = new System.Drawing.Point(80, 70);
            //this.textBox_1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_2.Size = new System.Drawing.Size(90, 50);
            this.comboBox_2.Name = "comboBox_2";
            this.comboBox_2.TabIndex = 6;
            this.comboBox_2.Items.AddRange(property);   // dropdownlist 여부 확인하기!!!
            this.comboBox_2.SelectedIndex = 1;


            // textBox_3 - 외피, 벽제창
            // 
            this.textBox_3.Location = new System.Drawing.Point(180, 110);
            this.textBox_3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_3.Multiline = true;
            this.textBox_3.Name = "textBox_3";
            this.textBox_3.Size = new System.Drawing.Size(160, 20);
            this.textBox_3.TabIndex = 3;
            this.textBox_3.Click += new System.EventHandler(Mouse_Click_Window);

            // comboBox_3 - 외피, 벽제창
            //
            this.comboBox_3.Location = new System.Drawing.Point(80, 110);
            //this.textBox_1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_3.Size = new System.Drawing.Size(90, 50);
            this.comboBox_3.Name = "comboBox_3";
            this.comboBox_3.TabIndex = 7;
            this.comboBox_3.Items.AddRange(property);   // dropdownlist 여부 확인하기!!!
            this.comboBox_3.SelectedIndex = 2;


            // textBox_4 - 층수
            // 
            this.textBox_4.Location = new System.Drawing.Point(180, 150);
            this.textBox_4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_4.Multiline = true;
            this.textBox_4.Name = "textBox_4";
            this.textBox_4.Size = new System.Drawing.Size(160, 20);
            this.textBox_4.TabIndex = 4;
            this.textBox_4.Click += new System.EventHandler(Mouse_Click_Storey);
            

            // comboBox_4 - 층수
            //
            this.comboBox_4.Location = new System.Drawing.Point(80, 150);
            //this.textBox_1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.comboBox_4.Size = new System.Drawing.Size(90, 50);
            this.comboBox_4.Name = "comboBox_4";
            this.comboBox_4.TabIndex = 8;
            this.comboBox_4.Items.AddRange(property);   // dropdownlist 여부 확인하기!!!
            this.comboBox_4.SelectedIndex = 3;
            //MessageBox.Show("에러");

            // submit botton
            //
            this.submit_Button.Location = new System.Drawing.Point(250, 250);
            this.submit_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit_Button.Name = "제출";
            this.submit_Button.Size = new System.Drawing.Size(89, 30);
            this.submit_Button.TabIndex = 9;
            this.submit_Button.Text = "제출";
            this.submit_Button.UseVisualStyleBackColor = true;
            this.submit_Button.Click += new System.EventHandler(Submit_Button);
            //this.submit_Button.KeyPress += new KeyPressEventHandler(form2.Heat_Text);




            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);

            // this.components = new System.ComponentModel.Container();
            //MessageBox.Show("에러22222");

            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.textBox_2);
            this.Controls.Add(this.textBox_3);
            this.Controls.Add(this.textBox_4);

            this.Controls.Add(this.comboBox_1);
            this.Controls.Add(this.comboBox_2);
            this.Controls.Add(this.comboBox_3);
            this.Controls.Add(this.comboBox_4);

            this.Controls.Add(this.submit_Button);

            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "Add Gbxml Property";
            this.Name = "Add Gbxml Property";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TextBox textBox_1;
        public TextBox textBox_2;
        public TextBox textBox_3;
        public TextBox textBox_4;

        public ComboBox comboBox_1;
        public ComboBox comboBox_2;
        public ComboBox comboBox_3;
        public ComboBox comboBox_4;

        private System.Windows.Forms.Button submit_Button;
    }
}