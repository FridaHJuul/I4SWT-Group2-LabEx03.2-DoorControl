﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlProject
{
   public interface IEntryNotification
   {
      void NotifyEntryGranted();

      void NotifyEntryDenied();
   }
}
