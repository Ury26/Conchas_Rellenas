using System.Collections;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    public GameObject mosquito;
    public GameObject tapa;
    public GameObject corcho;
    public float tiempo = 3f; // cada 2 segundos aparece algo
    public float tiempoVida = 3f;
    public Transform[] posiciones; // lugares donde aparecen
    public int probmosquito = 60; // porcentaje
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

            // Elegir posición aleatoria
            int i = Random.Range(0, posiciones.Length);
            Vector2 spawnPos = posiciones[i].position;

            // Elegir si aparece mosquito o basura
            int tipo = Random.Range(0, 4); // 0 mosquito, 1 basura

            GameObject objetoCreado = null;

            Collider2D col = Physics2D.OverlapCircle(spawnPos, 0.5f); // radio pequeño
            if (col != null)
                continue; // si hay algo, saltamos y no instanciamos

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
