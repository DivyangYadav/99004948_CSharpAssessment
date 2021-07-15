using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetCoffeeShop : GourmetShop , ITaxCompute
    {
        double TotalBillValue { get; set; }

        public GourmetCoffeeShop(int iCode, string iName, Dictionary<int, double> iPrice)
        {

        }

        public override double PayPerPiece(int quantity)
        {
            // This method
            return 0.0;
        }

        public override double PayPerWeight(int weight)
        {
            return 0.0;
        }

        public double TaxOnTotalBill()
        {
            throw new NotImplementedException();
        }
    }
}
