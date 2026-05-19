using UnityEngine;

public class animationManager : MonoBehaviour
{
    public Animator ranaAnimator; // referencia al Animator de la rana

    // Animaciones de la rana
    public void Lengua()
    {
        ranaAnimator.SetTrigger("Lengua");
    }

    public void ComerMosquito()
    {
        ranaAnimator.SetTrigger("ComerMosquito");
    }

    public void ComerBasura()
    {
        ranaAnimator.SetTrigger("ComerBasura");
    }

    // Animación de impacto para objetos
    public void Impacto(Animator objAnim)
    {
        if (objAnim != null)
        {
            objAnim.SetTrigger("Impacto");
        }
    }
}
