using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1_lotto
{
    class Lotto
    {
        List<int> row = new Row <int>();

        public void Row()
        {
            Random rand = new Random();
            int number = rand.Next(1, 39 + 1);
        }
    }
}
