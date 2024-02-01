using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //lets illustrate inheritance with the 
        //default constructors.
        Debug.Log("Creating the fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myApple = new Apple();

        //call the methods of the Fruit class
        myFruit.SayHello();
        myFruit.Chop();

        //call methods of the apple class
        //notice that class apple has access to all
        //of the public methods of class Fruit
        myApple.SayHello();
        myApple.Chop();

        //Illustrate inheritance with
        //constructors that read in a string
        Debug.Log("Creating the fruit");
        myFruit = new Fruit("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple("green");

        //Call the methods of the fruit class
        myFruit.SayHello();
        myFruit.Chop();

        //CAll the methods of the apple class
        //Notice how class apple has access to all
        //of the public methods of class Fruit
        myApple.SayHello();
        myApple.Chop();
    }
}
