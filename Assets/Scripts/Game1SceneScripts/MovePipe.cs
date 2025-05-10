using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dt += Time.deltaTime;
        transform.position += Vector3.left * Time.deltaTime * speed; 

    }
}
