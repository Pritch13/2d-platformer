﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    

    public GameObject RandomFloor;
    public float respawnTime;
    private Vector2 screenBounds;
    
    void Start() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        StartCoroutine(floorWave());
    }

    void SpawnFloor() {
        GameObject newFloor = Instantiate(RandomFloor);
        newFloor.transform.position = new Vector2(screenBounds.x + 1, GameObject.Find("Floor").transform.position.y);
        Destroy(newFloor, 5f);
    }
    
    IEnumerator floorWave() {
        while(true){
            yield return new WaitForSeconds(Random.Range(0.4f, 1.5f));
            SpawnFloor();
        }
    }
}
