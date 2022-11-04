using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Play play;
    [SerializeField] private float speed;
    [SerializeField] private float way;
    void Start()
    {
        play = GameObject.FindObjectOfType<Play>();
        speed = Play.speed;
        way = Play.way;
    }

    // Update is called once per frame
    void Update()
    {
        way -= speed*Time.deltaTime;
        transform.Translate(Vector2.right * speed *Time.deltaTime);
        if(way < 0){
            Destroy(gameObject);
        }
    }
}
