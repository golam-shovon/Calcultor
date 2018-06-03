using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form

    {
        
        
        double val1, val2, res,mem;
     
        string y;
        bool n;
        
        List<string> hs = new List<string>();
        int i = 0;




        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_9_MouseClick(object sender, MouseEventArgs e)
        {
           




        }

        private void Button_7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "7";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "7";
            }
            n = true;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "8";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "8";
            }
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "4";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "4";
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "1";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "2";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "2";
            }
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "3";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "3";
            }
        }

        private void button_Point_Click(object sender, EventArgs e)
        {
            n = true;
            bool t = textBox2.Text.Contains('.');
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {
                if (t == true)
                {
                    //textBox2.Text = "";
                }

            }
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                if (t == false)
                {
                    textBox2.Text = ".";
                }
            }

            else if (t == false)
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + ".";
            }
            else if (t == true)
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void button_C_Click(object sender, EventArgs e)
        { 
            try
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);

            }
            catch(Exception ex)
            {

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void button_Mul_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(textBox2.Text);
            textBox1.Text = textBox2.Text;
            textBox2.Text = "*";
            y = "*";
            }
            catch(System.FormatException)
            {

            }

            


        }

        private void button_6_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "6";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "6";
            }
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            try
            {

             val2 = Convert.ToDouble(textBox2.Text);
            if (y.Contains('*'))
            {
                res = val1 * val2;
                textBox2.Text = Convert.ToString(res);
                textBox1.Text = string.Empty;

                hs.Add(Convert.ToString(val1) + "*" + Convert.ToString(val2) + "=" + Convert.ToString(res));
                y = string.Empty;


            }
            if (y.Contains('-'))
            {
                res = val1 - val2;
                textBox2.Text = Convert.ToString(res);
                textBox1.Text = string.Empty;
                hs.Add(Convert.ToString(val1) + "-" + Convert.ToString(val2) + "=" + Convert.ToString(res));
                y = string.Empty;

            }
            if (y.Contains('+'))
            {
                res = val1 + val2;
                textBox2.Text = Convert.ToString(res);
                textBox1.Text = string.Empty;
                hs.Add(Convert.ToString(val1) + "+" + Convert.ToString(val2) + "=" + Convert.ToString(res));
                y = string.Empty;

            }
            if (y.Contains('/'))
            {
                res = val1 / val2;
                textBox2.Text = Convert.ToString(res);
                textBox1.Text = string.Empty;
                hs.Add(Convert.ToString(val1) + "/" + Convert.ToString(val2) + "=" + Convert.ToString(res));
                y = string.Empty;

            }
            if (String.IsNullOrEmpty(y))
            {

            }
            }
            catch(Exception ex)
            {

            }
            



        }

        private void button_Sub_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(textBox2.Text);
                textBox1.Text = textBox2.Text;
                textBox2.Text = "-";
                y = "-";

            }
            catch (System.FormatException)
            {

            }

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(textBox2.Text);
            textBox1.Text = textBox2.Text;
            textBox2.Text = "+";
            y = "+";

            }
            catch(System.FormatException)
                {

            }



        }

        private void button_DIv_Click(object sender, EventArgs e)
        {
            try
            {
                val1 = Convert.ToDouble(textBox2.Text);
            textBox1.Text = textBox2.Text;
            textBox2.Text = "/";
            y = "/";

            }
            catch (System.FormatException)
            {

                
            } 
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "9";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "9";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          
            
                textBox2.Text = Convert.ToString(mem);
           
          

        }

        private void button_MC_Click(object sender, EventArgs e)
        {
            mem = 0;
            val1 = 0;
            val2 = 0;
            res = 0;


        }

        private void button_MADD_Click(object sender, EventArgs e)
            

        {
            try
            {
                val2 = Convert.ToDouble(textBox2.Text);
                res = val2 + mem;
                textBox2.Text=Convert.ToString(res);
                textBox1.Text = string.Empty;
                hs.Add(Convert.ToString(mem) + "+" + Convert.ToString(val2) + "=" + Convert.ToString(res));


            }
            catch(Exception ex)
            {

            }
            


        }

        private void button_MSUB_Click(object sender, EventArgs e)
        {
            try
            {
                val2 = Convert.ToDouble(textBox2.Text);
                res = val2 - mem;
                textBox2.Text = Convert.ToString(res);
                textBox1.Text = string.Empty;
                hs.Add(Convert.ToString(mem) + "-" + Convert.ToString(val2) + "=" + Convert.ToString(res));

            }
            catch (Exception ex)
            {

            }
            

        }



        private void button_HS_Click(object sender, EventArgs e)
        {
            if (n == true)
            {
                try
                {
                    if (hs.Count == 1)
                {
                    textBox2.Text = hs[hs.Count - 1];
                    n = false;
                    
                      
                }
                i = 0;
                i++;
                textBox2.Text = hs[hs.Count - i];
                if(hs.Count-i==0)
                {
                    textBox2.Text = hs[hs.Count];
                        n = false;
                }
                n = false;

                }
                catch(System.ArgumentOutOfRangeException)
                {

                }
                
            }
            if (n == false)
            {
                try
                {
                    i++;

                    textBox2.Text = hs[hs.Count - i+1];

                }
                catch(System.ArgumentOutOfRangeException)
                {

                }

                

            }




        }

        private void button13_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "0";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "0";
            }
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            n = true;
            if (String.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Contains('*') || textBox2.Text.Contains('/') || textBox2.Text.Contains('+') || textBox2.Text.Contains('-'))
            {

                textBox2.Text = "5";

            }

            else
            {
                string s1 = textBox2.Text;
                textBox2.Text = s1 + "5";
            }
        }

        private void button_MS_Click(object sender, EventArgs e)
        {
            try
            {
                 mem=Convert.ToDouble(textBox2.Text);
                 textBox1.Text = string.Empty;
                 textBox2.Text = string.Empty;
                
            }
            catch (Exception ex)
            {
 
            }
        }
    
    }



}
