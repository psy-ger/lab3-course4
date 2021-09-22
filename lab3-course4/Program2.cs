using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program2
{
    class Program2_class1
    {
        public int x_int;
        public int n_int;
        public int sum_num;
        public int sum_demo;
        public int sum_full;
        public int sum_full_formula;
        public string Enter_X_N()
        {
            x_int = Convert.ToInt32(Console.ReadLine());
            n_int = Convert.ToInt32(Console.ReadLine());
            return "";
        }
        public string  formula_num()
        { 
            sum_num = Convert.ToInt32(Math.Pow(x_int, 2 * n_int + 1));
            return "";
        }
        public string formula_demo()
        {
            sum_demo = Convert.ToInt32(4 * Math.Pow(n_int, 2) - 1);
            return "";
        }
        public string formula_full()
        {
            sum_full = sum_num / sum_demo;
            return Convert.ToString(sum_full);
        }
        public string formula_full_program()
        {
            for (int i = 0; i < n_int; i++)
            {
                sum_full_formula += sum_full;

            }
            return Convert.ToString(sum_full_formula);
        }
        
    }
    class Program2_class2 : Program2_class1
    {
        public int sum_num_demo;
        public int sum_arctng;
        public int sum_formula_full2;
        public string formula_num_demo()
        {
            sum_num_demo = Convert.ToInt32((1 + Math.Pow(x_int, 2))/2);
            return Convert.ToString(sum_num_demo);
        }
        public string formula_arctng_x()
        {
            sum_arctng = Convert.ToInt32(Math.Atan(x_int) - (x_int / 2));
            return Convert.ToString(sum_arctng);
        }
        public string formula_full2()
        {
            sum_formula_full2 = sum_num_demo * sum_arctng;
            return Convert.ToString(sum_formula_full2);
        }
    }
    class Program2_class3 : Program2_class2
    {
        public int t_int;
        public string formula_t()
        {
            t_int = Convert.ToInt32((Math.Abs(sum_full_formula - sum_formula_full2) / sum_formula_full2) * 100);
            return Convert.ToString(t_int);
        }
    }

}
