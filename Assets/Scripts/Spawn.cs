using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{


    public GameObject Enemigo;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("espawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator espawn()
    {
        while (true)
        {
            float value = Random.Range(4f, 6f);
            Instantiate(Enemigo, transform.position, transform.rotation);
            yield return new WaitForSeconds(value);
        }
        
        

    }
}
