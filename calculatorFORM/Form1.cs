using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorFORM
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            int top;
            int left;

            TextBox tb = new TextBox();
            tb.Multiline=true;
            tb.Left=10;
            tb.Top=10;
            tb.Size = new Size(245, 45);
            this.Controls.Add(tb);

            top = 60;
            left = 10;
            //int[] name = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            string[][] numbers = new string[5][];
            numbers[0] = new string[] { "7", "4", "1", "0" };
            numbers[1] = new string[] { "8", "5", "2" };
            numbers[2] = new string[] { "9", "6", "3", "." };
            numbers[3] = new string[] { "/", "*", "-", "+" };
            numbers[4] = new string[] { "CE", "C", "=" };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    for (int a = 0; a < 1; a++)
                    switch (numbers[i][j])
                    {
                        case "0":
                            Button zero = new Button();
                            zero.Click += button_Click;
                            zero.Text = numbers[i][j];
                            zero.Left = 10;
                            zero.Top = 200;
                            zero.Size = new Size(95, 45);
                            this.Controls.Add(zero);
                            break;
                        case "=":
                            Button equally = new Button();
                            equally.Text = numbers[i][j];
                            equally.Left = 210;
                            equally.Top = 155;
                            equally.Size = new Size(45, 90);
                            this.Controls.Add(equally);
                            break;
                        default:
                            Button button = new Button();
                            //button.Click += new System.EventHandler(button_Click);
                            button.Click += button_Click;

                            button.Text = numbers[i][j];
                            button.Left = left;
                            button.Top = top;
                            button.Size = new Size(45, 45);
                            this.Controls.Add(button);
                            top += button.Height + 2;
                            break;
                    }
                    
                }
                top = 60;
                left += 50;
            }
        }

        public static void button_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            Button b = (Button)sender;
            //this.tb.Text += 1;
        }
    }
}
