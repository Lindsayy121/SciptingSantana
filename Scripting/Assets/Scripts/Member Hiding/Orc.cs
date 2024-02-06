using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy2
{
    //hides the enemy versoin
    new public void Yell()
    {
        Debug.Log("Orc versoin of the Yell() method");
    }
}
