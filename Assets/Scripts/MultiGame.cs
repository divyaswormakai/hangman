using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MultiGame : MonoBehaviour
{
    public TextMeshProUGUI wordtxt, hinttxt, lost;
    static string word;
    static string hint;
    public Button replay;
    int wordlength;
    List<int> index;
    int wrongCount = -1;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "MultiGame")
        {
            index = new List<int>();
            wordlength = word.Length;
            if (word.Length >= 4)
            {
                for (int i = 0; i < wordlength; i++)
                {
                    wordtxt.text += "_";
                    hinttxt.text = "Hint: " + hint;
                }
            }
            else
            {
                SceneManager.LoadScene("Multi");
            }
        }

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetWord(string words, string hints)
    {
        word = words;
        hint = hints;
    }

    public void CharPress()
    {
        string fullname = EventSystem.current.currentSelectedGameObject.name;
        EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Button>().interactable = false;
        char name = fullname[0];

        StringBuilder sb = new StringBuilder(wordtxt.text);
        for (int i = 0; i < wordlength; i++)
        {
            if (word[i] == name)
            {
                index.Add(i);
            }
        }
        if (index.Count > 0)
        {
            foreach (int i in index)
            {

                sb[i] = name;
            }
            wordtxt.text = sb.ToString();
            index.Clear();
            if (CheckWin())
            {
                lost.text = "YOU WON!!!";
                lost.gameObject.SetActive(true);
                replay.gameObject.SetActive(true);
                print("Win");
            }
        }
        
        else
        {
            wrongCount++;
            bool lose = GetComponentInChildren<Life>().HangIncrease(wrongCount);
            if (lose)
            {
                wordtxt.text = word;
                lost.gameObject.SetActive(true);
                replay.gameObject.SetActive(true);
            }
        }
    }

    bool CheckWin()
    {
        foreach(char i in wordtxt.text)
        {
            if(i == '_')
            {
                return false;
            }
        }
        return true;
    }

    public void ReplayClick()
    {
        SceneManager.LoadScene("Multi");
    }

}
