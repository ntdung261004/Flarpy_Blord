using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRig;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public AudioSource audSource;
    public AudioClip WingSound;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRig.velocity = Vector2.up * flapStrength;
            audSource.PlayOneShot(WingSound);
        }

        if(transform.position.y > 18 ||  transform.position.y < -18)
        {
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
