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

    // ABSTRACTION
    string FormatText(LivingBeing livingBeing) {
        return livingBeing.name + " " + livingBeing.Moves();
    }

    public void OnClickLivingBeing() {
        text.text = "Im abstract";
    }

    public void OnClickPerson() {
        text.text = FormatText(person);

    }

    public void OnClickDog() {
        text.text = FormatText(dog);

    }

    public void OnClickBird() {
        text.text = FormatText(bird);

    }
}
