using UnityEngine;
using System.Collections;
// dit script laat de rechter flipper bewegen
public class FlipperMoveRight : MonoBehaviour
{
    public bool flipactivated;
    public bool activeFlipper;
    public bool deactiveFlipper;
    public bool buttonhold;
    public bool endoftheline;
    public bool flipperactive;
    public float timer1 = 0;
    public float timer2 = 0;
    public float speed;
    public GameObject flipperLinks;
    public Vector3 endplace;
    public Vector3 startplace;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) && flipactivated == false)
        {
            activeFlipper = true;
            buttonhold = true;
            flipactivated = true;
            // fliperactivated zorgt ervoor dat je de flipper niet 2x kan indrukken(dit werkt in de praktijk niet perfect, maar beter dan zonder deze functie)
        }
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            buttonhold = false;
            // buttenhold blijft aan totdat de toets word losgelaten om de flipper omhoog te houden zolang de knop is ingedrukt
        }
        if (timer1 > 12f)
        {
            activeFlipper = false;
            endoftheline = true;
            timer1 = 0;
            transform.localEulerAngles = endplace;
            // deze if gebeurt na de rotatie en teleporteerd de flipper naar de goeie eindpositie, omdat de rotatie afhangt van een onnauwkeurige float timer
        }
        if (buttonhold == false && endoftheline == true)
        {
            deactiveFlipper = true;
            // deze if statement deactive checkt of de knop is losgelaten en de flipper naar boven is geroteerd, waarna hij weer naar beneden kan, wat gebeurt met de deactiveflipper boolean
        }
        if (timer2 > 12f)
        {
            deactiveFlipper = false;
            timer2 = 0;
            flipactivated = false;
            transform.localEulerAngles = startplace;
            // deze if statement teleporteerd de flipper terug naar de startpositie na de rotatie terug om dezelfde reden als voorheen, de onnauwkeurige float timer
        }
        if (activeFlipper == true)
        {
            transform.RotateAround
                (transform.position,
                flipperLinks.transform.up,
                200 * Time.deltaTime);
            timer1 = timer1 + (Time.deltaTime * 100);
            // dit is de rotatie naar boven, welke word uitgevoerd als de knop is ingedrukt of al is losgelaten, maar wel ingedrukt geweest is. deze eindigt onnauwkeurig
        }
        if (deactiveFlipper == true)
        {
            transform.RotateAround
               (transform.position,
               flipperLinks.transform.up,
               -200 * Time.deltaTime);
            timer2 = timer2 + (Time.deltaTime * 100);
            endoftheline = false;
            // dit is de rotatie naar beneden, eindigt ook onnauwkeurig. de endoftheline boolean word naar false gezet zodat de flipper opnieuw kan bewegen
        }
    }
}
