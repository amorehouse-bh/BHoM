/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System.ComponentModel;
using BH.oM.Analytical.Results;
using BH.oM.Geometry;
using System.Collections.Generic;
using BH.oM.Base;
using System.Collections.ObjectModel;
using System;
using System.Linq;

namespace BH.oM.Lighting.Results.Mesh
{
    [Description("Full collection of discrete results for an AnalysisGrid for a specific Analysis.")]
    public class MeshResult : IMeshResult<MeshElementResult>, IObjectIdResult, ICasedResult, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("ID of the AnalysisGrid that this result collection belongs to")]
        public virtual IComparable ObjectId { get; } = "";

        [Description("Identifier for the Analysis Case that the result belongs to. Is generally name or number of the analysis")]
        public virtual IComparable ResultCase { get; } = "";

        [Description("A collection of the discrete mesh element results per node")]
        public virtual IReadOnlyList<MeshElementResult> Results { get; }

        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        public MeshResult(IComparable objectId, IComparable resultCase, IEnumerable<MeshElementResult> results)
        {
            ObjectId = objectId;
            ResultCase = resultCase;
            Results = results == null ? null : new ReadOnlyCollection<MeshElementResult>(results.ToList());
        }

        /***************************************************/
        /**** IComparable Interface                     ****/
        /***************************************************/

        public int CompareTo(IResult other)
        {
            MeshResult otherRes = other as MeshResult;

            if (otherRes == null)
                return this.GetType().Name.CompareTo(other.GetType().Name);


            int n = this.ObjectId.CompareTo(otherRes.ObjectId);
            if (n == 0)
            {
                return this.ResultCase.CompareTo(otherRes.ResultCase);
            }
            else
            {
                return n;
            }
        }

        /***************************************************/

    }
}




