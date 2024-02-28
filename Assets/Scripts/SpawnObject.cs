using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    private SpriteRenderer sprite;
    [SerializeField] private float distance;
    [SerializeField] private Text pointText;

    private int point = 0;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Rat")
        {
            point++;
            pointText.text = "Rat: "+point;
            MoveToRandomPosition();
        }
    }

    void MoveToRandomPosition()
    {
        Vector2 newPosition = new Vector2(
            Random.Range(-distance, distance),
            Random.Range(-distance, distance)
        );

        transform.position = newPosition;
        RandomColor();
    }
    void RandomColor(){
        int r = Random.Range(0, 255);
        int g = Random.Range(0, 255);
        int b = Random.Range(0, 255);
        sprite.color = new Color(r / 255f, g / 255f, b / 255f);
    }
}

