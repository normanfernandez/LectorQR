using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LectorQRv2.MATLAB
{
    public class Execute
    {
        public void run() {
            Type MatlabType = Type.GetType("Matlab.Application");
            
            dynamic MatlabInstance = Activator.CreateInstance(MatlabType);
            MatlabInstance.Visible = true;
        }
    }
}
