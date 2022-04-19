using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessEntity
{
    public class CommnetModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public Nullable<int> Pid { get; set; }
        public string Name { get; set; }

    }
}
