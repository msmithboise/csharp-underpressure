// statics do not need to be instantiated.  
namespace csunderpressure.Models
{

    public static class Utils
    {

        public static int DoubleInteger(int num)
        {
            return num * 2;
        }

        public static bool IsNumberEven(int num)
        {
            return num % 2 == 0;
        }

        public static string FileExtension(string str)
        {
            string[] strArray = str.Split('.');
            if (strArray.Length > 1)
            {
                return strArray[strArray.Length - 1];
            }
            return null;
        }

        public static string LongestString(string[] strArray)
        {
            string longest = "";
            foreach (string str in strArray)
            {
                if (str.Length > longest.Length)
                {
                    longest = str;
                }
            }
            return longest;
        }
        public static int SumAllInts(int[] nums)
        {
            int total = 0;
            foreach (int num in nums)
            {
                total += num;
            }
            return total;
            {

            }
        }
    }

}



