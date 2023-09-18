using System;
using System.Reflection;

namespace AttributePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p1 = new Person(){
                FirstName ="bob",
                LastName="smith"
            };

            Console.WriteLine(p1);
            Type t1 = p1.GetType();
            Console.WriteLine(t1);

            /*ConstructorInfo[] c = t1.GetConstructors();
            foreach(ConstructorInfo ci in c){
                Console.WriteLine(ci);
            };*/

            /*PropertyInfo[] p = t1.GetProperties();
            foreach(PropertyInfo pi in p){
                Console.WriteLine(pi);
            };*/

            MemberInfo[] m = t1.GetMembers();
            foreach(MemberInfo mi in m){
                Console.WriteLine(mi);
                /*Console.WriteLine(mi.IsConstructor);
                Console.WriteLine(mi.IsPublic);
                Console.WriteLine(mi.IsPrivate);
                Console.WriteLine(mi.IsStatic);
                Console.WriteLine(mi.GetParameters());
                Console.WriteLine(mi.GetMethodBody());*/

                object[] attributes = mi.GetCustomAttributes(true);
                foreach(object o in attributes){
                    
                    Console.WriteLine(o);
                    if(o is PersonalInformationAttribute) {
                        Console.WriteLine("Personal Dont print");
                        PersonalInformationAttribute pia = (PersonalInformationAttribute)o;
                        if(pia.Level==3){
                            Console.WriteLine("super private");
                        }else{
                            Console.WriteLine("sorta Private");
                        }
                    }
                }




                Console.WriteLine("-----------------------");
            };

        }
    }
}
