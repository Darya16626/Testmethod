using System; 
using System.Linq; // метод для работы с коллекциями  Any

namespace Password 
{
    public static class Pass
    {
        public static int CheckPasswordStrength(string password) // проверка пароля
        {
            int score = 0; // Оценка пароля
            int digitScore = 0;
            int lowercaseScore = 0;
            int caitalScore = 0;
            int specialScore = 0; 
            int lengthScore = 0;

            // Проверка наличия цифр
            if (password.Any(char.IsDigit))
            {
                digitScore = 1;
                score++;
            }

            // Проверка наличия строчных букв
            if (password.Any(char.IsLower))
            {
                lowercaseScore = 1; 
                score++;
            }

            // Проверка наличия заглавных букв
            if (password.Any(char.IsUpper)) 
            {
                caitalScore = 1; 
                score++;
            }

            // Проверка наличия спец символов
            if (password.Any(char.IsPunctuation)) 
            {
                specialScore = 1;
                score++;
            }

            // Проверка длины пароля
            if (password.Length > 10)
            {
                lengthScore = 1; 
                score++;
            }

            return score;
        }

        // Добавьте следующие методы для получения отдельных оценок:
        public static int GetDigitScore(string password)
        {
            return password.Any(char.IsDigit) ? 1 : 0; 
        }

        public static int GetLowercaseScore(string password) 
        {
            return password.Any(char.IsLower) ? 1 : 0; 
        }

        public static int GetCaitalScore(string password) 
        {
            return password.Any(char.IsUpper) ? 1 : 0; 
        }

        public static int GetSpecialScore(string password) 
        {
            return password.Any(char.IsPunctuation) ? 1 : 0; 
        }

        public static int GetLengthScore(string password) 
        {
            return password.Length > 10 ? 1 : 0;
        }
    }
}