using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var ThisQuery =
                from StringValue
                in QueryString
                select StringValue;
            
            String[] QueryString ={ “One”, “Two”, “Three”, “Four”, “Five” };
        }
    }
}
