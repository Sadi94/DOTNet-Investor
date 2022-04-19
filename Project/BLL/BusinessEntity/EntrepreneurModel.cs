using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessEntity
{
    public class EntrepreneurModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Message { get; set; }
        public Nullable<int> inId { get; set; }

        public virtual PostModel Post { get; set; }
        public virtual PaymentModel Payment { get; set; }
    }
}
