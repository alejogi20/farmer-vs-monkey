using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class showingScore : MonoBehaviour
{

    public GameObject badscore;
    public GameObject goodscore;
    public void addScore_apple()
    {
        float score = float.Parse(GetComponent<Text>().text);
        score++;
        GetComponent<Text>().text = score.ToString();
        GameObject.Instantiate(goodscore);

    }

    public void substractScore_apple()
    {

        float score = float.Parse(GetComponent<Text>().text);
        if (score > 0) score--;
        GetComponent<Text>().text = score.ToString();
        //GameObject.Instantiate(badscore, new Vector2(GameObject.Find("fruit basket").transform.position.x + 1, GameObject.Find("fruit basket").transform.position.y + 1), new Quaternion());

    }
}
