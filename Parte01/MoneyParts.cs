using System.Collections.Generic;
using System.Linq;

namespace Parte01
{
    public class MoneyParts
    {
        static List<decimal> moneyParts = new List<decimal> { 0.05m, 0.1m, 0.2m, 0.5m, 1m, 2m, 5m, 10m, 20m, 50m, 100m, 200m };

        public static List<List<decimal>> Build(string monto)
        {
            List<List<decimal>> ListOfGroups = new();

            decimal mnt = 0;

            if (!decimal.TryParse(monto, out mnt))
            {
                return ListOfGroups;
            }

            foreach (decimal data in moneyParts)
            {
                List<decimal> decimals = new();
                int index = moneyParts.IndexOf(data);
                do
                {
                    decimals.Add(moneyParts[index]);
                    if (decimals.Sum() > mnt)
                    {
                        decimals.RemoveAt(decimals.Count - 1);
                        index--;
                    }
                    if (index == -1) break;
                    if (decimals.Sum() == mnt)
                    {
                        ListOfGroups.Add(decimals);
                        break;
                    }
                }
                while (true);
            }
            return ListOfGroups;
        }
    }
}