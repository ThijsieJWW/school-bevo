using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Assets.scripts.CharacterMenu;


public class CharSelect : MonoBehaviour
{
    public GameObject[] Characters;
    public Button NextBtn;
    public Button PrevBtn;
    public Button SelectBtn;

    private int currChar;

    // Start is called before the first frame update
    void Start()
    {
        currChar = 0;
        NextBtn.onClick.AddListener(Next);
        PrevBtn.onClick.AddListener(Prev);
        SelectBtn.onClick.AddListener(Select);
    }

    void UpdateSprites()
    {
        for (int i = 0; i < Characters.Length; i++)
        {
            Characters[i].transform.position = new Vector3((i - currChar) * 5, 1.3f, 0);
        }
    }

    void Next()
    {
        if (currChar<=Characters.Length-2) {
            currChar++;
        }
        UpdateSprites();
    }

    void Prev()
    {
        if (currChar>=1)
        {
            currChar--;
        }
        UpdateSprites();
    }

    void Select()
    {
        CharacterSettings.SelectedCharacter = currChar;
        SceneManager.LoadScene(2);
    }
}
