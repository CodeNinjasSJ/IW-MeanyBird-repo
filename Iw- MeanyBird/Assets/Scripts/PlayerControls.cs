using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    [Header("Game Controller Object for controlling the game")]
    public GameController GameController;
    [Header("Default Velocity")]
    public float Velocity = 5;
    private Rigidbody2D rb;
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponent<GameController>();
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        objectHeight =
        transform.GetComponent<SpriteRenderer>().bounds.size.y/2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
