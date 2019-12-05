using UnityEngine.UI;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public Transform player;
    public Text finalScore;
    public float finalScoreValue;

    public void setFinalScore(float finalScoreVal)
    {
        finalScoreValue = finalScoreVal;
    }


    void Update()
    {
        //finalScore.text = "Your Score: " + player.position.z.ToString("0");
       // finalScore.text = "Your Score: " + finalScoreVal.ToString("0");
    }

}
