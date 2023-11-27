using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Bird : Animal
{
    // ENCAPSULATION && POLYMORPHISM
    public override string name { get { return "Bird"; } }


    // POLYMORPHISM
    public override string Moves() {
        return "moves by flying and " + MakesSound();
    }

}
