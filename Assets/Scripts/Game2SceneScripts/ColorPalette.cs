using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ColorPalette : MonoBehaviour
{
    public static ColorPalette Instance;
    public static Color selectedColor;

    [SerializeField] private List<Image> colorButtons; // �����Ϳ��� ��ư �̹��� ������� ���

    private void Awake()
    {
        Instance = this;

        foreach (var img in colorButtons)
        {
            Button btn = img.GetComponent<Button>();
            if (btn != null)
            {
                btn.onClick.AddListener(() => PickColorFromButton(img.gameObject));
            }
            else
            {
                Debug.LogWarning($"{img.name} ������Ʈ�� Button ������Ʈ�� �����ϴ�.");
            }
        }
    }

    // ��ư�� Ŭ���Ǹ� ����Ǵ� �Լ�
    public void PickColorFromButton(GameObject buttonObj)
    {
        Image img = buttonObj.GetComponent<Image>();
        if (img != null)
        {
            selectedColor = img.color;
            selectedColor.a = 1f; // �������ϰ� ����
            Debug.Log("������ ����: " + selectedColor);
        }
        else
        {
            Debug.LogWarning("Image ������Ʈ�� ã�� �� �����ϴ�.");
        }
    }

    // ���� ���� ��ȯ (��: ��ĥ ������ ���� ��ȣ�� �Ǵ�)
    public Color GetColorByNumber(int number)
    {
        //Debug.Log(colorButtons[number - 1]);
        if (number >= 1 && number <= colorButtons.Count)
        {
            return colorButtons[number - 1].color;
        }
        else
        {
            Debug.LogWarning("�߸��� ��ȣ");
            return Color.clear;
        }
    }
}
