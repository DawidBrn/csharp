
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
using System;

namespace Section16
{
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

    class Program
    {
        static void Main(string[] args)
        {
            IMobile mobilePhone = new Phone();
            mobileUser phoneUser = new mobileUser(mobilePhone);

            Console.WriteLine(phoneUser.GetIOSPhoneDetails());
        }
    }
}
