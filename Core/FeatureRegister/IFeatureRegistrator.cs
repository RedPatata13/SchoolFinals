using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finals.Core;
using Finals.Forms;

namespace Finals.Core.FeatureRegister
{
    public interface IFeatureRegistrator
    {
        IFeature Home { get; }
        void RegisterFeatures(IInterfaceFrame frame);
    }
}
