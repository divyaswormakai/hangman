using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public Sprite[] sprites;
    public Image man;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool HangIncrease(int count)
    {
        print(count);
        man.sprite = sprites[count];
        if (count >= sprites.Length-1M)
        {
            return true;
        }
        return false;
        
    }
}
