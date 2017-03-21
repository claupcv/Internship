using System;


namespace HelloWorld
{
    class Program
    {
        public static readonly string pathToProject = AppDomain.CurrentDomain.BaseDirectory + @"docs\";
        static void Main(string[] args)
        {
            // EnumFlags.RunEnumAndEnumFlags();

            // Xml.MethodXmlDocument();
            // Serialization.SerializationInstanceJson();
            // SerializebleBook.RunSerializable();
            // TestGarbageCollector.TestMethod();
            // ThreadCreationProgram.ThreadTest();
            // ThreadCreationProgram.ThreadTimer();
            // ThreadCreationProgram.MainLockTest();

            // NullableTypes.NullableTypeMethod();
            // TestAM.TestAMmethod();
            // Propertiess.PropertiesMethod();

            // TestIndexers.TestIndexersMethod();
            // ChildAbstractClasesAndMethods.ChildAbstractMethod();
            // Interfaces.RunInterface();

            // PassingParameters.PassingParametersExample();

            // OverloadingMethods.OverloadingMethodExample();

            // ExtensionMethodesTest.StaticMethodesTestMethod();

            //Delegates.DelegatesTestMethod();

            //StaticClassTest.StaticClassRun();
            
            //DeriveinheritanceClass DeriveinheritanceClasss = new DeriveinheritanceClass();
            Console.WriteLine("============");
            DeriveinheritanceClass.Make();
            Console.ReadKey();
        }
    }
}
