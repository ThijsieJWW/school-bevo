using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    Score_Scripts score_script;
    public GameObject Won_table;

    // Start is called before the first frame update
    void Start()
    {
        Won_table.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (score_script.Current_Score == 20)
        {
            SceneManager.LoadScene("Lvl2");
        }
    }

    public void Lvl1_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
    }

    public void NextLVL_button()
    {
        SceneManager.LoadScene("Lvl2");
    }

    public void main_Menu()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}