using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("rotet");
        if (other.gameObject.name == "Body")
        {
            Canvas.GetComponent<Stats>().Score += (100 - Canvas.GetComponent<Stats>().counter);
            Canvas.GetComponent<Stats>().Scoretemp = (100 - Canvas.GetComponent<Stats>().counter);
            Canvas.GetComponent<Stats>().scoretempobject.SetActive(true);
            Canvas.GetComponent<Stats>().iscoool = true;
            Destroy(this);
        }
    }
}
