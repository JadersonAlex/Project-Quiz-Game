using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ComandosBasicos : MonoBehaviour
{
    
    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    // apenas para teste, tirar isso do jogo final
    public void resetarPontuacoes() 
    {
        PlayerPrefs.DeleteAll(); // deleta todo o progresso do jogo
    }



}
