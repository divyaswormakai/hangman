using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SingleScript : MonoBehaviour
{
    [System.Serializable]public class words
    {
        public string word;
        public string hint;
    };

    public List<words> sets;
    void Start()
    {
        int rand = Random.Range(0, sets.Count);
        words temp = sets[rand];
        GetComponentInChildren<MultiGame>().SetWord(temp.word.ToUpper(), temp.hint);
        SceneManager.LoadScene("MultiGame");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
