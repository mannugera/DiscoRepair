using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {
    public GameObject recharge;
    public Color Blue = Color.blue;
    public Color Red = Color.red;
    public Color Yellow = Color.yellow;
    public Color Magenta = Color.magenta;
    public Color Orange;
    public Canvas timerText;


    private Light rechargeLight;
    public GameObject[] floorCubes = new GameObject[9];
    private float floorLights;
    private float[] lights = { 1,2,3,4};
	// Use this for initialization
	void Awake () {
        rechargeLight = GetComponent<Light>();
        StartTimer();
        AssignLight();
    }

    void StartTimer()
    {
        for(int i = 3; i>0; i--)
        {
            
        }
    }
	
	// Update is called once per frame
	void Update () {
        Score();
        LightOff();
        Repair();
       


    }

    void AssignLight()
    {
        int x = Random.Range(0, 3);

        switch (x) {

            case 0:
                


        }         


   void Score()
    {

        // write conditions for this to work.
        int score = 0;

        if ()
        {
            //if blue light is repaired
            //increase score by 5
            score = score + 5;
        } 

        else if ()
        {
            //if magenta light is repaired increase score by 10
            score = score + 10;
        }

        else if ()
        {
            score += 20; // orange score
        }

        else
        {
            score += 40; // Red score
        }
    }

    void LightOff()
    {
            GameObject tile = GameObject[Random.Range(0, floorCubes.Length)];
    }
}
