using UnityEngine;
using System.Collections;

public class temaInfo : MonoBehaviour
{
    public int idTema; // informar o número do tema

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;


    private int notaFinal;


    void Start()
    {
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);



       int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        
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
    }

    
    void Update()
    {
        
    }
}
