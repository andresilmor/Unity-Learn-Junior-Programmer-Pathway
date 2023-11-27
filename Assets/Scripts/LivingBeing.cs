using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LivingBeing : MonoBehaviour {
    // ENCAPSULATION
    public abstract string name { get; }

    public abstract string Moves();

}
