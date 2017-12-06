using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IDimmer
    {
        void Upper();
        void Lower();
        void SetDegree(int value);
        int GetDegree();
    }
}
