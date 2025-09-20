class Scripture
{
    private Reference _reference;
    private List<Word> _words;



    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }


    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }


    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }


    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
