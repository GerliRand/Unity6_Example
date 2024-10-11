using Unity.Mathematics;
using UnityEngine;

public class PekkaLiike : MonoBehaviour
{
    CharacterController pekkaKontrolleri;
    Vector3 pelaajanMaanvetovoima;

    float maanvetovoima = -9.81f;
    float hyppyvoima = 1.0f;
    bool pelaajaOnMaassa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pekkaKontrolleri = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        pelaajaOnMaassa = pekkaKontrolleri.isGrounded;
        if (pelaajaOnMaassa && pelaajanMaanvetovoima.y < 0)
        {
            pelaajanMaanvetovoima.y = 0f;
        }

        // Liikkuu eteen- ja taaksepäin, toimi nuoli- sekä w/s-näppämillä
        float liikeEteenpain = Input.GetAxis("Vertical");
        //transform.position = transform.position + (transform.forward * 0.01f * liikeEteenpain);
        pekkaKontrolleri.Move(transform.forward * 0.01f * liikeEteenpain);

        // Hyppää kun paina välilyönti nappia
        if (Input.GetButtonDown("Jump"))
        {
            pelaajanMaanvetovoima.y = Mathf.Sqrt(hyppyvoima + -3.0f * maanvetovoima);
        }

        pelaajanMaanvetovoima.y += maanvetovoima * Time.deltaTime;
        pekkaKontrolleri.Move(pelaajanMaanvetovoima * Time.deltaTime);
    }
}
