using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

[Serializable]
public struct Score {
    public string name;
    public int score;
    public int level;
}

public struct ScoreTable
{
    public List<Score> scores;
}

/// <summary>
/// sends post/get requests to upload/download scores.
/// </summary>
public class ServerCommunicator
{
    public string Source = "https://schoolbevo.pythonanywhere.com";
    public int Level = 1;
    private ScoreTable scores;

    private void Start()
    {
        scores = new ScoreTable();
    }

    public IEnumerator sendPost(Score score)
    {
        WWWForm form = new WWWForm();
        form.AddField("score", score.score);
        form.AddField("name", score.name);
        form.AddField("level", score.level);
        UnityWebRequest req = UnityWebRequest.Post(Source+"/post", form);
        Debug.Log("Sending request with form:"+form);
        yield return req.SendWebRequest();
    }

    public IEnumerator updateScores()
    {
        Debug.Log("starting download");
        UnityWebRequest req = UnityWebRequest.Get(Source+"/get/"+Level.ToString());
        yield return req.SendWebRequest();
        if (req.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log("error while connecting with server.");
        } else
        {
            Debug.Log("successfully downloaded scores.");
            ParseJsonScores(req.downloadHandler.text);
            Debug.Log("successfully parsed scores.");
        }
    }

    private void ParseJsonScores(string jsonlist)
    {
        Debug.Log(jsonlist);
        scores = JsonUtility.FromJson<ScoreTable>(jsonlist);
    }

    public Score[] getScores()
    {
        return scores.scores.ToArray();
    }
}
