using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScaler : MonoBehaviour
{
    public float ScaleAmout = 1.2f;
    public float normalAmount = 1f;
    public void pointerEnter()
    {
        transform.localScale = new Vector2(ScaleAmout, ScaleAmout);
    }

    public void pointerExit()
    {
        transform.localScale = new Vector2(normalAmount, normalAmount);
    }
}
