namespace ApplicationService
{
    public static class HexCode
    {
        /// <summary>
        /// Determines whether a string is a valid hex code
        /// Notes:
        /// 1. A hex code must begin with a pound key # 
        /// 2. It has exactly 6 characters in length, if consider the '#' them are 7 characters in lenght
        /// 3. Each character must be a digit from 0-9 or an alphabetic character from A-F
        /// 4. All alphabetic characters may be uppercase or lowercase
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool IsValidHexCode(string code)
        {
            // Implementing rule 1
            if (!code[0].Equals('#'))
                throw new ArgumentException(" hex code must begin with a pound key #");

            // Implementing rule 2
            if (code.Length != 7)
                throw new ArgumentOutOfRangeException("It must has exactly 7 characters in length");

            char[] validCharacters = new char[] { '#', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            bool areValidCharacters = code.All(code => validCharacters.Any(validCharacter => validCharacter.Equals(Char.ToUpper(code))));

            if (areValidCharacters)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}