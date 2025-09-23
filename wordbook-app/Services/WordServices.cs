using System.Collections.Generic;

public class WordService
{
    //単語を保存するリスト
    private List<(string Word, string Meaning, string Tag)> words = new();

    public void AddWord(string word, string meaning, string tag)
    {
        words.Add((word, meaning, tag));
    }
    public List<(string Word, string Meaning, string tag)> GetWords()
    {
        return words;
    }
}