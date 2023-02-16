class Scripture{
    private List<string> _words = new List<string>();
    private List<int> _removedIndex = new List<int>();
    private string _referance;
    private string _text;

    public Scripture(){ //single-verse constructor
        Referance scriptReferance = new Referance();
        Text scriptText = new Text();
        int randScriptureNum = Randomizer(scriptReferance.GetListLength());

        //Selects a random scripture from the list in the Referance & Text classes
        _referance = scriptReferance.GetRandReferance(randScriptureNum);
        _text = scriptText.GetRandText(randScriptureNum);
    }
    public Scripture(string referance, string verse1, string verse2){ //multiple verse scripture constructor
        _referance = referance;
        _text = (verse1 + " " + verse2);
    }

    public void HideWords(){
        Console.Clear();
        SplitText();
        
        //local variables
        int textLength = GetWordLength(_text);
        int wordsCount = _words.Count();
        string newText = "";
        int counter = 0;

        //replaces three new random words
        do{
            int index = GetRandIndex(wordsCount);
            string word = _words[index];
            int wordLength = GetWordLength(word);
            string removedWord = "";

            foreach(int letter in word){
                removedWord = (removedWord + "_");
            }
            _words[index] = removedWord;

            counter ++;
        }while(counter !=3);
        

        //replaces scripture text with the redacted text
        foreach(string word in _words){
            newText = (newText + word + " ");
        }
        // resets _text for future iterations
        _text.Remove(textLength);
        _text = newText;
    }

    public void Display(){ //displays _referance and _text to user
        Console.WriteLine($"{_referance} {_text}");
        Console.WriteLine();
    }

    private void SplitText(){ //prepares text for HideWords
        _words = _text.Split(" ").ToList();
    }

    private int GetWordLength(string word){ //gets a word's length for HideWords
        int wordLength = word.Length;
        return wordLength;
    }

    private int GetRandIndex(int range){ //gets new random indexes for HideWords
        bool newIndex = false;
        int index = 0;

        while(!newIndex){
            index = Randomizer(range);
            if (!_removedIndex.Contains(index)){
                newIndex = true;
            }
        }
        _removedIndex.Add(index);
        return index;
    }

    private static int Randomizer(int range){ //random number generator
        Random random = new Random();
        int randInt = random.Next(range);
        return randInt;
    }

    public Boolean EndMemorization(){ //ends program when all words are hidden
        int wordCount = _words.Count();
        int indexCount = _removedIndex.Count();
        if(wordCount <= indexCount){
            return false;
        }
        else return true;
    }
}