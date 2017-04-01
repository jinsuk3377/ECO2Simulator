using ADR2013AppCS01;
using System.Windows.Forms;

namespace ADR2013AppCS01
{
    partial class Form3
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
            //Form2 form2 = new Form2();
            ok_Button = new Button();

            textbox_Input_1 = new TextBox();
            textbox_Input_2 = new TextBox();
            textbox_Input_3 = new TextBox();
            textbox_Input_4 = new TextBox();

            
            label_1 = new Label();
            label_2 = new Label();
            label_3 = new Label();
            label_4 = new Label();
            
            // 입력 - 연면적
            //
            this.textbox_Input_1.Location = new System.Drawing.Point(110, 30);
            this.textbox_Input_1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textbox_Input_1.Multiline = true;
            this.textbox_Input_1.Name = "textBox_Input_1";
            this.textbox_Input_1.Size = new System.Drawing.Size(60, 30);
            this.textbox_Input_1.TabIndex = 1;
            this.textbox_Input_1.KeyPress += new KeyPressEventHandler(Input_Text);

            // 입력 - 열관류율
            //
            this.textbox_Input_2.Location = new System.Drawing.Point(110, 30);
            this.textbox_Input_2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textbox_Input_2.Multiline = true;
            this.textbox_Input_2.Name = "textBox_Input_2";
            this.textbox_Input_2.Size = new System.Drawing.Size(60, 30);
            this.textbox_Input_2.TabIndex = 2;
            this.textbox_Input_2.KeyPress += new KeyPressEventHandler(Input_Text);

            // 입력 - 외피, 벽제창
            //
            this.textbox_Input_3.Location = new System.Drawing.Point(110, 30);
            this.textbox_Input_3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textbox_Input_3.Multiline = true;
            this.textbox_Input_3.Name = "textBox_Input_3";
            this.textbox_Input_3.Size = new System.Drawing.Size(60, 30);
            this.textbox_Input_3.TabIndex = 3;
            this.textbox_Input_3.KeyPress += new KeyPressEventHandler(Input_Text);

            // 입력 - 층수
            //
            this.textbox_Input_4.Location = new System.Drawing.Point(110, 30);
            this.textbox_Input_4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textbox_Input_4.Multiline = true;
            this.textbox_Input_4.Name = "textBox_Input_4";
            this.textbox_Input_4.Size = new System.Drawing.Size(60, 30);
            this.textbox_Input_4.TabIndex = 4;
            this.textbox_Input_4.KeyPress += new KeyPressEventHandler(Input_Text);


            // 라벨 - 열관류율
            //

                    this.label_1.Location = new System.Drawing.Point(40, 38);
                    this.label_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.label_1.Name = "열관류율";
                    this.label_1.Size = new System.Drawing.Size(70, 30);
                    this.label_1.TabIndex = 5;
                    this.label_1.Text = "열관류율";
 


            // 라벨 - 연면적
            //
            this.label_2.Location = new System.Drawing.Point(40, 38);
                    this.label_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                    this.label_2.Name = "연면적";
                    this.label_2.Size = new System.Drawing.Size(70, 30);
                    this.label_2.TabIndex = 6;
                    this.label_2.Text = "연면적";
                 



            // 라벨 - 외피, 벽제창
            //
            this.label_3.Location = new System.Drawing.Point(40, 38);
                this.label_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.label_3.Name = "외피,벽제창";
                this.label_3.Size = new System.Drawing.Size(70, 30);
                this.label_3.TabIndex = 7;
                this.label_3.Text = "외피,벽제창";
          

            // 라벨 - 층수
            //
            this.label_4.Location = new System.Drawing.Point(40, 38);
                this.label_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
                this.label_4.Name = "층수";
                this.label_4.Size = new System.Drawing.Size(70, 30);
                this.label_4.TabIndex = 8;
                this.label_4.Text = "층수";
           


            // OK 버튼 - 열관류율
            //
            this.ok_Button.Location = new System.Drawing.Point(180, 30);
            this.ok_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_Button.Name = "OK";
            this.ok_Button.Size = new System.Drawing.Size(50, 30);
            this.ok_Button.TabIndex = 9;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(Ok_Button_Heat);

            // OK 버튼 - 연면적
            //
            this.ok_Button.Location = new System.Drawing.Point(180, 30);
            this.ok_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_Button.Name = "OK";
            this.ok_Button.Size = new System.Drawing.Size(50, 30);
            this.ok_Button.TabIndex = 10;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(Ok_Button_Volumn);

            // OK 버튼 - 외피, 벽제장
            //
            this.ok_Button.Location = new System.Drawing.Point(180, 30);
            this.ok_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_Button.Name = "OK";
            this.ok_Button.Size = new System.Drawing.Size(50, 30);
            this.ok_Button.TabIndex = 11;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(Ok_Button_Window);

            // OK 버튼 - 층수
            //
            this.ok_Button.Location = new System.Drawing.Point(180, 30);
            this.ok_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ok_Button.Name = "OK";
            this.ok_Button.Size = new System.Drawing.Size(50, 30);
            this.ok_Button.TabIndex = 12;
            this.ok_Button.Text = "OK";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(Ok_Button_Storey);

            this.Controls.Add(this.textbox_Input_1);
            this.Controls.Add(this.textbox_Input_2);
            this.Controls.Add(this.textbox_Input_3);
            this.Controls.Add(this.textbox_Input_4);
            this.Controls.Add(this.ok_Button);


            this.Controls.Add(this.label_1);
           
            this.Controls.Add(this.label_2);
           
            this.Controls.Add(this.label_3);
           
            this.Controls.Add(this.label_4);


            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Gbxml 속성 입력창";



            // Form3
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
        }


        public TextBox textbox_Input_1;
        public TextBox textbox_Input_2;
        public TextBox textbox_Input_3;
        public TextBox textbox_Input_4;


        private Button ok_Button;

        
        public Label label_1;
        public Label label_2;
        public Label label_3;
        public Label label_4;
        
        #endregion
    }
}