﻿using Natasha.CSharp.Template;

namespace Natasha.CSharp
{

    public static class OopDefinedTypeExtension
    {

        public static T Class<T>(this DefinedTypeTemplate<T> defined) where T : DefinedTypeTemplate<T>, new()
        {

            return defined.DefinedType("class");

        }




        public static T Struct<T>(this DefinedTypeTemplate<T> defined) where T : DefinedTypeTemplate<T>, new()
        {

            return defined.DefinedType("struct");

        }




        public static T Interface<T>(this DefinedTypeTemplate<T> defined) where T : DefinedTypeTemplate<T>, new()
        {

            return defined.DefinedType("interface");

        }




        public static T Enum<T>(this DefinedTypeTemplate<T> defined) where T : DefinedTypeTemplate<T>, new()
        {

            return defined.DefinedType("enum");

        }


    }

}