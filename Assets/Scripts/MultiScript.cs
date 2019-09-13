using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
    
public class MultiScript : MonoBehaviour
{
    public TextMeshProUGUI error;
    public TMP_InputField inputWord,hintWord;
    public Button setWord, setHint, play;

    string wordstr,hintstr,words;
    bool wordBool, hintBool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }   
    }

    void CheckForPlayBtn()
    {
        if(wordBool && hintBool)
        {
            play.gameObject.SetActive(true);
        }
    }

    public void SetWord()
    {
        wordstr = inputWord.text;
        if(wordstr.Length <= 4)
        {
            error.text = "Please input word more than 4 letters";
            inputWord.text = "";
        }
        else
        {
            wordBool = true;
            error.text = "Word Set";
            CheckForPlayBtn();
        }
    }

    public void SetHint()
    {
        hintstr = hintWord.text;
        if (hintstr.Length <= 1)
        {
            error.text = "Please input hint more than 4 letters";
            hintWord.text = "";
        }
        else
        {
            hintBool = true;
            error.text = "Hint Set";
            CheckForPlayBtn();
        }
    }

    public void ReplayBtn()
    {
        SceneManager.LoadScene("Multi");
    }

    public void PlayBtn()
    {
        if(wordBool && hintBool)
        {
            print("Both ok");
            wordstr = wordstr.ToUpper();
            GetComponentInChildren<MultiGame>().SetWord(wordstr, hintstr);
            SceneManager.LoadScene("MultiGame");
        }
        else
        {
            error.text = "Enter word and hint";
        }
    }
}
