using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program2
{
    class Program2_class1
    {
        public double x_int;
        public double n_int;
        public int sing_int;
        public double t_int;
        public double answer;
        public double sum_num;
        public double sum_demo;
        public double sum_full;
        public double sum_num_demo;
        public double sum_arctng;
        public double sum_arctng_full;
        public double sum_formula_full2;
        public double sum_full_formula;
        public string Enter_X_N()
        {
            Console.WriteLine("Значение Х = ");
            x_int = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Значение N = ");
            n_int = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Кол-во знаков после запятой = ");
            sing_int = Convert.ToInt32(Console.ReadLine());
            return "";
        }
        public string  formula_num()
        { 
            sum_num = Convert.ToDouble(Math.Pow(x_int, 2 * n_int + 1));
            //Console.WriteLine(sum_num);
            return "";
        }
        public string formula_demo()
        {
            sum_demo = Convert.ToDouble((4 * Math.Pow(n_int, 2)) - 1);
            //Console.WriteLine(sum_demo);
            return "";
        }
        public string formula_full()
        {
            sum_full = sum_num / sum_demo;
            //Console.WriteLine(sum_full);
            return "";
        }
        public string formula_full_program()
        {
            for (int i = 0; i < n_int; i++)
            {
                sum_full_formula += sum_full;

            }
            Console.WriteLine("Ряд = " + sum_full_formula);
            return "";
        }
        public string formula_num_demo()
        {
            sum_num_demo = (1 + Math.Pow(x_int, 2)) / 2;
            //Console.WriteLine(sum_num_demo);
            return "";
        }
        public string formula_arctng_x()
        {          
            sum_arctng = Math.Atan(x_int) - (x_int/2);
            return "";
        }
        public string formula_full2()
        {
            sum_formula_full2 = sum_num_demo * sum_arctng;
            Console.WriteLine("Точное значение = " + sum_formula_full2);
            return "";
        }
        public string formula_t()
        {
            t_int = (Math.Abs(sum_full_formula - sum_formula_full2) / sum_formula_full2) * 100;
            Console.WriteLine("Ответ Т = " + Math.Round(Convert.ToDecimal(t_int), sing_int));
            return "";
        }

    }
    

}
