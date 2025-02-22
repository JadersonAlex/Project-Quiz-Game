using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class temaJogo : MonoBehaviour
{
    public Button btnPlay;
    public TMP_Text txtNomeTema;

    public GameObject infoTema;
    public TMP_Text txtInfoTema;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    public string[] nomeTema;
    public int numeroQuestoes;

    private int idTema;

    void Start()
    {
        idTema = 0;
        txtNomeTema.text = nomeTema[idTema];
        txtInfoTema.text = "Você acertou X de X questões";
        infoTema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        btnPlay.interactable = false;
    }

    
    public void selecioneTema(int i)
    {
        idTema = i;
        PlayerPrefs.SetInt("idTema", idTema);
        txtNomeTema.text = nomeTema[idTema];

        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        int acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());

        //zerando as estrelas ao clicar em outro tema
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        if (notaFinal == 10) // se a nota for igual a 10
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if (notaFinal >= 7) // se for maior ou igual a 7
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaFinal >= 5) // se for maior ou igual a 5
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }


        txtInfoTema.text = "Você acertou "+acertos.ToString()+ " de " + numeroQuestoes.ToString() + " Questões!";
        infoTema.SetActive(true);
        btnPlay.interactable = true;
    }


    public void Jogar() 
    {

      SceneManager.LoadScene("T" + idTema.ToString());
    }
}
