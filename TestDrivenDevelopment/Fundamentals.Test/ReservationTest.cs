using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fundamentals.Test
{
    [TestClass]
    public class ReservationTest
    {
        User _adminUser;
        User _nonAdminUser;
        public ReservationTest()
        {
            Initialize();
        }

        private void Initialize()
        {
            _adminUser = new User { IsAdmin = true };
            _nonAdminUser = new User { IsAdmin = false };
        }

        [TestMethod]
        public void CanBeCancelledBy_AdminUser_ReturnsTrue()
        {
            Reservation reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(_adminUser);

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_NonAdminUser_ReturnsFalse()
        {
            Reservation reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(_nonAdminUser);

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserThatCreatedIt_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user};

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);

        }
    }
}
