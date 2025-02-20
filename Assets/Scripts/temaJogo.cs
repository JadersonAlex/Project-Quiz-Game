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
        txtNomeTema.text = nomeTema[idTema];

        int notaFinal = 0;
        int acertos = 0;


        txtInfoTema.text = "Você acertou"+acertos.ToString()+ " de " + numeroQuestoes.ToString() + " Questões!";
        infoTema.SetActive(true);
        btnPlay.interactable = true;
    }


    public void Jogar() 
    {

      SceneManager.LoadScene("T" + idTema.ToString());
    }
}
