using UnityEngine;
using System.Collections;

public class moveOffset : MonoBehaviour
{
    private Material MaterialAtual;
    public float velocidade;
    private float offset;

    
    void Start()
    {
        MaterialAtual = GetComponent<Renderer>().material; 
    }

    
    void FixedUpdate()
    {
        offset += 0.001f;

        MaterialAtual.SetTextureOffset("_MainTex", new Vector2(offset * velocidade, 0));
    }
}
