using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Scripts : MonoBehaviour
{
    int Start_Score = 0;
    public int Current_Score;

    // Start is called before the first frame update
    void Start()
    {
        Current_Score = Start_Score;
    }

    public void Score_update()
    {
        Current_Score++;
    }

}
