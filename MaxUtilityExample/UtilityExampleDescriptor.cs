using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.Max;

namespace MaxUtilityExample
{
    /// <summary>
    /// Class descriptors provide the system with information about the plug-in classes in the DLL.
    /// The developer creates a class descriptor by deriving a class from ClassDesc2 (which derives from ClassDesc) and implementing several of its methods.
    /// http://docs.autodesk.com/3DSMAX/16/ENU/3ds-Max-SDK-Programmer-Guide/index.html?url=cpp_ref/class_class_desc2.html,topicNumber=cpp_ref_class_class_desc2_htmlec3a5fba-571a-4571-b183-a39d04c74484
    /// </summary>
    public class UtilityExampleDescriptor : Autodesk.Max.Plugins.ClassDesc2
    {
        /// <summary>
        /// This methods returns a string describing the category a plug-in fits into. 
        /// </summary>
        public override string Category
        {
            get { return "MaxDotNetExamples"; }
        }

        /// <summary>
        /// This method must return the unique ID for the object. 
        /// Use the gencid.exe tool, which is included with the SDK, to generate the two unique numbers
        /// </summary>
        public override IClass_ID ClassID
        {
            get { return Autodesk.Max.GlobalInterface.Instance.Class_ID.Create(0x24861f9b, 0x6a5d3982); }
        }

        /// <summary>
        /// This method returns the name of the class.
        /// This name appears in the button for the plug-in in the 3ds Max user interface. 
        /// </summary>
        public override string ClassName
        {
            get { return "1. MaxDotNetUtilityExample"; } // I put a 1. infront so it shows up at the to of the list, so you can't miss it
        }

        /// <summary>
        /// Controls if the plug-in shows up in lists from the user to choose from. 
        /// If the plug-in can be picked and assigned by the user, as is usually the case, return TRUE. 
        /// Certain plug-ins may be used privately by other plug-ins implemented in the same DLL and should not appear in lists for user to choose from. 
        /// These plug-ins would return FALSE. 
        /// </summary>
        public override bool IsPublic
        {
            get { return true; }
        }

        /// <summary>
        /// This method returns a system defined constant describing the class this plug-in class was derived from. 
        /// A list of Superlcas IDs can be found in the SDK docs
        /// http://docs.autodesk.com/3DSMAX/16/ENU/3ds-Max-SDK-Programmer-Guide/index.html?url=cpp_ref/idx__r_list_of_super_class_ids_html.html,topicNumber=cpp_ref_idx__r_list_of_super_class_ids_html_html8378f37e-7a35-4835-9c05-de5c23c64ef9
        /// </summary>
        public override SClass_ID SuperClassID
        {
            get { return Autodesk.Max.SClass_ID.Utility; }
        }

        /// <summary>
        /// 3ds Max calls this method when it needs a pointer to a new instance of the plug-in class.
        /// </summary>
        /// 
        /// <param name="loading">
        /// This parameter is a flag indicating if the class being created is going to be loaded from a disk file. 
        /// If the flag is TRUE, the plug-in may not have to perform any initialization of the object because the loading process will take care of it. 
        /// See the Advanced Topics section on Loading and Saving for more information.
        /// </param>
        /// 
        /// <returns>New Instance of UtilityExample class</returns>
        public override object Create(bool loading)
        {
            return new UtilityExample();
        }
    }
}
