using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    public GameObject WinText;
    public GameObject LoseText;

    // Start is called before the first frame update
    void Start()
    {

    }


    public void Lose()
    {
        if(gameObject.tag == "Virus")
        {
            GameOver();
        }
    }
    void Update()
    {
        if ((gameObject.GetComponent<Rigidbody>().velocity.x > 0.01 ||
          gameObject.GetComponent<Rigidbody>().velocity.y > 0.01) &&
          !gameObject.GetComponent<AudioSource>().isPlaying)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if (gameObject.GetComponent<AudioSource>().isPlaying)
        {
            gameObject.GetComponent<AudioSource>().Pause();

        }
    }

    public void GameOver()
    {
        gameObject.SetActive(true);
    }
}