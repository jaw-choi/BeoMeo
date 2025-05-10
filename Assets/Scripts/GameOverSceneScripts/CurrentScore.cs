using UnityEngine;
using TMPro;
public class CurrentScore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<TMP_Text>().text = "Score:" + Score.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
