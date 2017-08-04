﻿using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.Structural.Loads
{
    /// <summary>
    /// Interface implemented by all loading related classes
    /// </summary>
    public interface ILoad : IObject        
    {
        LoadType GetLoadType();

        /// <summary>Loadcase as BHoM object</summary>
        BH.oM.Structural.Loads.Loadcase Loadcase { get; set; }

        LoadAxis Axis { get; set; }

        bool Projected { get; set; }
    }
}
