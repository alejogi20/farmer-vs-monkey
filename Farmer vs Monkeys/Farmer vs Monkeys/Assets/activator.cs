using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class activator : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject scoreForStacey;
    void Start()
    {
        gameObject.GetComponent<Text>().text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float scoreforteti = float.Parse(scoreForStacey.GetComponent<Text>().text);
        if (scoreforteti >= 6 && scoreforteti < 10)
        {
            gameObject.GetComponent<Text>().text = "Happy Six years my love Stacey!! :* ♥";
        }
        else
        {
            gameObject.GetComponent<Text>().text = "";
        }

        
    }
}
