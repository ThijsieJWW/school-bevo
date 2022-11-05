using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class math_problem_code : MonoBehaviour
{
    //two variables for the 2 difrent numbers
    private int first_num;
    private int second_num;
    public int answer;
    //max en min numbers
    public int max_num = 100;
    public int min_num = 1;
    //refrence to the UI
    public Text num_1;
    public Text num_2;

    public void calculte_diff_num()
    {
        first_num = Random.Range(max_num + 1, min_num + 1);
        second_num = Random.Range(max_num + 1, min_num + 1);
        answer = first_num + second_num;
        Debug.Log("first num = " + first_num);
        Debug.Log("second num = " + second_num);
        Debug.Log("Answer = " + answer);
        num_1.text = first_num.ToString();
        num_2.text = second_num.ToString();  
    }
}
