using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrallax : MonoBehaviour
{
    public GameObject fondoLejano;
    public GameObject fondoMedio;
    public GameObject fondoCercano;

    float x, y;

    void Update()
    {
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;

        fondoCercano.GetComponent<Transform>().position = new Vector3(x / 2000, y / 2500, 0);
        fondoMedio.GetComponent<Transform>().position = new Vector3(x / 5000, y / 5000, 0);
        fondoLejano.GetComponent<Transform>().position = new Vector3(x / 7000, y / 7000, 0);
    }
}
