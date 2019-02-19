using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControlProject;

namespace DoorControl.Test.Unit
{
   public class FakeUserValidation : IUserValidation
   {
      public bool validID;
      public bool ValidateEntryRequest(string id)
      {
         throw new NotImplementedException();
      }
   }
}
