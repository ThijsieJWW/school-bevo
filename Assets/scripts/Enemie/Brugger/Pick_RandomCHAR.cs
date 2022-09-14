using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_RandomCHAR : MonoBehaviour
{
    public SpriteRenderer SR;
    public Sprite BoyN1;
    public Sprite BoyN2;
    public Sprite GirlN1;
    public Sprite GirlN2;

    bool canPickRandom = true;
    //Sprite RandomSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canPickRandom == true)
        {
            PickRandom();
            canPickRandom = false;
            Invoke("ResetPickRandom", 3f);
        }
    }

    void ResetPickRandom()
    {
        canPickRandom = true;
    }

    void PickRandom()
    {
        string[] Random_Sprites = new string[] { "BoyN1", "BoyN2", "MeisjeN1", "MeisjeN2" };
        string Random_Sprite = Random_Sprites[Random.Range(0, Random_Sprites.Length)];
        if (Random_Sprite == "BoyN1")
        {
            SR.sprite = BoyN1;
        }

        if (Random_Sprite == "BoyN2")
        {
            SR.sprite = BoyN2;
        }

        if (Random_Sprite == "MeisjeN1")
        {
            SR.sprite = GirlN1;
        }

        if (Random_Sprite == "MeisjeN2")
        {
            SR.sprite = GirlN2;
        }
    }
}
