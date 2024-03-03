using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameTilemapSwitcher : MonoBehaviour
{
    [SerializeField] public float switchInterval;
    public Tilemap[] tilemaps;

    private Tilemap currentTilemap;
    private int currentTilemapIndex = 0;
    private float timer;

    void Start()
    {
        timer = switchInterval;
        SwitchTilemap();
        currentTilemap.gameObject.SetActive(false);
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

            currentTilemapIndex = (currentTilemapIndex + 1) % tilemaps.Length;
            currentTilemap = tilemaps[currentTilemapIndex];
            currentTilemap.gameObject.SetActive(true);
        }
    }
}
