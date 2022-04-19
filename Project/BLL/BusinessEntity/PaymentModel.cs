using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessEntity
{
    public class PaymentModel
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public Nullable<int> Eid { get; set; }
        public Nullable<int> Iid { get; set; }

        
    }
}
