using UnityEngine;
using UnityEngine.UI; // Dùng ?? thao tác v?i UI
using UnityEngine.Events; // Dùng cho s? ki?n nút

public class LevelManager : MonoBehaviour
{
    public Button[] levelButtons;

    public Text messageText;




    private void Start()
    {

        for (int i = 0; i < 12; i++)
        {
            int levelIndex = i + 1; 
            levelButtons[i].onClick.AddListener(() => OnLevelClicked(levelIndex));
        }
    }


    private void OnLevelClicked(int level)
    {
        messageText.text = $"Level {level}";
    }
}
