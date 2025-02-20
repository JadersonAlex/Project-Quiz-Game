using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ComandosBasicos : MonoBehaviour
{
    
    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }



}
