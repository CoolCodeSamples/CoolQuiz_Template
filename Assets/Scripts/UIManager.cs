using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text questionText;
    [SerializeField] private AnswerButton buttonA;

    private void Start()
    {
        questionText.text = "Wie heisst das schnellste Tier der Welt?";

        buttonA.ChangeText();
    }
}
