using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControlProject;
using NSubstitute;
using NUnit.Framework;

namespace DoorControl.Test.Unit
{
    [TestFixture]
    public class DoorControlUnitTests
    {
        private DoorControlProject.DoorControl _uut;
        private IAlarm _alarm;
        private IDoor _door;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;

        [SetUp]
        public void SetUp()
        {
            _alarm = Substitute.For<IAlarm>();
            _entryNotification = Substitute.For<IEntryNotification>();
            _door = Substitute.For<IDoor>();
            _userValidation = Substitute.For<IUserValidation>();

            _uut = new DoorControlProject.DoorControl(_userValidation,_alarm,_door,_entryNotification);
        }

        [Test]
        public void DoorOpen_MethodDoorOpenInDoor_WasCalled() //vi ser, om Open i klassen Door bliver kaldt via DoorOpen
        {
            _uut.DoorOpen();
            _door.Received(1).Open();
        }

        [Test]
        public void RequestEntry_IdCorrect_EntryGranted()
        {
            _userValidation.ValidateEntryRequest(Arg.Any<string>()).Returns(true);
            _uut.RequestEntry("5");
            _entryNotification.Received(1).NotifyEntryGranted();
        }

        [Test]
        public void RequestEntry_IdCorrect_DoorOpens()
        {
            _userValidation.ValidateEntryRequest(Arg.Any<string>()).Returns(true);
            _uut.RequestEntry("5");
            _door.Received(1).Open();
        }

        [Test]
        public void RequestEntry_IdCorrect_EntryDenied()
        {
            _userValidation.ValidateEntryRequest("7").Returns(false);
            _uut.RequestEntry("786");
            _entryNotification.Received(1).NotifyEntryDenied();
        }

    }
}
