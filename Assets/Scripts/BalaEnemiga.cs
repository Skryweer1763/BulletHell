using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemiga : MonoBehaviour
{

    [SerializeField] int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(3, 3, true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-7 * Time.deltaTime * speed, 0,0);
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Muerte")
        {

            Destroy(gameObject);

        }
    }
}
