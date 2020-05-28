using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMoveAndSpawn : MonoBehaviour
{
    public GameObject Coins;
    public float respawnTime;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        StartCoroutine(coinWave());
    }

    void SpawnCoin() {
        GameObject newCoin = Instantiate(Coins);
        newCoin.transform.position = new Vector2(screenBounds.x + 6, Random.Range(1,4));
    }
    
    IEnumerator coinWave() {
        while(true){
            yield return new WaitForSeconds(Random.Range(0.25f, 1.5f));
            SpawnCoin();
        }
    }
}
