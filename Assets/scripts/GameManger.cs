using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameManger : MonoBehaviour
{
    Score_Scripts score_script;
    public GameObject Won_table;
    public GameObject textprefab;
    public GameObject view;
    private RectTransform viewtrans;
    private GameObject[] txtlist;
    private ServerCommunicator communicator;

    // Start is called before the first frame update
    void Start()
    {
        Won_table.SetActive(false);
        Time.timeScale = 1f;
        updateScores();
        communicator = new ServerCommunicator();
        txtlist = new GameObject[0];
        viewtrans = view.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (communicator.getScores().Length <= 1)
        {
            try
            {
                StartCoroutine(communicator.updateScores());
            } catch (Exception e)
            {
                Debug.LogException(e);
            }
        }
    }

    public void uploadScores(Score score)
    {
        communicator.sendPost(score);
    }

    public void updateScores()
    {
        StartCoroutine(communicator.updateScores());
    }

    public Score[] getScores()
    {
        return communicator.getScores();
    }

    public void onFinish()
    {
        // show list
        Score[] scores = getScores();
        for (int i = 0; i < txtlist.Length; i++)
        {
            Destroy(txtlist[i]);
        }

        txtlist = new GameObject[0];
        for (int i =0; i < scores.Length; i++)
        {
            GameObject obj = GameObject.Instantiate(textprefab);
            obj.transform.SetParent(viewtrans);
            obj.SetActive(true);
            txtlist.Append(obj);
        }
    }

    public void Lvl1_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
        onFinish();
    }

    public void Lvl2_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
        onFinish();
    }

    public void Lvl3_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
        onFinish();
    }

    public void Lvl4_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
        onFinish();
    }

    public void Lvl5_finish()
    {
        Time.timeScale = 0f;
        Won_table.SetActive(true);
        onFinish();
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