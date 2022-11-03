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
    public int level;
    private RectTransform viewtrans;
    private GameObject[] txtlist;
    private ServerCommunicator communicator;
    private Time startTime;

    // Start is called before the first frame update
    void Awake()
    {
        Won_table.SetActive(false);
        Time.timeScale = 1f;
        communicator = new ServerCommunicator();
        txtlist = new GameObject[0];
        viewtrans = view.GetComponent<RectTransform>();
        updateScores();
    }

    public void uploadScores(Score score)
    {
        StartCoroutine(communicator.sendPost(score));
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
        Debug.Log(scores);
        Debug.Log("Reset scores.");
        for (int i = 0; i < txtlist.Length; i++)
        {
            Destroy(txtlist[i]);
        }

        txtlist = new GameObject[0];
        Debug.Log("adding objects to list");
        for (int i =0; i < scores.Length; i++)
        {
            GameObject obj = GameObject.Instantiate(textprefab);
            obj.transform.SetParent(viewtrans);
            obj.GetComponent<Text>().text = scores[i].name + ": " + scores[i].score;
            obj.transform.position.Set(viewtrans.position.x, viewtrans.position.y+(i*20), 0);
            obj.SetActive(true);
            txtlist.Append(obj);
        }

        // upload scores
        float secs = Time.timeSinceLevelLoad;
        Score s = new Score();
        s.score = (int)secs;
        s.name = "Naamloos";
        s.level = level;
        Debug.Log("uploading score");
        uploadScores(s);
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