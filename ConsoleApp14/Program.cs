using System;
using System.Text;

namespace ConsoleApp14 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine(GetDomain("elchin@code.edu.az"));
            Console.WriteLine(IsOnlyLetters("OnlyLetters"));
            Console.WriteLine(IsOnlyLetters("Not Only Letters"));
            Console.WriteLine(FirstLetterToUpper("saLAm nEceSen"));
            string[] names = GetNames(new string[] 
            { "Adley Rosales", "Wilder Randall", "Christina Larsen", "Brycen Marks"});
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine(GetAge(new DateTime(2000, 10, 10)));

        }

        #region Task 1

        // Verilmiş email dəyərinin domain hissəni qaytaran metod

        public static string GetDomain(string email) {
            StringBuilder domain = new StringBuilder();
            bool isDomain = false;
            for (int i = 0; i < email.Length; i++) {
                if (email[i] == '@') {
                    isDomain = true;
                    continue;
                }

                if (isDomain) {
                    domain.Append(email[i]);
                }
            }
            return domain.ToString();
        }

        #endregion

        #region Task 2

        // Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod

        public static bool IsOnlyLetters(string text) {
            for (int i = 0; i < text.Length; i++) {
                if (!('A' <= text[i] && text[i] <= 'Z' || 'a' <= text[i] && text[i] <= 'z')) {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Task 3

        // Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod

        public static string FirstLetterToUpper(string text) {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++) {
                if (i == 0) {
                    result.Append(char.ToUpper(text[i]));
                } else {
                    result.Append(char.ToLower(text[i]));
                }
            }
            return result.ToString();
        }

        #endregion

        #region Task 4

        // Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod

        public static string[] GetNames(string[] fullNames) {
            string[] names = new string[fullNames.Length];
            for (int i = 0; i < fullNames.Length; i++) {
                string[] temp = fullNames[i].Split(' ');
                names[i] = temp[0];
            }
            return names;
        }

        #endregion

        #region Task 5

        // Doğum tarixinizi daxil etdiyinizdə sizə yaşınızı qaytaran metod

        public static int GetAge(DateTime birthDate) {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || now.Month == birthDate.Month && now.Day < birthDate.Day) {
                age--;
            }
            return age;
        }

        #endregion
    }
}
