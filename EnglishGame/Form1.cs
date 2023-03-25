using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace EnglishGame


{
    public partial class LearnEnglish : Form
    {
        public LearnEnglish()
        {
            InitializeComponent();
            var labrary = new Library();
           // EnglishWordLabel.Text = labrary.EnglishWordsStack.Pop();



            


        }


    }
    public class Library
    {
        private Dictionary<string, List<string>> dictionary;
        private Stack<string> stackWords;
        private static string path = @"C:\Users\Milen Machkov\OneDrive\Работен плот\aEmpty\03.EN\wordsAlignment.txt";


        public Library()
        {
            // GenerateDictionary();
            //in the stack
            //GenerateTheWords();
            
        }
        public Stack<string> EnglishWordsStack
        {
            get
            {
                return this.stackWords;
            }
        }
        private void GenerateDictionary()
        {
            this.dictionary = new Dictionary<string, List<string>>();
            StreamReader reader = new StreamReader(path);
            var line = string.Empty;
            string enWord = string.Empty;
            List<string> bgWords = new List<string>();
            using (reader)
            {
                line = reader.ReadLine();


            }


        }
        private void GenerateTheWords()
        {
            this.stackWords = new Stack<string>();
            foreach (var item in dictionary.Keys)
            {
                this.stackWords.Push(item);
            }
        }
        

       

    }
}
