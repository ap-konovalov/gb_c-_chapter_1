using System;
using System.Text;

namespace Lesson5
{
    public static  class Message
    {
//        Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
//        а) Вывести только те слова сообщения,  которые содержат не более n букв.
//            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//            в) Найти самое длинное слово сообщения.
//            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//            д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в
//            него передается массив слов и текст, в качестве результата метод возвращает сколько раз
//            каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.


        /// <summary>
        /// Удаляет из строки все слова длинной больше 10 символов
        /// </summary>
        /// <param name="message">Строка из которой нужно удалить символы</param>
        public static void CutWordsFromString(string message)
        {
            string[] words = message.Split(' ');
            string newString = string.Empty;

            foreach (var word in words)
            {
                if (word.Length <= 10)
                {
                    newString += $"{word} ";
                }
            }

            Console.WriteLine($"Слова короче 10 символов : {newString}");
        }

        /// <summary>
        /// Удалит слова, заканчивающиеся на символ
        /// </summary>
        /// <param name="message">Сообщение из которого удаляем слова</param>
        /// <param name="symbol">Символ на который заканчиваются слова для удаления</param>
        public static void DelWordsEndWith(string message,string symbol)
        {
            string[] words = message.Split(' ');
            string newString = string.Empty;

            foreach (var word in words)
            {
                if (!word.EndsWith(symbol))
                {
                    newString += $"{word} ";
                }
            }

            Console.WriteLine($"Слова в конце которых нет символа \"{symbol}\" : {newString}");
        }

        /// <summary>
        /// Самое длинное слово св строке
        /// </summary>
        /// <param name="message">стока в которой ищем слово</param>
        public static string IsLongestWord(string message)
        {
            string[] words = message.Split(' ');
            string isLongestWord = string.Empty;

            foreach (var word in words)
            {
                if (word.Length > isLongestWord.Length)
                {
                    isLongestWord = word;
                }
            }

            return isLongestWord;
        }
        
        /// <summary>
        /// Формирует из строки новую строку, расставив в ней слова от самого длинного к самому короткому
        /// </summary>
        /// <param name="message">Входящая строка</param>
        public static void LongestWordString(string message)
        {
            StringBuilder LongWordString = new StringBuilder();

            string[] words = message.Split(' ');      
                        
            //сортировка массива пузырьком
            var temp = String.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Length > words[j].Length)
                    {
                        temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }                   
                }            
            }

            //Создаем нову строку прикрепляя в нее поочередно все слова из массива
            for (int i = words.Length-1; i >= 0  ; i--)
            {

                LongWordString.Append($"{words[i]} ");

            }

            Console.WriteLine($"Строка из самых длинных слов: {LongWordString}");
        }


    }
}