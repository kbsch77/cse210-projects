class Referance{
    private string _referance;
    private List<string> _referanceList = new List<string>(){
        "1 Nephi 3:7",
        "D&C 10:5",
        "John 3:5",
        "Isaiah 1:18",
        "Alma 32:21",
        "Amos 3:7",
        "John 14:15"
    };
    private string _multiReferance = "Proverbs 3:5–6";

    public string GetRandReferance(int index){ //getter for a _referanceList index
        _referance = _referanceList[index];
        return _referance;
    }
    public int GetListLength(){ //gets the _referanceList length
        int listLength = _referanceList.Count();
        return listLength;
    }
    public string GetMultiReferance(){ //getter for _multiReferance
        return _multiReferance;
    }
}