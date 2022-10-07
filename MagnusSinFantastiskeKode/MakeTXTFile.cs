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
using UnityEngine.SceneManagement;

public class MakeTXTFile : MonoBehaviour
{
    public float HighScore;
    
    public float Score;
    
    public GameObject Player;

    public string pathscore;
    public string pathhigh;
    void Start()
    {

        //WriteString();
        //ReadString();
        pathscore = Application.persistentDataPath + @"/Score.txt";
        pathhigh = Application.persistentDataPath + @"/Highcore.txt";
    }
    public void WriteString()
    {
        //string path = Application.persistentDataPath + @"/Score.txt";
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(pathscore, true);
        writer.WriteLine(Player.GetComponent<Stats>().Score);
        writer.Close();
        StreamReader reader = new StreamReader(pathscore);
        //Print the text from the file
        Debug.Log(reader.ReadToEnd());
        Score = Player.GetComponent<Stats>().Score;
        reader.Close();
        CheckHighScore();
    }

    void CheckHighScore()
    {
        //string path = Application.persistentDataPath + @"/Highcore.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(pathhigh);
        Debug.Log("fuckoff");
        Debug.Log(File.ReadLines(pathhigh).Last());
        HighScore = Convert.ToInt16(File.ReadLines(pathhigh).Last());
        Debug.Log(HighScore + " is highscore ");
        Debug.Log(Score + " is score.");
        reader.Close();
        if (Score>HighScore)
        {
            WriteHighscore();
        }
        else
        {
            SceneManager.LoadScene("Winn");
        }
        
    }
    public void WriteHighscore()
    {
        //string path = Application.persistentDataPath + @"/Highcore.txt";
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(pathhigh, true);
        writer.WriteLine(Score);
        writer.Close();
        StreamReader reader = new StreamReader(pathhigh);
        reader.Close();
        SceneManager.LoadScene("Winn");
    }

}