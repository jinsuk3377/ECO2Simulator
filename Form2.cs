using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADR2013AppCS01
{
    public  partial class Form2 : Form
    {
        Form3 form3 = new Form3();
      //  Form1 form1 = new Form1();
        string[] property = { "연면적", "열관류율", "외피, 벽제창", "층수" };
        string str = "";

        public Form2()
        {
            InitializeComponent();
        }
        
        public Form2(Form3 form3)       // form2에서 form3를 사용하기 위해
        {
            this.form3 = form3;
            InitializeComponent();
        }
         
        private void Submit_Button(object sender, EventArgs e)
        {
            try
            {
                using (Form1 form1 = new Form1())
                {

                    foreach (string prop in property)
                    {
                        //  MessageBox.Show("adfadfadf");
                        if (prop.Contains("연면적"))
                            str = str + "Name: " + this.getName + Environment.NewLine;
                    }

                    form1.textBox1.Text = str;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    
        private void Mouse_Click_Heat(object sender, EventArgs e)
        {
            try
            {
                using (Form3 form3 = new Form3())
                {
                    DialogResult result = form3.ShowDialog(this);


                    if (result == DialogResult.Cancel)
                    {
                        form3.Close();
                    }
                    else if (result == DialogResult.OK)
                    {
                        form3.label_1.Text = comboBox_1.Text;
                    }
                }

            }

            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void Mouse_Click_Volumn(object sender, EventArgs e)
        {
            try
            {
                using (Form3 form3 = new Form3())
                {
                    DialogResult result = form3.ShowDialog(this);


                    if (result == DialogResult.Cancel)
                    {
                        form3.Close();
                    }
                    else if (result == DialogResult.OK)
                    {
                    
                    }
                }

            }

            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void Mouse_Click_Window(object sender, EventArgs e)
        {
            try
            {
                using (Form3 form3 = new Form3())
                {
                    DialogResult result = form3.ShowDialog(this);


                    if (result == DialogResult.Cancel)
                    {
                        form3.Close();
                    }
                    else if (result == DialogResult.OK)
                    {
                        // form3.textbox_Input_3.Text = form3.getText();
                        
                
                       // form3.Close();
                    }
                }

            }

            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
        }

        private void Mouse_Click_Storey(object sender, EventArgs e)
        {
            try
            {
                using (Form3 form3 = new Form3())
                {
                    DialogResult result = form3.ShowDialog(this);


                    if (result == DialogResult.Cancel)
                    {
                        form3.Close();
                    }
                    else if (result == DialogResult.OK)
                    {
                        // form3.textbox_Input_4.Text = form3.getText();
                        form3.label_4.Visible = true;
                        form3.label_3.Visible = false;
                       
                        //form3.Close();
                    }
                }

            }

            catch (Exception io)
            {
                MessageBox.Show(io.Message);
            }
        }
       

        public string[] getName
        {
            get
           {
              return property;
           }
        }
      
        /**
        public string[] getValue
        {
            get
            {
                return value;
            }
        }
    */
        public string getText()
        {
            return textbox2.Text;
        }

        private TextBox textbox2;

        public Label label_1;
        public Label label_2;
        public Label label_3;
        public Label label_4;
    }
}
