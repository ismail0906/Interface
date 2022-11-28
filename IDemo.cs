using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface
{
    public interface IDemo
    {

        // interface (arayüzler) => birden fazla yapıdan miras almamızı sağyalan yapılardır.. (multiple inheritance)

        // interfaceler soyut varlıklardır. sadece miras vermek için tanımlanır...

        // abstract classlara benzler ancak abstract yapılarda tek kalıtım, interfacelerde çoklu kalıtım yapılır...

        // interfacelerde field tanımlanamaz...
        // interface üyelerinin gövdeleri yazılamayabilir.. ( // 8.0 ile gövdeli üyeler tanımlanabilir

        public void Deneme() 
        {
            Console.WriteLine("Deneme");
        }

        public void Message();
    }

    public class Demo : IDemo 
    {
        public void Message() 
        {
            Console.WriteLine();
        }
    }
}
