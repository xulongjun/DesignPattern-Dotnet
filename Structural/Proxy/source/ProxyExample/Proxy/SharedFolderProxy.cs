using ProxyExample.Models;
using ProxyExample.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyExample.Proxy
{
    // The Proxy has an interface identical to the RealSubject.
    public class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Employee employee;

        public string messageTest {  get; private set; }

        public SharedFolderProxy(Employee emp)
        {
            employee = emp;
        }

        public void PerformRWOperations()
        {
            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                messageTest = "Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'";
                Console.WriteLine(messageTest);
                folder.PerformRWOperations();
            }
            else
            {
                messageTest = "Shared Folder proxy says 'You don't have permission to access this folder'";
                Console.WriteLine(messageTest);
            }
        }
    }
}
