using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Покажет сколько раз во введеннй строке встречаются слова из массива
        /// </summary>
        /// <param name="text">Вводимая строка</param>
        /// <param name="words">Массив со словами, количество повторений которых хотим посчитать</param>
        public static void WordsCounter(string text, string[] words)
        {

            Console.WriteLine($"Введена строка: {text} ");
            
            Dictionary<string,int> CountOfWord = new Dictionary<string, int>();
            string[] textArray = text.Split(' ');      

             // добавили все слова из входного массива в словарик и записали что встречаются 0 раз
            foreach (var word in words)
            {
                CountOfWord.Add(word,0);
            }

//пробежались по всем словам строки которую разделилил на массив, если слово есть в словаре прибавляем ему количество которое оно встречается
            foreach (var word in textArray)
            {
                if (CountOfWord.ContainsKey(word))
                {
                    CountOfWord[word] +=1  ;
                }

            }

            Console.WriteLine("Слова из переданного массива встречаются в тексте раз:");
            foreach (var keyValuePair in CountOfWord)
            {
                Console.WriteLine(keyValuePair);
            }

        }
        
        
        /// <summary>
        /// Проверятет является ли строка 2 обратной строке 1
        /// </summary>
        /// <param name="message">Строка 1</param>
        /// <param name="backmessage">Строка 2</param>
        public static void backToFrontString(string message, string backmessage)
        {
            if (message.Length == backmessage.Length)
            {
                var charmess = message.ToCharArray();
                var charbackmess = backmessage.ToCharArray();
                
                var count = 0;
                
                foreach (var ch in charmess)
                {
                    if (ch == charbackmess[charbackmess.Length - 1 - count])
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Строка 2 не является обратной строке 1");  
                        return;
                    }
                }
                
                Console.WriteLine("Строка 2 является обратной строке 1");  
            }
            else
            {
                Console.WriteLine("Длинна строк не совпадает");
            }
        }


    }
}