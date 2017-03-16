using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1_lotto
{
    class Rows
    {
        private List<Rows> rows;

        public Rows()
        {
            rows = new List<Rows>();
        }

        public void AddPerson(Rows row)
        {
            rows.Add(row);
        }
    }
}
