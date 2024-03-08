using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class ConversorDeMoeda {

        public static double IOF = 6.0;
        public static double DolarParaReal(double cotacao, double quantidade) {
            return (cotacao * quantidade) * IOF/100;
        }
    }
}
