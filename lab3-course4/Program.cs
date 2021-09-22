using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program2;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Program2_class1 class_call1 = new Program2_class1();
            Console.WriteLine(class_call1.Enter_X_N());
            Console.WriteLine(class_call1.formula_num());
            Console.WriteLine(class_call1.formula_demo());
            Console.WriteLine(class_call1.formula_full());
            Console.WriteLine(class_call1.formula_full_program());
            Console.WriteLine(class_call1.formula_num_demo());
            Console.WriteLine(class_call1.formula_arctng_x());
            Console.WriteLine(class_call1.formula_full2());
            Console.WriteLine(class_call1.formula_t());
        }

    }
}