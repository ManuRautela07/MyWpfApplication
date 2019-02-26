using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Deployment.WindowsInstaller;

namespace CustomDrop
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            string countryname = session["COUNTRIES"];
            try
            {

                File.AppendAllText(@"c:\tmp\country.txt", countryname);

            }
            catch (Exception)
            {
                return ActionResult.Failure;
            }
            return ActionResult.Success;
        }
    }
}
