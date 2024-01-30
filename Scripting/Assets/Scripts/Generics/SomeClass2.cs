using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass2 : MonoBehaviour
{
    //Here is a generic method. The generic
    //type 'T'. This "t" will be replaced at runtime
    //with an actual type
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
