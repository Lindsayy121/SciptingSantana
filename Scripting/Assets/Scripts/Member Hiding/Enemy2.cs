using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Humanoid
{
    //Hides the humanoid version
    new public void Yell()
    {
        Debug.Log("Enemy versoin of the Yell() method");
    }
}
