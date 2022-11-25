using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject Finishtext;
    public static float score = Score.score;

    //Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Finishtext.GetComponent<Text>().text = "Goed gedaan uw score is: " + score.ToString("F0");
    }
}
