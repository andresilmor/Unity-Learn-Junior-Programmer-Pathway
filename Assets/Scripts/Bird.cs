using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    public override string Moves() {
        return "Bird moves by flying and " + MakesSound();
    }

}
