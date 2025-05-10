using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipes;
    float dt = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dt += Time.deltaTime;
        if (dt > 1.5f)
        {
            GameObject newPipe = Instantiate(pipes);
            newPipe.transform.position = new Vector3(0, Random.Range(-1.2f, 3f), 0);
            dt = 0;
            Destroy(newPipe, 5.0f);
        }
    }
}
