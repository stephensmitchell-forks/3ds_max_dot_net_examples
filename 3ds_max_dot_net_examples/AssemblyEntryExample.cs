using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ManagedServices;

namespace MaxUtilityExample
{
    /// <summary>
    /// In order to give max the chance for an entry point to our plugin,
    /// we need do define at least two public static functions (with specific names!) in a public static class
    /// 
    /// Namely "AssemblyMain" which gets called once 3Ds Max starts and "AssemblyShutdown" which gets called when 3Ds Max shuts down.
    /// These functions can be used todo intializing work in our plugin and get a chance to safe things when it gets shutdown.
    /// 
    /// Make sure the assmbly is placed in the <maxroot>bin/assemblies folder in order to get things working
    /// 
    /// Reference: 
    /// http://docs.autodesk.com/3DSMAX/16/ENU/3ds-Max-SDK-Programmer-Guide/index.html?url=files/GUID-BEE074AD-9B78-43B8-8F67-9C2BB25B9C23.htm,topicNumber=d30e50091
    /// </summary>

    public static class AssemblyEntryExample
    {
        /// <summary>
        /// Gets called on 3Ds Max start
        /// </summary>
        public static void AssemblyMain()
        {
            // put initializing code here, to start our plugin

            // This interface provides access to all of the global functions and variables in the 3ds Max SDK
            var g = Autodesk.Max.GlobalInterface.Instance;

            // Core interfaces are interfaces to a singleton object that exposes services provided by 3ds Max
            var ip = g.COREInterface14;

            // This method is used to dynamically add a plug-in class. This method will update the control panel in the Create or Modify branches dynamically. 
            ip.AddClass(new UtilityExampleDescriptor());
        }


        /// <summary>
        /// Gets called on 3Ds Max shutdown
        /// </summary>
        public static void AssemblyShutdown()
        {
            // put 'shutdown' code here, to safely shut down our plugin
        }
    }
}
