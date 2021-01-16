using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerChatApp_20160140086_DimasAgungP
{

            class Program
        {
            static void Main(string[] args)
            {
                ServiceHost hostObjek = null;
                try
                {
                    hostObjek = new ServiceHost(typeof(ServiceCallback));
                    hostObjek.Open();

                    Console.WriteLine("Server On, Ready to use");
                    Console.ReadLine();

                    hostObjek.Close();
                }
                catch (Exception ex)
                {
                    hostObjek = null;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }

    internal class ServiceHost
    {
        public ServiceHost(Type type)
        {
            Type = type;
        }

        public Type Type { get; }

        internal void Close()
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
