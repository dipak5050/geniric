using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geniric
{
    public class PromptPanCustomer<T>
    {
        public T value { get; set; }
        public DateTime datetime { get; set; }

    }

    public class PromptPanProducttName<T>
    {
        public T value { get; set; }
        public DateTime datetime { get; set; }

    }

    public class PromptPanProductTypeName<T>
    {
        public T value { get; set; }
        public DateTime datetime { get; set; }

    }

    public class PromptPanbill<T>
    {
        public T value { get; set; }
        public DateTime datetime { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            PromptPanCustomer<int> pc  = new PromptPanCustomer<int>();
            pc.value = 1;
            Console.WriteLine(pc.value);

            PromptPanCustomer<string> pn = new PromptPanCustomer<string>();
            pn.value ="dipu";
            Console.WriteLine(pn.value);

            PromptPanCustomer<DateTime> pd = new PromptPanCustomer<DateTime>();






            PromptPanProducttName<int> ppi = new PromptPanProducttName<int>();
            ppi.value = 1;
            Console.WriteLine(ppi.value);

            PromptPanProducttName<string> ppn = new PromptPanProducttName<string>();
            ppn.value = "GFL";
            Console.WriteLine(ppn.value);
            

            PromptPanProducttName<int> ptid = new PromptPanProducttName<int>();
            ptid.value = 1;
            Console.WriteLine(ptid.value);

            PromptPanProducttName<float> ptnrs = new PromptPanProducttName<float>();
            ptnrs.value = 1;
            Console.WriteLine(ptid.value);

            PromptPanProducttName<DateTime> pnd = new PromptPanProducttName<DateTime>();




            PromptPanProductTypeName<int> pti = new PromptPanProductTypeName<int>();
            pti.value = 1;
            Console.WriteLine(pti.value);

            PromptPanProductTypeName<string> ptnm = new PromptPanProductTypeName<string>();
            ptnm.value ="cigrate";
            Console.WriteLine(ptnm.value);

            PromptPanProductTypeName<DateTime> ptd = new PromptPanProductTypeName<DateTime>();




            PromptPanbill<int> pbid = new PromptPanbill<int>();
            pbid.value = 1;
            Console.WriteLine(pbid.value);

            PromptPanbill<int> pbcid = new PromptPanbill<int>();
            pbcid.value = 1;
            Console.WriteLine(pbcid.value);

            PromptPanbill<int> pbtid = new PromptPanbill<int>();
            pbtid.value = 1;
            Console.WriteLine(pbtid.value);

            PromptPanbill<int> pbnid = new PromptPanbill<int>();
            pbnid.value = 1;
            Console.WriteLine(pbnid.value);

            PromptPanbill<DateTime> pbtd = new PromptPanbill<DateTime>();

            Console.ReadKey();
        }

    }
}
