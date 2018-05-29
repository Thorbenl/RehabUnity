using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnTouch : MonoBehaviour {
    public GameObject hand1;
    public GameObject hand2;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject greeting;
    public GameObject instructions;
    public GameObject success;
    public int animcounter;


    // Use this for initialization
    void Start () {
        animcounter = 0;
    }


    // Update is called once per frame
    void Update () {
        //Check if feet GameObjects are touching 
        bool touching = CollisionDetection.IsTouching(hand1, cube1) && CollisionDetection.IsTouching(hand2, cube2);

        if (touching)
        {    

            cube1.gameObject.GetComponent<Renderer>().material.color = Color.green;
            cube2.gameObject.GetComponent<Renderer>().material.color = Color.green;
            cube1.GetComponent<Animation>().Play();
            cube2.GetComponent<Animation>().Play();
            animcounter ++;
            Destroy(greeting, 1);
            Destroy(instructions, 1);

            if(animcounter >= 400)
            {
                success.GetComponent<Renderer>().enabled = true;
            }

        }
        else
        {
            cube1.gameObject.GetComponent<Renderer>().material.color = Color.white;
            cube2.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        Debug.Log(animcounter);
    }
}
