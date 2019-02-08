using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Lesson5


{
    internal class Program
    {
        public static void Main(string[] args)
        {



//            #region Regexp
//
//            string pattern = @"[\d]{3}\-[\d]{2}\-[\d]{2}\";
//
//            Regex phoneMask = new Regex(pattern);
//
//            string phoneBook = "123-33-33 12344-22-33 483-22-11 1239-123-11 123-11-11";
//
//            var t = phoneMask.IsMatch(phoneBook);
//
//            if (t)
//            {
//                foreach (var item in phoneMask.Matches(phoneBook))
//                {
//                    Console.WriteLine(item);
//                }
//
//            }
//
//            #endregion



//            #region Parser
//
//// путь к странице
//            string[] SiteUrl =
//            {
//                @"https://www.tradicia-k.ru/catalog/gidromoloty-impulse/",
//            };
//
//            foreach (var address in SiteUrl)
//            {
//              GetTitle(address, "product__name","</");
//            }
//
//            #endregion


        }

//        #region ParserMethod
//
//        /// <summary>
//        /// Парсит по заданному урлу и вхождению слова
//        /// </summary>
//        /// <param name="siteUrl">ссылка на страницу</param>
//        /// <param name="beginWord">Начало (элемент с которого парсим)</param>
//        /// <param name="endWord">До какого элемента парсим</param>
//        /// <returns></returns>
//        private static void GetTitle(string siteUrl, string beginWord, string endWord)
//        {
//            WebClient client = new WebClient() {Encoding = Encoding.UTF8};
//// скачали всю страницу
//            string allPage = client.DownloadString(siteUrl);
//
//            // нашли индекс вхождения слова
//            int beginInd = allPage.IndexOf(beginWord) + beginWord.Length +2;
//
//// переписали строку начали ее со слова которое ищем и до конца
//                string CutStringBegin = allPage.Substring(beginInd);
//// нашли из переписанной строки где заканчивается наша фраза
//                int endInd = CutStringBegin.IndexOf(endWord);
//// перезаписали строку
//                string result = allPage.Substring(beginInd, endInd);
//
//                string rewriteAllPage = CutStringBegin.Substring(endInd);
//
//                Console.WriteLine(result);
//
//        }
//
//
//        #endregion

    }
}