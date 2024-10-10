using UnityEngine;

public class PalloLiike : MonoBehaviour
{
    Rigidbody fysiikka;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start - kutsutaan kerran
    void Start()
    {
        fysiikka = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // jos käyttäjä on klikkanut y -kirjainta, pallo nouse ylös
        if (Input.GetKeyDown("y"))
        {
            Debug.Log("Nappi y painettu"); // console viesti
            fysiikka.AddForce(Vector3.up * 200f); // AddForce - annettaan pallolle voima
        }
    }
}
