using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    Dog dog = new Dog();
    Bird bird = new Bird();
    Person person = new Person();   

    private void Start() {
        
    }

    public void OnClickLivingBeing() {
        text.text = "Im abstract";
    }

    public void OnClickPerson() {
        text.text = person.Moves();

    }

    public void OnClickDog() {
        text.text = dog.Moves();

    }

    public void OnClickBird() {
        text.text = bird.Moves();

    }
}
