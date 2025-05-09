using UnityEngine;
using UnityEngine.UI;

public class StartScreenBlinkEffect : MonoBehaviour
{
    public RawImage rawImage;  // RawImage ¿¬°á
    public float speed = 2.5f;   // ±ôºýÀÓ ¼Óµµ

    private Color originalColor;

    void Start()
    {
        if (rawImage == null)
            rawImage = GetComponent<RawImage>();

        originalColor = rawImage.color;
    }

    void Update()
    {
        float alpha = (Mathf.Sin(Time.time * speed) + 1f) / 2f;
        Color newColor = originalColor;
        newColor.a = alpha;
        rawImage.color = newColor;
    }
}
