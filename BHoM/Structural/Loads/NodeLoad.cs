﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Base;
using BH.oM.Geometry;
using BH.oM.Structural.Elements;

namespace BH.oM.Structural.Loads
{
    /// <summary>
    /// Nodal load class. Use NodalLoad() to construct an empty instance, then use the Set methods to set forces, moments etc. A second
    /// constructor allows for a default force and moment nodal load instance.
    /// </summary>
    public class PointForce : Load<Node> //TODO: one class per file
    {
        /// <summary>Force - fx, fy, fz defined as a BH.oM.Geometry.Vector</summary>
        public BH.oM.Geometry.Vector Force { get;  set; }

        /// <summary>Moment - mx, my, mz defined as a BH.oM.Geometry.Vector</summary>
        public BH.oM.Geometry.Vector Moment { get;  set; }

        public override LoadType GetLoadType()
        {
            return LoadType.PointForce;
        }
        /// <summary>
        /// Create an empty nodal load as a placeholder
        /// </summary>
        public PointForce() { }

        /// <summary>
        /// Create a new nodal load containing forces and moments. This is the only constructor that sets the nodal force
        /// values. For all other nodal load types (displacement, velocity etc) use the relevant Set method.
        /// </summary>
        /// <param name="loadcase"></param>
        /// <param name="fx"></param>
        /// <param name="fy"></param>
        /// <param name="fz"></param>
        /// <param name="mx"></param>
        /// <param name="my"></param>
        /// <param name="mz"></param>
        public PointForce(BH.oM.Structural.Loads.Loadcase loadcase, double fx, double fy, double fz, double mx, double my, double mz)
        {
            this.Loadcase = loadcase;
            this.Force = new Vector(fx, fy, fz);
            this.Moment = new Vector(mx, my, mz);
        }

        /// <summary>
        /// Set the forces of a nodal load
        /// </summary>
        /// <param name="fx"></param>
        /// <param name="fy"></param>
        /// <param name="fz"></param>
        public void SetForce(double fx, double fy, double fz)
        {
            this.Force = new Vector(fx, fy, fz);
        }

        /// <summary>
        /// Set the moments of a nodal load
        /// </summary>
        /// <param name="mx"></param>
        /// <param name="my"></param>
        /// <param name="mz"></param>
        public void SetMoment(double mx, double my, double mz)
        {
            this.Moment = new Vector(mx, my, mz);
        }
    }
    /// <summary>
    /// Point Displacement class
    /// </summary>
    public class PointDisplacement : Load<Node>
    {
        /// <summary>Translation - tx, ty, tz defined as a BH.oM.Geometry.Vector</summary>
        public BH.oM.Geometry.Vector Translation { get; set; }

        /// <summary>Rotation - rx, ry, rz defined as a BH.oM.Geometry.Vector</summary>
        public BH.oM.Geometry.Vector Rotation { get; set; }
        
        /// <summary>Stores a load record number specific to Robot</summary>
        public int RobotLoadRecordNumber { get; private set; }
      
        /// <summary>
        /// Create an empty nodal load as a placeholder
        /// </summary>
        public PointDisplacement() { }

        public override LoadType GetLoadType()
        {
            return LoadType.PointDisplacement;
        }
        /// <summary>
        /// Create a new nodal load containing forces and moments. This is the only constructor that sets the nodal force
        /// values. For all other nodal load types (displacement, velocity etc) use the relevant Set method.
        /// </summary>
        /// <param name="loadcase"></param>
        /// <param name="fx"></param>
        /// <param name="fy"></param>
        /// <param name="fz"></param>
        /// <param name="mx"></param>
        /// <param name="my"></param>
        /// <param name="mz"></param>
        public PointDisplacement(BH.oM.Structural.Loads.Loadcase loadcase, double tx, double ty, double tz, double rx, double ry, double rz)
        {
            this.Loadcase = loadcase;
            this.Translation = new Vector(tx, ty, tz);
            this.Rotation = new Vector(rx, ry, rz);
        }
    }

    /// <summary>
    /// Point Velocity class
    /// </summary>
    public class PointVelocity : Load<Node>
    {
        /// <summary>TranslationalVelocity - vx, vy, vz defined as a BH.oM.Geometry.Vector</summary>
        public BH.oM.Geometry.Vector TranslationalVelocity { get; set; }

        /// <summary>RotationalVelocity - vrx, vry, vrz defined as a BH.oM.Geometry.Vector</summary>
        public BH.oM.Geometry.Vector RotationalVelocity { get; set; }

        /// <summary>Stores a load record number specific to Robot</summary>
        public int RobotLoadRecordNumber { get; private set; }
        
        /// <summary>
        /// Create an empty nodal load as a placeholder
        /// </summary>
        public PointVelocity() { }

        public override LoadType GetLoadType()
        {
                return LoadType.PointVelocity;
        }
        /// <summary>
        /// Create a new nodal load containing forces and moments. This is the only constructor that sets the nodal force
        /// values. For all other nodal load types (displacement, velocity etc) use the relevant Set method.
        /// </summary>
        /// <param name="loadcase"></param>
        /// <param name="fx"></param>
        /// <param name="fy"></param>
        /// <param name="fz"></param>
        /// <param name="mx"></param>
        /// <param name="my"></param>
        /// <param name="mz"></param>
        public PointVelocity(BH.oM.Structural.Loads.Loadcase loadcase, double vx, double vy, double vz, double vrx, double vry, double vrz)
        {
            this.Loadcase = loadcase;
            this.TranslationalVelocity = new Vector(vx, vy, vz);
            this.RotationalVelocity = new Vector(vrx, vry, vrz);
        }
    }

    /// <summary>
    /// Point Acceleration class
    /// </summary>
    public class PointAcceleration : Load<Node>
    {
        /// <summary>TranslationalAcceleration - ax, ay, az defined as a BH.oM.Geometry.Vector</summary>
        public BH.oM.Geometry.Vector TranslationalAcceleration { get; set; }

        /// <summary>RotationalAcceleration - arx, ary, arz defined as a BH.oM.Geometry.Vector</summary>
        public BH.oM.Geometry.Vector RotationalAcceleration { get; set; }

        /// <summary>Stores a load record number specific to Robot</summary>
        public int RobotLoadRecordNumber { get; private set; }

        /// <summary>
        /// Create an empty nodal load as a placeholder
        /// </summary>
        public PointAcceleration() { }

        public override LoadType GetLoadType()
        {
                return LoadType.PointAcceleration;
        }
        /// <summary>
        /// Create a new nodal load containing forces and moments. This is the only constructor that sets the nodal force
        /// values. For all other nodal load types (displacement, velocity etc) use the relevant Set method.
        /// </summary>
        /// <param name="loadcase"></param>
        /// <param name="fx"></param>
        /// <param name="fy"></param>
        /// <param name="fz"></param>
        /// <param name="mx"></param>
        /// <param name="my"></param>
        /// <param name="mz"></param>
        public PointAcceleration(BH.oM.Structural.Loads.Loadcase loadcase, double ax, double ay, double az, double arx, double ary, double arz)
        {
            this.Loadcase = loadcase;
            this.TranslationalAcceleration = new Vector(ax, ay, az);
            this.RotationalAcceleration = new Vector(arx, ary, arz);
        }
    }
}
