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
    public partial class Form3 : Form
    {
        string[] property = { "열관류율", "연면적", "외피, 벽제창", "층수" };
  

        public Form3()
        {
            InitializeComponent();
        }


        private void Input_Text(object sender, KeyPressEventArgs e)
        {
            try
            {
                //숫자,백스페이스,마이너스,소숫점 만 입력받는다.
                if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 46) //8:백스페이스,45:마이너스,46:소수점
                {
                    e.Handled = true;
                }
            }

            catch
            {
                MessageBox.Show("숫자만 입력하세요.");
            }
        }


        public void Ok_Button_Heat(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2(this))
            {
                ((Form2)(this.Owner)).textBox_1.Text = this.getText_Heat();
                form2.Close();
            }
        }

        public void Ok_Button_Volumn(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2(this))
            {

                ((Form2)(this.Owner)).textBox_2.Text = this.getText_Volumn();
                Close();
            }
        }

        public void Ok_Button_Window(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2(this))
            {

                ((Form2)(this.Owner)).textBox_3.Text = this.getText_Window();
                Close();
            }
        }

        public void Ok_Button_Storey(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2(this))
            {

                ((Form2)(this.Owner)).textBox_4.Text = this.getText_Storey();
                Close();
            }
        }

        public string getText_Heat()
        {
            return this.textbox_Input_1.Text;
        }

        public string getText_Volumn()
        {
            return this.textbox_Input_2.Text;
        }

        public string getText_Window()
        {
            return this.textbox_Input_3.Text;
        }

        public string getText_Storey()
        {
            return this.textbox_Input_4.Text;
        }

        private TextBox textbox3;

    }
}
