using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class responder : MonoBehaviour
{
    private int idTema;

    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    private int notaFinal;

    public Text infoRespostas;

    public string [] perguntas;

    public string [] alternativaA;
    public string [] alternativaB;
    public string [] alternativaC;
    public string [] corretas;

    private int idPergunta;
    
    private float acertos;
    private float questoes;
    private float media;

    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        idPergunta = 0;

        questoes = perguntas.Length;

        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas!";
    }

    public void resposta(string alternativa) {
        if (alternativa == "A") {
            if (alternativaA[idPergunta] == corretas[idPergunta]) {
                acertos ++;
            }
        }else if (alternativa == "B") {
            if (alternativaB[idPergunta] == corretas[idPergunta]) {
                acertos ++;
            }
        }
        else if (alternativa == "C") {
            if (alternativaC[idPergunta] == corretas[idPergunta]) {
                acertos ++;
            }
        }
        proximaPergunta();
    }
 
    void proximaPergunta () {
        idPergunta ++;

        if (idPergunta <= (questoes-1)) {
            pergunta.text = perguntas[idPergunta];
            respostaA.text = alternativaA[idPergunta];
            respostaB.text = alternativaB[idPergunta];
            respostaC.text = alternativaC[idPergunta];
            infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas!";
        } else {
            media = 10 * (acertos/questoes);
            notaFinal = Mathf.RoundToInt(media);

            if (notaFinal > PlayerPrefs.GetInt("notaFinal" + idTema.ToString())) {
                PlayerPrefs.SetInt("notaFinal" + idTema.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idTema.ToString(), (int)acertos);
            }

            PlayerPrefs.SetInt("notaFinalTemp" + idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idTema.ToString(), (int)acertos);
            SceneManager.LoadScene("notaFinal");
        }

    
    }


}
