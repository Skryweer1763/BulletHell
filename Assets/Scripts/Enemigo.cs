using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public GameObject BalaEnemiga;
    [SerializeField] float speed=0.5f;
    bool canshoot=true;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(3, 3, true);

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        if (canshoot == true)
        {

            StartCoroutine("CorrutinaDisparo");

        }
        
    }

    void Movimiento()
    {

        transform.position += new Vector3(-7 * Time.deltaTime * speed,0,0);

    }

    IEnumerator CorrutinaDisparo()
    {
        while (true)
        {
            canshoot = false;
            Instantiate(BalaEnemiga, transform.position, transform.rotation);
            yield return new WaitForSeconds(2f);
            canshoot = true;
        }


    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Muerte")
        {

            Destroy(gameObject);
            
        }
    }

}
