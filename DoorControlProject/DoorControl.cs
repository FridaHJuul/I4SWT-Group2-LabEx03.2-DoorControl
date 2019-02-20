using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControlProject
{
   public class DoorControl
   {
      private IUserValidation _userValidation;
      private IAlarm _alarm;
      private IDoor _door;
      private IEntryNotification _entryNotification;

      public DoorControl(IUserValidation userValidation, IAlarm alarm, IDoor door, IEntryNotification entryNotification)
      {
         _userValidation = userValidation;
         _alarm = alarm;
         _door = door;
         _entryNotification = entryNotification;
      }

      public void RequestEntry(string id)
      {
         var idStatus = _userValidation.ValidateEntryRequest(id);

         if (idStatus) //svarer til idStatus==true
         {
            _door.Open();
            _entryNotification.NotifyEntryGranted();
         }
         else
         {
             _entryNotification.NotifyEntryDenied();
         }
      }

      public void DoorOpen()
      {
         _door.Open();
      }
   }
}
