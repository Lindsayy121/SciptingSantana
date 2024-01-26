using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        SomeClass myClass = new SomeClass();

        //The specific add method called will depend on
        //the arguments passed in.
        myClass.Add(1, 2);
        myClass.Add("Hello ", "World");
    }
}
