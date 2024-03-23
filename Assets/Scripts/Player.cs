using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float force = 2;
    private Rigidbody rb;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.play) return;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-force, 0, 0), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(force, 0, 0), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, force), ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -force), ForceMode.Acceleration);
        }
    }

    public void PosReset()
    {
        this.gameObject.transform.position = new Vector3(0, 0.5f, 0);
        rb.velocity = Vector3.zero;
    }
}
