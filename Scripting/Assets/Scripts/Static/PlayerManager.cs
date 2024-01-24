using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    void Start()
    {
        //can access a static variable by using the class name
        //and the dot operator
        int x = Player2.playerCount;
    }
}
