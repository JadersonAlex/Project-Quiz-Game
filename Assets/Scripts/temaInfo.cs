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
    }

    
    void Update()
    {
        
    }
}
