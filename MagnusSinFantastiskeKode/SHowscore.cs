using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
using System.Collections;
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

public class SHowscore : MonoBehaviour
{

    public Text HighscoreText;
    public Text ScoreText;
    public float Score;
    public float HighScore;
    // Start is called before the first frame update
    void Start()
    {
        ReadString();
        ReadString2();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + Score.ToString();
        HighscoreText.text = "Highscore: " + HighScore.ToString();
    }

    public void ReadString()
    {
        string path = Application.persistentDataPath + @"/Score.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);

        Score = Convert.ToInt32(File.ReadLines(path).Last());
        reader.Close();
    }

    public void ReadString2()
    {
        string path = Application.persistentDataPath + @"/Highcore.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);

        HighScore = Convert.ToInt32(File.ReadLines(path).Last());
        reader.Close();
    }
}
