using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass2 myClass = new SomeClass2();

        //In order to usse this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}
