using System;

class Scripture
{
    private Random randomGenerator = new Random();
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text){
        Reference = _reference;
        string[] words = text.Split(" ");
        foreach (string word in words){
            Word nextWord = new Word(word);
            _words.Add(nextWord);
        }
        
    }

    public void HideRandomWords(int numberToHide){
        int totalWords = _words.Count();
        while (numberToHide > 0){
            int randomNumber = randomGenerator.Next(0,totalWords);

            while (_words[randomNumber].IsHidden()){
                randomNumber = randomGenerator.Next(0,totalWords);
                if(IsCompletelyHidden()){
                    _words[randomNumber].Show();
            }
            }

            _words[randomNumber].Hide();
            numberToHide -= 1;
        }
    }

    public string GetDisplayText(){
        string scritpureVerse = "";
        foreach (Word word in _words){
            string nextWord = word.GetDisplayText();
            scritpureVerse += $"{nextWord} ";
        }

        return scritpureVerse;
    }

    public bool IsCompletelyHidden(){
        bool isCompletelyHidden = false;
        int shownWordCount = 0;
        foreach (Word word in _words){
            bool isHidden = word.IsHidden();
            if (isHidden) {                   
            }
            else {
                shownWordCount += 1;
            }
        }
        if (shownWordCount == 0){
            isCompletelyHidden = true;
        }

        return isCompletelyHidden;
    }
}