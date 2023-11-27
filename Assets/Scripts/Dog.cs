using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    // ENCAPSULATION && POLYMORPHISM
    public override string name { get { return "Dog"; } }

    // POLYMORPHISM
    public override string MakesSound() {
        return "does au au";
    }

    // POLYMORPHISM
    public override string Moves() {
        return "moves in 4 legs and " + MakesSound();
    }

}
