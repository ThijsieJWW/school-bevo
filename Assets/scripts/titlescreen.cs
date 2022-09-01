using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titlescreen : MonoBehaviour
{
    public Button ExitButton;
    public Button PlayButton;

    void Start()
    {
        ExitButton.onClick.AddListener(Exit);
        PlayButton.onClick.AddListener(Play);
    }


    void Play()
    {
        SceneManager.LoadScene(1);
    }

    void Exit()
    {
        Application.Quit();
    }
}
