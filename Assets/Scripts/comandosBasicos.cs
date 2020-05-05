using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class comandosBasicos : MonoBehaviour {
  


    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
       
    }


    public void resetarPontuacoes() {
        PlayerPrefs.DeleteAll();
    }
        //SceneManager.LoadScene(nomeCena); 


}

