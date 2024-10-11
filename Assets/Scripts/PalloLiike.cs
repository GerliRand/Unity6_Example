using UnityEngine;

public class PalloLiike : MonoBehaviour
{
    Rigidbody fysiikka;

    // Mahdollisia muuttuja tyypejä:
    public bool testimuuttuja;  // public - näkyy julkisesti (huono tapa) ja Unity:n puolella

    [SerializeField]    // muuttuja näkyy Unity:n puolelle mutta nyt se ei ole julkinen
    int kokonaislukumuuttuja;
    [SerializeField]
    float desimaalilukumuuttuja;

    [SerializeField]
    string merkkijonomuuttuja;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start - kutsutaan kerran
    void Start()
    {
        fysiikka = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // jos käyttäjä on klikkanut y -kirjainta ja testimuuttuja on tosi, pallo hyppä ylös
        if (Input.GetKeyDown("y"))
        {
            if (testimuuttuja == true)
            {
                Debug.Log("Nappi y painettu"); // console viesti
                fysiikka.AddForce(Vector3.up * 200f); // AddForce - annettaan pallolle voima, 
            }

        }
    }
}
