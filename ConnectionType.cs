using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clusterization_algorithms
{
    enum ConnectionType
    {
        DT_to_Center, //direct transmittion, send to center of cluster (station static position)
        DT_to_Route, // *to closer point on station route
        PP_to_Center, // Point to point
        PP_to_Route
    }

    enum ClusterizationType
    {
        K_means,
        Forel
    }
}
