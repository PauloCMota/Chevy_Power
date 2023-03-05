using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diametro_Curso;

namespace Chevy_Power 
{
    public class cil_inch
    { 
        
        static void Main(string[] args) 
        {
            Bore_stroker sb1 = new Bore_stroker();
            double result = sb1.Engines(4.125, 3.750, 0.7854 , 8);
            Console.WriteLine("Chevy Engines = {0}" ,result);

        }
    
    }

}
