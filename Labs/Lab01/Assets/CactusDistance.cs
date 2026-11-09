using UnityEngine;

public class CactusDistance : MonoBehaviour
{
    // Aquí arrastraremos al OTRO cactus en Unity
    public Transform otherCactus;

    // Distancia mínima para atacar (0.25 metros según tu práctica)
    public float attackDistance = 0.25f;

    // El cerebro de las animaciones
    private Animator animator;

    void Start()
    {
        // Obtenemos el Animator del cactus que tiene este script
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Si el otro cactus existe, calculamos la distancia entre ellos
        if (otherCactus != null)
        {
            float distance = Vector3.Distance(transform.position, otherCactus.position);

            // Si la distancia es menor a 0.25, ataca. Si no, vuelve a Idle.
            if (distance <= attackDistance)
            {
                animator.SetBool("isAttacking", true);
            }
            else
            {
                animator.SetBool("isAttacking", false);
            }
        }
    }
}