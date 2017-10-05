using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.Max;

namespace MaxUtilityExample
{
    /// <summary>
    /// By implementing the "UtilityObj" abstract class,
    /// we indicate that our class can be used as a Utility inside of max.
    /// (Please refer to the docs if you don't know what a utility is)
    /// 
    /// See the SDK (c++) documentation for more information:
    /// http://docs.autodesk.com/3DSMAX/16/ENU/3ds-Max-SDK-Programmer-Guide/index.html?url=files/GUID-9D824C6F-2448-425B-B104-FC84A234430A.htm,topicNumber=d30e55487
    /// </summary>


    public class UtilityExample : Autodesk.Max.Plugins.UtilityObj
    {
        public override void BeginEditParams(IInterface ip, IIUtil iu)
        {
            // push a message to the "help bar" on the bottom
            ip.PushPrompt("Hey, our utility has just been started!");
        }

        public override void EndEditParams(IInterface ip, IIUtil iu)
        {
            // make sure we clear (pop) our message
            ip.PopPrompt();
        }
    }

}
