namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    public class Tests
    {
        [Test]
        public void ConstructorWorksCorrectly()
        {
            Phone phone = new Phone("Samsung", "Galaxy");

            Assert.AreEqual("Samsung", phone.Make);
            Assert.AreEqual("Galaxy", phone.Model);

            Assert.AreEqual(0, phone.Count);
        }

        [Test]
        public void MakeIsNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone(null, "Galaxy");
            });
        }

        [Test]
        public void ModelIsNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone("Samsung", null);
            });
        }

        [Test]
        public void CountCorrectly()
        {
            string name = "pesho";
            string numbers = "0098";

            Phone phone = new Phone("Samsung", "Galaxy");

            phone.AddContact(name, numbers);

            Assert.AreEqual(1, phone.Count);
        }

        [Test]
        public void AddContactCorrectly()
        {
            string name = "pesho";
            string numbers = "0098";

            Phone phone = new Phone("Samsung", "Galaxy");

            phone.AddContact(name, numbers);

            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.AddContact(name, numbers);
            });

        }

        [Test]
        public void CallCorrectly()
        {
            string name = "pesho";
            string numbers = "0098";

            Phone phone = new Phone("Samsung", "Galaxy");

            phone.AddContact(name, numbers);

            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.Call("gosho");
            });
        }

        [Test]
        public void CallIfReturn()
        {
            string name = "pesho";
            string numbers = "0098";

            Phone phone = new Phone("Samsung", "Galaxy");

            phone.AddContact(name, numbers);

            Assert.AreEqual($"Calling {name} - {numbers}...", phone.Call(name));
        }
    }
}