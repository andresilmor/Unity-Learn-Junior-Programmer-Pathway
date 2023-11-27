using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public override string MakesSound() {
        return "does au au";
    }

    public override string Moves() {
        return "Dog moves in 4 legs and " + MakesSound();
    }

}
