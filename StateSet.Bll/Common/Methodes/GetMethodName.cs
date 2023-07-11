using System.Runtime.CompilerServices;

namespace StateSet.Bll.Common.Methodes
{
    public class GetMethodName
    {
        public static string GetName([CallerMemberName] string name = "")
        {
            return name;
        }
    }
}
