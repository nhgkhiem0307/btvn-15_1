using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuLevelManager : MonoBehaviour
{
    public Button[] levelButtons;

    private void Start()
    {
        for (int i = 0; i < levelButtons.Length; i++)
        {
            int levelIndex = i + 1; // RẤT QUAN TRỌNG
            levelButtons[i].onClick.AddListener(
                () => SelectLevel(levelIndex)
            );
        }
    }

    void SelectLevel(int level)
    {
        LevelData.currentLevel = level;
        SceneManager.LoadScene("Gameplay");
    }
}
