using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit2 : MonoBehaviour
{
    public Fruit2()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    //methods are virtual and thus can be overridden
    //in child classes
    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
