using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationManager applicationManager = new ApplicationManager();

            applicationManager.StartApplicationUsingInterfaces();
            applicationManager.StartApplicationUsingDelegates();
        }

        
    }

    public class ApplicationManager
    {
        public ApplicationManager() { }

        public void StartApplicationUsingDelegates()
        {

        }

        public void StartApplicationUsingInterfaces()
        {

        }
    }
}
