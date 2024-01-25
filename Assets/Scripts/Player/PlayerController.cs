using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // karakterin h�z�
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Vertical"); // A, D tu�lar�ndan gelen girdiyi al
        float vertical = Input.GetAxisRaw("Horizontal"); // W, S tu�lar�ndan gelen girdiyi al

        // karakterin pozisyonunu de�i�tir
        transform.position += new Vector3(-(horizontal), 0, vertical) * speed * Time.deltaTime;

        if ((horizontal == 0) && (vertical == 0))
        {
            if (Input.GetMouseButtonDown(0))
            {
                animator.SetBool("isStabbing", true);
            }
            else
            {
                animator.SetBool("isStabbing", false);

            }

            animator.SetBool("isMoving", false);
        }
        else
        {
            animator.SetBool("isMoving", true);
        }
    }
}