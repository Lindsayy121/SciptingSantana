using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Fruit
{
    //This is the first constructor for the apple class
    //It calls the parent constructor immediately, even
    //before it runs.
    public Apple()
    {
        //Notice how appple has access to the public variable 
        //color which is now a part of the parent fruit class
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    //This is the second constructor for the apple class
    //It specifieses which parent constructor will be called
    //using the "base" keyword
    public Apple(string newColor) : base(newColor)
    {
        //Notice how this constructor doesnt set the color
        //Since the base constructor sets the color that 
        //is passed as an arguement
        Debug.Log("2nd Apple Constructor Called");
    }
}
