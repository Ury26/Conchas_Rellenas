using System.Collections;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    public GameObject mosquito;
    public GameObject tapa;
    public GameObject corcho;
    public float tiempo = 3f; 
    public float tiempoVida = 3f;
    public Transform[] posiciones; 
    public int probmosquito = 60; 
    public int probtapa = 25;
    public int probcorcho = 15;

    void Start()
    {
        StartCoroutine(GenerarObjetos());
    }

    IEnumerator GenerarObjetos()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempo);

            
            int i = Random.Range(0, posiciones.Length);
            Vector2 spawnPos = posiciones[i].position;

            
            int tipo = Random.Range(0, 4); 

            GameObject objetoCreado = null;

            Collider2D col = Physics2D.OverlapCircle(spawnPos, 0.5f); 
            if (col != null)
                continue; 

            int random = Random.Range(0, 100);

            if (random < probmosquito)
                objetoCreado = Instantiate(mosquito, posiciones[i].position, Quaternion.identity);
            else if (random < probmosquito + probtapa)
                objetoCreado = Instantiate(tapa, posiciones[i].position, Quaternion.identity);
            else
                objetoCreado = Instantiate(corcho, posiciones[i].position, Quaternion.identity);

            Destroy(objetoCreado, tiempoVida);
        }      
    }
}
