using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoveAndSpawn : MonoBehaviour
{
    public float speed;
    public GameObject Coins;
    public float respawnTime;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        StartCoroutine(coinWave());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void SpawnCoin() {
        GameObject newCoin = Instantiate(Coins);
        newCoin.transform.position = new Vector2(screenBounds.x + 1, 0.3f);
    }
    
    IEnumerator coinWave() {
        while(true){
            yield return new WaitForSeconds(Random.Range(0.25f, 1.5f));
            SpawnCoin();
        }
    }
}
