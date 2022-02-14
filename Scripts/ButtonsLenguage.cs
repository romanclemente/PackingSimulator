using System.Collections;
using System.Collections.Generic;

public class ButtonsLenguage
{
    List<string> myContent = new List<string>();

    public ButtonsLenguage(string myContent)
    {
        this.myContent = myContent;
    }

    public string getWord(int index){
        string tmp = myContent[index];
        return tmp;
    }
    
    public List<string> getWords(){
        return myContent;
    }
    
    public void setWord(string word){
        myContent.Add(word);
    }
}
