using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;

namespace MyCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult MySimpleAction(Session session)
        {
            try
            {
               
                File.AppendAllText(@"c:\tmp\time1.txt", "-- Installation: " + DateTime.Now.ToString());
               
            }
            catch (Exception)
            {
                return ActionResult.Failure;
            }
            return ActionResult.Success;
        }
    }
}
