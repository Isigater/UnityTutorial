using UnityEngine;

public class JammingWall : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("trigger");
        if (collision.gameObject.name == "PlayBall")
        {
            Debug.Log("gameOver");
            gameManager.GameOver();
        }
    }
}
