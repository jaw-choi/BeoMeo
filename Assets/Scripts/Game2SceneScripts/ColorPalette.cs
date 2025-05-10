using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ColorPalette : MonoBehaviour
{
    public static ColorPalette Instance;
    public static Color selectedColor;

    [SerializeField] private List<Image> colorButtons; // 에디터에서 버튼 이미지 순서대로 등록

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
                Debug.LogWarning($"{img.name} 오브젝트에 Button 컴포넌트가 없습니다.");
            }
        }
    }

    // 버튼이 클릭되면 실행되는 함수
    public void PickColorFromButton(GameObject buttonObj)
    {
        Image img = buttonObj.GetComponent<Image>();
        if (img != null)
        {
            selectedColor = img.color;
            selectedColor.a = 1f; // 불투명하게 고정
            Debug.Log("선택한 색상: " + selectedColor);
        }
        else
        {
            Debug.LogWarning("Image 컴포넌트를 찾을 수 없습니다.");
        }
    }

    // 정답 색상 반환 (예: 색칠 영역의 숫자 번호로 판단)
    public Color GetColorByNumber(int number)
    {
        //Debug.Log(colorButtons[number - 1]);
        if (number >= 1 && number <= colorButtons.Count)
        {
            return colorButtons[number - 1].color;
        }
        else
        {
            Debug.LogWarning("잘못된 번호");
            return Color.clear;
        }
    }
}
