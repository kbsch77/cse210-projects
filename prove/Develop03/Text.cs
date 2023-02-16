class Text{
    private string _text;
    private List<string> _verseTexts = new List<string>(){
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "Pray always, that you may come off conqueror; yea, that you may conquer Satan, and that you may escape the hands of the servants of Satan that do uphold his work.",
        "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.",
        "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.",
        "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.",
        "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.",
        "If ye love me, keep my commandments."
    };
    private List<string> _multiVerseTexts = new List<string>(){
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
        "In all thy ways acknowledge him, and he shall direct thy paths."
    }; 

    public string GetRandText(int index){ //getter for a _verseTexts index
        _text = _verseTexts[index];
        return _text;
    }
    public string GetMultiVerseText(int index){ //getter for a _multiVerseTexts index
        return _multiVerseTexts[index]; 
    }
}