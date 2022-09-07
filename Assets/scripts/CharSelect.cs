using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharSelect : MonoBehaviour
{
    public GameObject[] Characters;
    public Button NextBtn;
    public Button PrevBtn;

    private int currChar;

    // Start is called before the first frame update
    void Start()
    {
        currChar = 0;
        NextBtn.onClick.AddListener(Next);
        PrevBtn.onClick.AddListener(Prev);
    }

    void UpdateSprites()
    {
        Transform t;
        for (int i = 0; i < Characters.Length; i++)
        {
            t = Characters[i].GetComponent<Transform>();
            t.position.Set((currChar * i) * 5,0,0);
        }
    }

    void Next()
    {
        if (currChar + 1 < Characters.Length) {
            currChar++;
        }
    }

    void Prev()
    {
        if (currChar-1 > 0)
        {
            currChar--;
        }
    }
}
