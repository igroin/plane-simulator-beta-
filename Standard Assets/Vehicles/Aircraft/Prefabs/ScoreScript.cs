using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
 
    private int score = -1;

    IEnumerator AddScore()
    {
      for(; ;)
      {
        score++;
        //GameObject.Find("Text")
        this.GetComponent<Text>().text = "Score: " + score.ToString();
        yield return new WaitForSeconds(1);
      }
    }  

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("AddScore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
