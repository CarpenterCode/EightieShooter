using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
    Text countScore, countTime;

    public int scoreToWin;
    public int score;

    float myTimer;

    //Counting Time;
    private void Start()
    {
        countScore = GameObject.FindGameObjectWithTag("ScoreCounter").GetComponent<Text>();
        countTime = GameObject.FindGameObjectWithTag("TimeCounter").GetComponent<Text>();
        InvokeRepeating("AddTime", 1, 1);
    }
    void AddTime()
    {
        myTimer++;
    }


    private void Update()
    {
        ConvertText();
        CheckWin();
    }

    //Convert Score and Timer to UI text;
    void ConvertText()
    {
        countScore.text = score.ToString();
        countTime.text = myTimer.ToString();
    }

    //Checking if score is enough to open gate to another level;
    void CheckWin()
    {
        if (score >= scoreToWin)
        {
            this.gameObject.GetComponent<MyManager>().LevelWinMethod();
        }
            
    }

    public void StopTimer()
    {
        CancelInvoke();
    }

}
