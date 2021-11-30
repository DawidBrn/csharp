
using System;
using System.Collections;
using System.Collections.Generic;

namespace Section16
{
    //abstact factory segment
    /* 
    interface IMobile
    {
        IAndroid GetAndroidPhone();
        IiOS GetIiOSPhone();

    }
    class Phone : IMobile
    {
        public IAndroid GetAndroidPhone()
        {
            return new SamsungGalaxy();

        }
        public IiOS GetIiOSPhone()
        {
            return new SamsungWithIOS();
        }
    }
    interface IAndroid
    {
       string GetModelDetails();
    }
    interface IiOS
    {
       string GetModelDetails();
    }
    class SamsungGalaxy : IAndroid
    {
        public string GetModelDetails()
        {
            return "This is samsung galaxy with android system";
        }
    }
    class SamsungWithIOS : IiOS
    {
        public string GetModelDetails()
        {
            return "This is phone with iOS sysyem";
        }
    }

    class mobileUser : Phone
    {
        IAndroid androidPhone;
        IiOS iOSPhone;

        public mobileUser(IMobile factory)
        {
            androidPhone = factory.GetAndroidPhone();
            iOSPhone = factory.GetIiOSPhone();
        }
         public string GetAndroidPhoneDetails()
        {
            return androidPhone.GetModelDetails();
        }
         public string GetIOSPhoneDetails()
        {
            return iOSPhone.GetModelDetails();
        }
    }
    */

    
    class Program
    {
        static void Main(string[] args)
        {
            //Creational design patterns
            /**
            IMobile mobilePhone = new Phone();
            mobileUser phoneUser = new mobileUser(mobilePhone);

            Console.WriteLine(phoneUser.GetIOSPhoneDetails());

            Car car,car2;
            CarDirector carDirector = new CarDirector();

            FamilyCar familyCar = new FamilyCar();
            car = carDirector.CreateCar(familyCar);
            car.DisplayCar();
            Console.WriteLine(" ");
            SportsCar sportsCar = new SportsCar();
            car2 = carDirector.CreateCar(sportsCar);
            car2.DisplayCar();
            **/

            //Structural desing patterns
            /**
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adptr(adaptee);
            Console.WriteLine(target.Request());

            ISender facebookSender = new FacebookSender();
            ISender twitterSender = new TwitterSender();
            ISender nkSender = new NaszaKlasaSender();

            Message msg = new SystemMessage();
            msg.Subject = "Subject of message";
            msg.Body = "Hello there";

            msg.Sender = facebookSender;
            msg.Send();

            msg.Sender = twitterSender;
            msg.Send();

            msg.Sender = nkSender;
            msg.Send();

            UserMessage userMessage = new UserMessage();
            userMessage.Subject = "Test Message";
            userMessage.Body = "Hellow world";
            userMessage.UserComments = "Hi";

            userMessage.Sender = facebookSender;
            userMessage.Send();
            Console.ReadKey();
            **/

        }
    }
}
