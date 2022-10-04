using UnityEngine.UI;
using UnityEngine;
using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
    public Text counterText;
    public Text ScoreText;
    public Text ScoretempText;
    public Text DeathText;

    public GameObject scoretempobject;

    public float counter;
    public float Score;
    public float Scoretemp;

    public bool iscoool = false;

    void Start()
    {
        StartCoroutine(Wait());
    }
    void Update()
    {
        counterText.text = "Timer: " + counter.ToString();
        ScoreText.text = "Score: " + Score.ToString();
        DeathText.text = "Deaths: " + GameObject.Find("Body").GetComponent<Respawn>().Deaths.ToString();
        ScoretempText.text = "+: " + Scoretemp.ToString();
        if (iscoool)
            StartCoroutine(Wait2());
            iscoool = false;

    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(1);
        counter++;
        StartCoroutine(Wait1());
    }

    IEnumerator Wait1()
    {

        yield return new WaitForSeconds(1);
        counter++;
        StartCoroutine(Wait());
    }
    IEnumerator Wait2()
    {

        yield return new WaitForSeconds(1);
        scoretempobject.SetActive(false);
    }
}