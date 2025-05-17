using UnityEngine;
using System.Collections;

public class PaintableRegion : MonoBehaviour
{
    public int regionNumber;
    private SpriteRenderer sr;
    private bool isColored = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()  // 클릭 or 터치 시 실행
    {
        Debug.Log("Clicked!");
        if (isColored) return;

        Color selected = ColorPalette.selectedColor;
        Color correct = ColorPalette.Instance.GetColorByNumber(regionNumber);
        Debug.Log(selected);
        Debug.Log(correct);
        if (selected == correct)
        {
            StartCoroutine(FillEffect(new Color(selected.r, selected.g, selected.b, 0)));
        }
    }

    IEnumerator FillEffect(Color targetColor)
    {
        isColored = true;

        float duration = 0.4f;
        float t = 0f;
        Color original = sr.color;

        while (t < duration)
        {
            sr.color = Color.Lerp(original, targetColor, t / duration);
            t += Time.deltaTime;
            yield return null;
        }

        sr.color = targetColor;
    }

    public bool IsColored() => isColored;
}
