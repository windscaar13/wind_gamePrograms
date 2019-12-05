
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject player;
    public Transform playerTransform;
    public GameObject finalScoreScr;
    public Vector3 arrestMotion = Vector3.zero;
    

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("Game Over!");
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {        Debug.Log("Level Complete!");
        //arresting the player object motion when it hits the end trigger
        player.GetComponent<Rigidbody>().velocity = arrestMotion;
        player.GetComponent<Rigidbody>().angularVelocity = arrestMotion;

        player.GetComponent<PlayerMovement>().enabled = false;
        completeLevelUI.SetActive(true);
    }

}
