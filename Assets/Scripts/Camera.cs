using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Camera m_Camera = null!;
    [SerializeField] private GameObject player = null!;

    private Vector3 playerPos = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        m_Camera.transform.position = new Vector3(playerPos.x, playerPos.y + 4, playerPos.z - 4);
    }
}
