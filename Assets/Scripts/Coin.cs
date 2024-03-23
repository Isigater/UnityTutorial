using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0f, 1f, 0f, Space.World);
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("trigger");
        if (collider.gameObject.name == "PlayBall")
        {
            gameManager.AddPoint();
            Destroy(this.gameObject);
            Destroy(this);
        }
    }
}
