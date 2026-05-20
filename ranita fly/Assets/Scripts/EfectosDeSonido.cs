using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioClip sonidoBoton;  
    public AudioClip sonidoAtaque; 
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = false;
    }

    public void ReproducirSonido(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    public void SonidoBoton()
    {
        ReproducirSonido(sonidoBoton);
    }

    public void SonidoAtaque()
    {
        ReproducirSonido(sonidoAtaque);
    }
}
