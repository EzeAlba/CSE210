using System;
using System.Runtime.InteropServices;

public class Library{

    //private int _option;
    private string _book;
    private int _chapter;
    private int _startVerse; 
    private int _endVerse;
    private string _scripture_text;

    /*public void SetOption(int option)
    {
        _option = option;
    }*/

    public void SetScripture(int option){
        if (option == 1)
        {
            _book = "Proverbs";
            _chapter = 3;
            _startVerse = 5; 
            _endVerse = 6;
            _scripture_text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";           
        }
        else if (option == 2)
        {
            _book = "1 Nephi";
            _chapter = 3;
            _startVerse = 7; 
            _endVerse = 7;
            _scripture_text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.";  
        }
        else if (option == 3)
        {
            _book = "Alma";
            _chapter = 37;
            _startVerse = 37; 
            _endVerse = 37;
            _scripture_text = "37 aCounsel with the Lord in all thy doings, and he will direct thee for bgood; yea, when thou liest down at night lie down unto the Lord, that he may watch over you in your sleep; and when thou risest in the cmorning let thy heart be full of thanks unto God; and if ye do these things, ye shall be lifted up at the last day.";  
        }
        else if (option == 4)
        {
            _book = "2 Nephi";
            _chapter = 31;
            _startVerse = 5; 
            _endVerse = 6;
            _scripture_text ="And now, if the Lamb of God, he being aholy, should have need to be baptized by water, to fulfil all righteousness, O then, how much more need have we, being unholy, to be cbaptized, yea, even by water! And now, I would ask of you, my beloved brethren, wherein the Lamb of God did fulfil all righteousness in being baptized by water?";  
        }
    }

    public string GetBook(){

        return _book;
    }
    public int GetChapter(){
        return _chapter;
    }
    public int GetStartVerse(){
        return _startVerse;
    }
    public int GetEndVerse(){
        return _endVerse;
    }

    public string GetScruptureText(){
         return _scripture_text;
    }
}