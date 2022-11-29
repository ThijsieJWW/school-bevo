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
    public Text input_text;
    //variable to store the answer from the Player
    public string player_answer;
    //refrences
    public ISENDOORN_script isen_script;
    //setting bool of you can press enter to treu or false
    private bool Can_press_enter = false;


    public void calculte_diff_num()
    {
        first_num = Random.Range(max_num + 1, min_num + 1);
        second_num = Random.Range(max_num + 1, min_num + 1);
        answer = first_num + second_num;
        Debug.Log("Answer: " + answer);
        num_1.text = first_num.ToString();
        num_2.text = second_num.ToString();
        Can_press_enter = true;
        Invoke("reset_enter_press", 5f);
    }

    void reset_enter_press()
    {
        Can_press_enter = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Return) && Can_press_enter == true)
        {
            check_answer();
            Can_press_enter = false;
        }
    }

    public void check_answer()
    {
        player_answer = input_text.GetComponent<Text>().text;
        string answer_to_string = answer.ToString();
        if (player_answer == answer_to_string)
        {
            isen_script.TakeDamage(10);
            FindObjectOfType<audiomanger>().Play("correct");
        }
        else
        {
            FindObjectOfType<audiomanger>().Play("incorrect");
        }
    }
}