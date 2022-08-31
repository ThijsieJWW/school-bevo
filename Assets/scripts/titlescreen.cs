using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class titlescreen : MonoBehaviour
{
    public Button ExitButton;

    void Start()
    {
        ExitButton.onClick.AddListener(Exit);
    }

    void Exit()
    {
        Application.Quit();
    }
}
