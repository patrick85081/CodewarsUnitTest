using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsUnitTest
{
    [TestClass]
    public class BuilderTests
    {
        [TestMethod]
        public void TestAssemblyBuilder()
        {
            //建立 Dynamic Assembly  （使用AssemblyBuilderAccess指定組件的存取模式。）
            AssemblyBuilder myAssembly =
                AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("MyAssembly"),
                    AssemblyBuilderAccess.RunAndSave);

            ModuleBuilder myModule = myAssembly.DefineDynamicModule("MyModule", "MyModule.dll");

            TypeBuilder myType = myModule.DefineType("MyClass", TypeAttributes.Public | TypeAttributes.Class);

            FieldBuilder myField = myType.DefineField("_count", typeof(int), FieldAttributes.Private);

            Type[] args = new Type[] {typeof(int)};
            ConstructorBuilder myConstructor =
                myType.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, args);


            ILGenerator IL_generator = myConstructor.GetILGenerator();
            IL_generator.Emit(OpCodes.Ldarg_0);
            IL_generator.Emit(OpCodes.Ldarg_1);
            IL_generator.Emit(OpCodes.Stfld, myField);
            IL_generator.Emit(OpCodes.Ret);


            Type[] addArgs = new Type[] {typeof(int)};
            MethodBuilder myMethod = myType.DefineMethod("Add", MethodAttributes.Public, null, addArgs);
            ILGenerator ilAdd = myMethod.GetILGenerator();
            ilAdd.Emit(OpCodes.Ldarg_0);
            ilAdd.Emit(OpCodes.Dup);
            ilAdd.Emit(OpCodes.Ldfld, myField);
            ilAdd.Emit(OpCodes.Ldarg_1);
            ilAdd.Emit(OpCodes.Add);
            ilAdd.Emit(OpCodes.Stfld, myField);
            ilAdd.Emit(OpCodes.Ret);

            PropertyBuilder myProperty = myType.DefineProperty("Count", PropertyAttributes.None, typeof(int), new Type[] { typeof(int) });

            //定義存取方法的屬性，其中要做為類別屬性的存取方法，必需要有特別的屬性，亦即要有MethodAttributes.SpecialName及MethodAttributes.HideSig
            MethodAttributes getsetAttributes = MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig;


        }
    }
}
