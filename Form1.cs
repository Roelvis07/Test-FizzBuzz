using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fizzBuzz(15);
        }
        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                bool tres = false;
                bool cinco = false;

                if (i % 3 == 0) tres = true;
                if (i % 5 == 0) cinco = true;

                if (!tres && !cinco) Console.WriteLine(i);
                if (tres && cinco) Console.WriteLine("FizzBuzz");
                if (tres && !cinco) Console.WriteLine("Fizz");
                if (!tres && cinco) Console.WriteLine("Buzz");
            }
        }
    }
}
