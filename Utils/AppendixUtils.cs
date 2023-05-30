using System.Collections.Generic;

namespace Assistant.Utils
{
    public static class AppendixUtils
    {
         public static List<TypeFormData> TypeFormDatas = new List<TypeFormData>(); 

        public static void GetNameSpaces()
        {
            TypeFormDatas.Add(new TypeFormData {NameSpace = "MakeMenu", NameTable = "type_product", NameForm = "fTypeProducts"});
            TypeFormDatas.Add(new TypeFormData { NameSpace = "MakeMenu", NameTable = "product", NameForm = "fProducts" });
            TypeFormDatas.Add(new TypeFormData { NameSpace = "Budget", NameTable = "category", NameForm = "fCategorys" });
            TypeFormDatas.Add(new TypeFormData { NameSpace = "Budget", NameTable = "category_code", NameForm = "fCategoryCodes" });
            TypeFormDatas.Add(new TypeFormData { NameSpace = "Budget", NameTable = "date_budget", NameForm = "fDateBudgets" });
        }

    }

    public class TypeFormData
    {
        public string NameSpace;
        public string NameTable;
        public string NameForm;
    }
}
