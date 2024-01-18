using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private void Start()
    {
        Player myPlayer = new Player();


        //Propertirs can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}
