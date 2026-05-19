using UnityEngine;

public class animationManager : MonoBehaviour
{
    public Animator ranaAnimator; 

    
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

    public void Impacto(Animator objAnim)
    {
        if (objAnim != null)
        {
            objAnim.SetTrigger("Impacto");
        }
    }
}
