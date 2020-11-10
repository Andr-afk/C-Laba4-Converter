using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using developingClasses;

namespace PNumDer
{
    public partial class Form1 : Form
    {

        Cntrl edit = new Cntrl();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            EnableButton();

            ValueNumber.Text = edit.Number;
        }


        private void UD_baseValue_ValueChanged(object sender, EventArgs e)
        {
            EnableButton();
            Do_translate();
        }



        private void btnBackspace_Click(object sender, EventArgs e) // обработка нажатий на кнопки
        {
            try
            {
                Button b = (sender as Button);
                byte pressed_button = Convert.ToByte(b.TabIndex);
                ValueNumber.Text = edit.DoEdit(pressed_button);
                Do_translate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void Do_translate()
        {
            string base_value = Convert.ToString(UD_baseValue.Value);
            string res_base = Convert.ToString(UD_needBaseValue.Value);
            string accuracy = Convert.ToString(UD_accuracy.Value);

            tb_result.Text = edit.Converter(base_value, res_base, accuracy);
        }

        private void EnableButton()
        {
            foreach (Control value in Controls)
            {
                if (value is Button && Convert.ToString(value.Tag) == "number")
                {
                    if (value.TabIndex >= UD_baseValue.Value) value.Enabled = false;
                    else value.Enabled = true;
                }
            }
        }

        private void UD_needBaseValue_ValueChanged(object sender, EventArgs e)
        {
            Do_translate();
        }

        private void UD_accuracy_ValueChanged(object sender, EventArgs e)
        {
            Do_translate();
        }
    }


}
