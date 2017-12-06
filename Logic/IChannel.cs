using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IChannel
    {
        void Next();
        void Previous();
        void SetChannel(int channel);
    }
}
