using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessEntity
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<int> eid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DAL.Database.Commnet> Commnets { get; set; }
        public virtual EntrepreneurModel Entrepreneur { get; set; }
    }
}
