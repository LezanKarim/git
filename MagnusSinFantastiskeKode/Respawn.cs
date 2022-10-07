using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform Checkpoint;
    public GameObject CPimage;
    public GameObject RIPimage;
    public Rigidbody rb;

    public int Deaths;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-5)
        {
            transform.position = Checkpoint.position;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            RIPimage.SetActive(true);
            StartCoroutine(Wait());
            Deaths++;
        }
        if (!Input.GetKey("w") && !Input.GetKey("s") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            //rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("rotet");
        if (other.gameObject.tag == "Respawn")
        {
            Checkpoint = other.transform;
            CPimage.SetActive(true);
            StartCoroutine(Wait());
        }
        if (other.gameObject.tag == "Death")
        {
            transform.position = Checkpoint.position;
            RIPimage.SetActive(true);
            StartCoroutine(Wait());
            Deaths++;

        }
        if (other.gameObject.name == "Win")
        {
            GameObject.Find("e").GetComponent<MakeTXTFile>().WriteString();
            //SceneManager.LoadScene("Winn");
        }
    
    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1);
        CPimage.SetActive(false);
        RIPimage.SetActive(false);
    }
}
