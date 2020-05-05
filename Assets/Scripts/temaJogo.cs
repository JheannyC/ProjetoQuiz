using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class temaJogo : MonoBehaviour
{
    public Button btnPlay;
    public Text txtNomeTema;
    public Text txtinfoTema;
    public GameObject infoTema;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    public int numQuestoes;

    public string [] nomeTema;

    private int idTema;

    
  
    void Start()
    {
        idTema = 0;
        txtNomeTema.text = nomeTema[idTema];
        int notaFinal = 0;
        int acertos = 0;
        txtinfoTema.text = "Você acertou "+ acertos.ToString() + " de " + numQuestoes.ToString() + " questões!";
        infoTema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        btnPlay.interactable = false;

    }

public void selecioneTema (int i) {
    idTema = i;
    PlayerPrefs.SetInt("idTema", idTema);
    txtNomeTema.text = nomeTema[idTema];

    int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
    int acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());

    estrela1.SetActive(false);
    estrela2.SetActive(false);
    estrela3.SetActive(false);

    if (notaFinal == 10) {
        estrela1.SetActive(true);
        estrela2.SetActive(true);
        estrela3.SetActive(true);
        }
        else if (notaFinal >= 7) {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaFinal >= 5) {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }
    txtinfoTema.text = "Você acertou " + acertos.ToString() + " de " + numQuestoes.ToString() + " questões!";
    infoTema.SetActive(true);
    btnPlay.interactable = true;
}

public void jogar () {
    SceneManager.LoadScene("T"+ idTema.ToString());
}


}
