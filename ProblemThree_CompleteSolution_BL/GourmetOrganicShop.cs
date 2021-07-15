using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop , ITaxCompute
    {
        public double TaxBillValue { get; set; }

        public GourmetOrganicShop(int iCode, string iName, Dictionary<int, double> iPrice) : base(iCode, iName)
        {
            
        }

        public override double PayPerPiece(int quantity)
        {
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
