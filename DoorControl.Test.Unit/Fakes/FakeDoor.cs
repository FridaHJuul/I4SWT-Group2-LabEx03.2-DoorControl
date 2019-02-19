using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControlProject;

namespace DoorControl.Test.Unit
{
   public class FakeDoor: IDoor
   {
      public bool DoorClosed { get; private set; }
      public void Open()
      {
         DoorClosed = false;
      }

      public void Close()
      {
         DoorClosed = true;
      }
   }
}
