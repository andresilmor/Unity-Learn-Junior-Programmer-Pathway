using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Person : LivingBeing
{
    // ENCAPSULATION && POLYMORPHISM
    public override string name { get { return "Person"; } }

    // POLYMORPHISM
    public override string Moves() {
        return "moves in 2 legs";
    }

   
}
