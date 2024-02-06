using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy2();
        Humanoid orc = new Orc();

        //each humanoid variable contains
        //a refernece to a different class
        //in the inheritance hierarchy, yet
        //each calls the humanoid Yell() method
        human.Yell();
        enemy.Yell();
        orc.Yell();

    }
}
