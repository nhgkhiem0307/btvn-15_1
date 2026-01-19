using UnityEngine;
using TMPro;

public class LvNumber : MonoBehaviour
{
    public TMP_Text levelText;

    void Start()
    {
        levelText.text = LevelData.currentLevel.ToString();
    }
}
