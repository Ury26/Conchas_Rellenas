using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] canciones;  
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += CambiarCancion;
        TocarCancion(SceneManager.GetActiveScene().buildIndex);
    }

    void CambiarCancion(Scene escena, LoadSceneMode modo)
    {
        TocarCancion(escena.buildIndex);
    }

    void TocarCancion(int numero)
    {
        if (numero >= canciones.Length) return;

        AudioClip nuevaCancion = canciones[numero];

        // Solo cambiamos si es diferente a la que ya está sonando
        if (audioSource.clip != nuevaCancion)
        {
            audioSource.clip = nuevaCancion;
            audioSource.Play();
        }
    }
}
