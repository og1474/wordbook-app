using System.Collections.Generic;

public class WordService
{
    //単語を保存するリスト
    private List<(string Word, string Meaning)> words = new();

    public void AddWord(string word, string meaning)
    {
        words.Add((word, meaning));
    }
    public List<(string Word, string Meaning)> GetWords()
    {
        return words;
    }
}