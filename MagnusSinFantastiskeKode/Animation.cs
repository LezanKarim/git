using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator Ator;

    // Start is called before the first frame update
    void Start()
    {
        Ator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            Ator.SetBool("Run", true);
        }
        if (!Input.GetKey("w") && !Input.GetKey("s") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            Ator.SetBool("Run", false);
        }

        if (Input.GetKeyDown("e"))
        {
            Ator.SetBool("Dance", true);
        }
        if (Input.GetKeyUp("e"))
        {
            Ator.SetBool("Dance", false);
        }
    }
}
