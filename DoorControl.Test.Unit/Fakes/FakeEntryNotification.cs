﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControlProject;

namespace DoorControl.Test.Unit
{
   public class FakeEntryNotification : IEntryNotification
   {
      public void NotifyEntryGranted()
      {
         throw new NotImplementedException();
      }

      public void NotifyEntryDenied()
      {
         throw new NotImplementedException();
      }
   }
}
