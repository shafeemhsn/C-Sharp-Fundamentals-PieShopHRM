using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    //public record Account
    //{
    //    private string accountName;

    //    public string AccountNumber
    //    {
    //        get { return accountName; }
    //        set { accountName = value; }
    //    }
    //}

    public record Account(string AccountNumber);
}
