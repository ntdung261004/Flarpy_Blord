using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BirdFlyScript : MonoBehaviour
{
    public Rigidbody2D myRig;
    private float timeFly = 0;
    public LogicScript logic;
    public LogicScript highestScoreLogic;
    public Text highestScore;

    // Start is called before the first frame update
    void Start()
    {
        myRig.velocity = Vector2.up * 5;
        logic = gameObject.GetComponent<LogicScript>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFly < 1)
        {
            timeFly = timeFly + Time.deltaTime;
        }
        else
        {
            myRig.velocity = Vector2.up * 5;
            timeFly = 0;
        }



    }
}
