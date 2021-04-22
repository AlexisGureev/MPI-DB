using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPI_DB.Data
{
    public partial class SkdGeolage
    {
        public string FullAge
        {
            get
            {
                Stack<string> buf = new Stack<string>();
                SkdGeolage cur = this;
                do
                {
                    buf.Push(cur.Name);
                    cur = cur.Parent;
                } while (cur != null);
                return string.Join(" > ", buf);
            }
        }

    }
}
