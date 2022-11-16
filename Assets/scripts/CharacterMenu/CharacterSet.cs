using Assets.scripts.CharacterMenu;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSet : MonoBehaviour
{
    int currchar;

    // Start is called before the first frame update
    void Start()
    {
        currchar = CharacterSettings.SelectedCharacter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
