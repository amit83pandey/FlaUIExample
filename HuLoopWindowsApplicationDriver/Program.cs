using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.UIA3;

namespace HuLoopWindowsApplicationDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desktop Automation Initiated");
            var application = Application.LaunchStoreApp("Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            var automation = new UIA3Automation();
            AutomationElement root = automation.GetDesktop();
            var mainwindowhandle = application.GetMainWindow(automation);
            FlaUI.Core.Conditions.ConditionFactory cf = new FlaUI.Core.Conditions.ConditionFactory(new UIA3PropertyLibrary());
            //root.FindFirstDescendant(cf.ByName("SQL")).Click();
            root.FindFirstDescendant(cf.ByName("One")).Click();
            root.FindFirstDescendant(cf.ByName("Plus")).AsButton().Click();
            root.FindFirstDescendant(cf.ByName("Seven")).AsButton().Click();
            root.FindFirstDescendant(cf.ByName("Equals")).AsButton().Click();
            application.Close();
        }
    }
}
