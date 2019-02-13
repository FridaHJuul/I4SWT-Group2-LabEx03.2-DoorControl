using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControlProject;

namespace DoorControl.Test.Unit
{
   public class FakeAlarm : IAlarm
   {
      public void RaiseAlarm()
      {
         throw new NotImplementedException();
      }
   }
}
