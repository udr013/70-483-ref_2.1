using System;

namespace ExtentionMethods
{
    public static class MyExtentions
    {
        public static int LineCount(this String str)
        {
            return str.Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
