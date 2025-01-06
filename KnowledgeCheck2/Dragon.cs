using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class Dragon
    {
        public string Color {  get; set; }

       
    }

    public class Wyvern : Dragon
    {
        public int NumHorn { get; set; }


        public override string ToString()
        {
            return "Dragon Color: " + Color + "\n" + "Dragon Horns: " + NumHorn;
        }
    }






}
