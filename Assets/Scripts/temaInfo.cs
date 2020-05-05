using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaInfo : MonoBehaviour
{
    public int idTema;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    private int notaFinal;

    void Start()
    {
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        int notaF = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
       
        if (notaF == 10) {
        estrela1.SetActive(true);
        estrela2.SetActive(true);
        estrela3.SetActive(true);
        }
        else if (notaF >= 7) {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaF >= 5) {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }
    }

   
    void Update()
    {
        
    }
}
