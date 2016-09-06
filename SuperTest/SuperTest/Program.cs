using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTest
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Jag är en dum konsollapp. Hejhå. ");

      Console.WriteLine(SubTest.SubClass.SecretString()); 

      Console.ReadLine(); 
    }
  }
}
