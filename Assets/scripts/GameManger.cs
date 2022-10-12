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
        
    }

    public void Lvl1_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
    }

    public void Lvl2_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
    }

    public void Lvl3_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
    }

    public void Lvl4_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
    }

    public void Lvl5_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
    }

    public void NextLVL_button(string level)
    {
        Debug.Log("Next level");
        SceneManager.LoadScene(level);
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