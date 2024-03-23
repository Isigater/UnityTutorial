using System.Collections;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int span = 3;
    [SerializeField] private GameObject coin = null!;
    [SerializeField] private int point = 0;
    [SerializeField] private GameObject panel = null!;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Player player = null!;

    System.Random random = new System.Random();
    public bool play = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ManageSpawnCoin");
        text.text = "Score : " + point.ToString();
    }
    public void GameOver()
    {
        play = false;
        panel.SetActive(true);
    }

    public void AddPoint()
    {
        point++;
        text.text = "Score : " + point.ToString();
    }
    public int GetPoint()
    {
        return point;
    }

    private void SpawnCoin()
    {
        GameObject newCoin = Instantiate(coin);
        newCoin.gameObject.transform.position = new Vector3(random.Next(-9, 9), 0.5f, random.Next(-9, 9));
    }

    IEnumerator ManageSpawnCoin()
    {
        while (play)
        {
            yield return new WaitForSeconds(span);
            SpawnCoin();
        }
    }

    public void Retry()
    {
        point = 0;
        text.text = "Score : " + point.ToString();
        panel.SetActive(false);
        player.PosReset();
        play = true;
        StartCoroutine("ManageSpawnCoin");
    }
}
