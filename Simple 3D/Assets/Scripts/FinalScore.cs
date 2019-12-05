using UnityEngine.UI;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public Transform player;
    public Text finalScore;

   


    void Update()
    {
        finalScore.text = "Your Score: " + player.position.z.ToString("0");
    }

}
