using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple myApple = new Apple();

        //Apple version of the methods
        //override the fruit versions. Since the Apple
        //version calls the fruit version with
        //the base keywword, bot are called

        myApple.SayHello();
        myApple.Chop();

        //overrideing iss useful in a polym orphic situation
        //methods of the fruit class are virtual and
        //the methods of trhe apple class are override when
        //we upcast an apple into a fruit, the apple version of the 
        //methods are used

        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
