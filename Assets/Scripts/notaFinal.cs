using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class notaFinal : MonoBehaviour
{

    private int idTema;

    public TMP_Text txtNota;
    public TMP_Text txtInfoTema;


    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    private int notaF; // nota final
    private int acertos;

    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");


        estrela1.SetActive(false); 
        estrela2.SetActive(false);
        estrela3.SetActive(false);


       
        notaF = PlayerPrefs.GetInt("notaFinalTemp"+idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp" + idTema.ToString());


        txtNota.text = notaF.ToString();
        txtInfoTema.text = "Você acertou " + acertos.ToString() + " de 20 perguntas";

        if (notaF == 10) // se a nota for igual a 10
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if (notaF >= 7) // se for maior ou igual a 7
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (notaF >= 5) // se for maior ou igual a 5
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }



    }

   
    public void jogarNovamente()
    {
        SceneManager.LoadScene("T" + idTema.ToString());
    }
}
