using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] Vector3 moveVectors;
    [SerializeField] float speed = 1;
    Animator animator;
    public float nextShot = 1;
    public float fireRate = 1;
    [SerializeField] GameObject playerBullet;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        MovePlayer();

        PlayerAnimator();

        Pewpew();
    }

    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        moveVectors.x = horizontal;
        moveVectors.y = vertical;
        transform.position += moveVectors * Time.deltaTime * speed;
    }

    void PlayerAnimator()
    {
        if (moveVectors.y > 0.15)
        {
            animator.Play("Up tilt action");
        }
        if (moveVectors.y < -0.15)
        {
            animator.Play("Down tilt action");
        }
        else
        {
            animator.Play("Idle");
        }
    }

    void Pewpew()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(fierRate());
            Debug.Log("fiering started");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("fiering stoped");
            StopAllCoroutines();
        }
    }

    //corutine that controls the fierrate
    IEnumerator fierRate()
    {
        while (true)
        {
            Instantiate(playerBullet, gameObject.transform.position + new Vector3 (1,0,0), gameObject.transform.rotation);
            yield return new WaitForSeconds(0.25f);
        }
    }
}
