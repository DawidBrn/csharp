
// abstract factory design pattern, abstract factory -> concrete factory ->
// abstract product -> concrete product -> client(map out objects and variances of objects
// -> decalre abstract object interface for all object types -> create contrete
// classes to implement previous interfaces -> declare abstract factory interface
// with a set of creation rules/methods for all abstract objects created by this factory
//  -> implement set of concrete classes that each represent an object variant phone->android/IOS
//  , tv -> OLED / amoled itd and write factory inicialization code -> instead of using contructors
//  call certain creation method for a variant.
//  Use when code needs to work 
// with various familes of similiar objects but want to depend on concrete classes
// of specific objects , to provide better expandability of code

//builder design pattern, pattern used for creating complex objects data ultimetly can vary from each
//other for example toyota corrola from 1998 with 1.3L gas engine and 1.6L gas engine. Main advantege 
//of using builder pattern is reusability of same contructors for diffrent version of the object
//, although the complexity of code grows with objects differences


using System;

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
            /*
            IMobile mobilePhone = new Phone();
            mobileUser phoneUser = new mobileUser(mobilePhone);

            Console.WriteLine(phoneUser.GetIOSPhoneDetails());*/

            Car car,car2;
            CarDirector carDirector = new CarDirector();

            FamilyCar familyCar = new FamilyCar();
            car = carDirector.CreateCar(familyCar);
            car.DisplayCar();
            Console.WriteLine(" ");
            SportsCar sportsCar = new SportsCar();
            car2 = carDirector.CreateCar(sportsCar);
            car2.DisplayCar();
            

        }
    }
}
