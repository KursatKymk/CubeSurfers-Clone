using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    [SerializeField]
    private float ileriGitmeHizi;

    [SerializeField]
    private float sagSolHareketHizi;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yatayEksen = Input.GetAxis("Horizontal") * sagSolHareketHizi * Time.deltaTime;

        this.transform.Translate(yatayEksen, 0, ileriGitmeHizi * Time.deltaTime);
    }
}
