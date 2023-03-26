using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
//using System.Threading;
using System.Windows.Forms;

namespace EnglishGame


{
    public partial class LearnEnglish : Form
    {
        public static Library labrary = new Library();
        private static int userInputX;
        private Timer colorTimer = new Timer();
        private Timer movePositionTimer = new Timer();
        private static int colorCount = 0;
        private static int moveCount = 0;
        private static int sizeOfText = 9;

        public LearnEnglish()
        {
            InitializeComponent();
            userInputX = userInputBox.Left;
            EnglishWordLabel.Text = labrary.EnglishWordsStack.Pop();
            InitializeTicks();
        }


       
        private void ShakeWrong()
        {
           
            movePositionTimer.Start();


        }
        private void MovePositionTimer_Tick(object sender, EventArgs e)
        {
            if (moveCount <= 3)
            {
                if (moveCount % 2 == 0)
                {
                    userInputBox.Left += 3;

                }
                else
                {
                    userInputBox.Left -= 6;
                }
                moveCount++;
            }
            else
            {
                userInputBox.Left = userInputX;
                movePositionTimer.Stop();
                moveCount = 0;
            }

        }

      
        private void InitializeTicks()
        {
            colorTimer.Interval = 100;
            colorTimer.Tick += new EventHandler(ColorTimer_Tick);
            movePositionTimer.Interval = 50;
            movePositionTimer.Tick += new EventHandler(MovePositionTimer_Tick);
        }
        private void CorrectAnimation()
        {
            
            colorTimer.Start();

        }
        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            EnglishWordLabel.Font = new Font("Arial Rounded MT Bold", sizeOfText);
            sizeOfText++;
            if (colorCount <= 5)
            {
                if(colorCount % 2 == 0)
                {
                    EnglishWordLabel.ForeColor= Color.Green;
                }
                else
                {
                    EnglishWordLabel.ForeColor = Color.Black;
                }
                colorCount++;
            }
            else
            {
                userInputBox.ForeColor = Color.Black;
                EnglishWordLabel.Text = labrary.EnglishWordsStack.Pop();
                colorCount = 0;
                sizeOfText = 9;
                colorTimer.Stop();
            }

        }

        private void userInputBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (labrary.CheckTheWord(EnglishWordLabel.Text, userInputBox.Text))
                {
                    CorrectAnimation();
                    
                   
                    CleanInputBox();
                }
                else
                {
                    ShakeWrong();
                }

            }
        }



        private void CleanInputBox()
        {
            userInputBox.Clear();
        }
    }
    
}
public class Library
{
    private Dictionary<string, List<string>> dictionary;
    private Stack<string> stackWords;
    //todo still doesnt work
    private static string path = @"C:\Users\mvmac\source\repos\LearnEnglish\ProccesData\data\WordsAlignment.txt";



    public Library()
    {
        GenerateDictionary();
        //in the stack
        GenerateTheWords();

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
        int equallyIndex = 0;
        char[] separators = new char[1] { ',' };

        using (reader)
        {
            while (true)
            {
                line = reader.ReadLine();
                if (line == null) break;
                equallyIndex = line.IndexOf('=');
                enWord = line.Substring(0, equallyIndex);
                string newSTR = line.Substring(equallyIndex + 1);
                bgWords = newSTR.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (this.dictionary.ContainsKey(enWord))
                {
                    continue;
                }
                this.dictionary.Add(enWord, bgWords);
            }
        }
    }
    public bool CheckTheWord(string enWord, string bgWord)
    {
        List<string> answers = this.dictionary[enWord];
        foreach (var answer in answers)
        {
            if (answer == bgWord) return true;
        }
        return false;

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

