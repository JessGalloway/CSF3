using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCPayroll
{
    // class : class is inheritance interface : interface is inheritance 
    //class : interface is implementation
    public interface IDirectDepositable : IPayable
    {
        //from inheritance we get:
        //GetNameForPayCheck();
        //GetPayCheckAmount();
        string GetBankingInfo();
        
        
        
    }
}
