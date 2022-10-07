using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScoreBox : MonoBehaviour
{
    public float level;
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
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
            level = Convert.ToInt32(GameObject.Find("Body").GetComponent<Respawn>().Checkpoint.name);
            Canvas.GetComponent<Stats>().Score += (100 - Canvas.GetComponent<Stats>().counter);
            Canvas.GetComponent<Stats>().Scoretemp = (Convert.ToInt32(level*10 + 100 - Canvas.GetComponent<Stats>().counter / 4));
            Canvas.GetComponent<Stats>().scoretempobject.SetActive(true);
            Canvas.GetComponent<Stats>().iscoool = true;
            Destroy(this);
            //GameObject.Find("e").GetComponent<MakeTXTFile>().WriteString();
        }
    }
}
