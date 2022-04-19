using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IPayment<T, ID>
    {
        List<T> Get();

    }
}
