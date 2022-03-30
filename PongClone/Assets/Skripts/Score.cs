using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    //public Text Mytext;
    // Start is called before the first frame update
    private int number1 = 0;
    private int number2 = 0;

    public GameObject ScoreText1;
    public GameObject ScoreText2;

    // Update is called once per frame
    void Update()
    {
        if (number1 == 5 || number2 == 5)
            SceneManager.LoadScene(2);
    }

    private void FixedUpdate()
    {
        Text UIPlayer1Text = this.ScoreText1.GetComponent<Text>();
        Text UIPlayer2Text = this.ScoreText2.GetComponent<Text>();
        UIPlayer1Text.text = number1.ToString();
        UIPlayer2Text.text = number2.ToString();
    }

    public void Score1()
    {
        this.number1++;
    }
    public void Score2()
    {
        this.number2++;
    }

}
