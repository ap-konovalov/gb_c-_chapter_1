using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve
{
    [Serializable]
    public class Question
    {
        private string text;
        private bool trueFalse;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public bool TrueFalse
        {
            get { return trueFalse; }
            set { trueFalse = value; }
        }

        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            this.text = Text;
            this.trueFalse = TrueFalse;
        }
    }

    public class TrueFalse
    {
        private string fileName;
        private List<Question> list;

        public string FileName
        {
            set { fileName = value; }
        }

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text,trueFalse));
        }

        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0)
            {
                list.RemoveAt(index);
            }
        }

        public Question this[int index]
        {
            get { return list[index]; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream,list);
            fStream.Close();
        }

        public void Save(string _filename)
        {
            fileName = _filename;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}