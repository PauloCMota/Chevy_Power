using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Diametro_Curso
{
    public class Bore_stroker
    {
        private double bore { get; set; }
        private double stroke { get; set; }
        private double constant { get; set; }
        private double num_cil { get; set; }

        public void Setbore(double b1)
        {
            this.bore = b1  ;
        }
        public double GetBore()
        {
            return this.bore;
        }
        public void Setstroke(double s1)
        {
            this.stroke = s1;
        }
        public double Getstroke()
        {
            return this.stroke;
        }
        public void Setconstant(double c1)
        {
            this.constant = c1;
        }
        public double Getconstant()
        {
            return this.constant;
        }
        public void Setnum_cil(double nc1)
        {
            this.bore = nc1;
        }
        public double Getnum_cil()
        {
            return this.num_cil;
        }
        public double Engines(double b1, double s1 ,double c1 , double nc1 )
        {
            double Math_Engines = 0;
            this.bore = b1*b1 ; this.stroke = s1; this.constant = c1; this.num_cil = nc1;
            Math_Engines = this.bore * this.stroke * this.constant * this.num_cil;
            return Math_Engines;
        }
    }
}