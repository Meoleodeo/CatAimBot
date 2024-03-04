using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameTilemapSwitcher : MonoBehaviour
{
    private float switchInterval = 5f;
    public Tilemap[] tilemaps;

    public Tilemap currentTilemap;
    private int currentTilemapIndex = 0;
    private float timer;

    void Start()
    {
        timer = switchInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SwitchTilemap();
            timer = switchInterval;
        }
    }

    void SwitchTilemap()
    {
        if (tilemaps.Length > 0)
        {
            if (currentTilemap != null)
            {
                currentTilemap.gameObject.SetActive(false);
            }
            currentTilemapIndex = Random.Range(0,100) % tilemaps.Length;
            currentTilemap = tilemaps[currentTilemapIndex];
            currentTilemap.gameObject.SetActive(true);
        }
    }
}
