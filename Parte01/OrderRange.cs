using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte01
{
    public class OrderRange
    {
        public static List<List<int>> Build(List<int> lista)
        {
            List<List<int>> rpta = new();
            List<int> par = new();
            List<int> impar = new();
            foreach (var a in lista)
            {
                if ((a % 2) == 0) par.Add(a); else impar.Add(a);
            }
            par.Sort();
            impar.Sort();
            rpta.Add(par);
            rpta.Add(impar);
            return rpta;
        }
    }
}
