using BindingTestTarget;
using HarmonyLib;
using NUnit.Framework;
using SolastaModApi.ReflectionBindings;
using BindingTestTarget.Extensions;
using System;
using System.Reflection;
using System.IO;

namespace BindingTestRunner
{
    [TestFixture]
    public class TestBindings
    {
        [TestCase]
        public void TestNormalClass()
        {
            var instance = new NormalClass();
            instance.SetStringField("Hello");
            var stringField = instance.GetStringField();
            Assert.AreEqual("Hello", stringField);

            instance.SetIntField(5);
            var intField = instance.GetIntField();
            Assert.AreEqual(5, intField);
            instance.Foo();
        }
        [TestCase]
        public void TestStruct()
        {
            var instance = new StructClass();
            instance.SetStringField("Hello");
            var stringField = instance.GetStringField();
            Assert.AreEqual("Hello", stringField);

            instance.SetIntField(5);
            var intField = instance.GetIntField();
            Assert.AreEqual(5, intField);
        }
        [TestCase]
        public void TestHarmony()
        {
            var assemblyDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Environment.SetEnvironmentVariable("MONOMOD_DMD_TYPE", "cecil");
            Environment.SetEnvironmentVariable("MONOMOD_DMD_DUMP", $@"{assemblyDir}\mmdump");
            var normalInstance = new NormalClass();
            var normalFieldRef = AccessTools.FieldRefAccess<NormalClass, string>("stringField");
            normalFieldRef(normalInstance) = "Hello";
            var normalField = normalFieldRef(normalInstance);

            var structInstance = new StructClass();
            var structFieldRef = AccessTools.StructFieldRefAccess<StructClass, string>("stringField");
            structFieldRef(ref structInstance) = "Hello";
            var structField = structFieldRef(ref structInstance);

            Environment.SetEnvironmentVariable("MONOMOD_DMD_DUMP", "");
            Assert.AreEqual("Hello", normalField);
            Assert.AreEqual("Hello", structField);
        }


    }
}
