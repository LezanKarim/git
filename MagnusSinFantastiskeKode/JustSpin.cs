using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustSpin : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        

        transform.Rotate(0, ((100 + speed * 10) * Time.deltaTime) * -2, 0);
    }


    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1);
        StartCoroutine(Wait1());
        speed = Random.Range(-5, -9);
    }


    IEnumerator Wait1()
    {

        yield return new WaitForSeconds(1);
        StartCoroutine(Wait());
    }
}

