
namespace DrPet.Bll.Helpers
{
    public static class StringHelper
    {
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
