
namespace DrPet.Bll.Helpers
{
    public static class StringHelper
    {
        /// <summary>
        /// Shorten a string to a specified length.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="maxLenght"></param>
        /// <returns></returns>
        public static string Shorten(this string current, int maxLenght)
        {
            if (current == null)
                return "";
            if (current.Length < 201)
                return current;

            return current[0..(maxLenght -1)] + "...";
        }
    }
}
