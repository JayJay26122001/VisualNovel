using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Image characterImage;

    public DialogueData currentDialogue;
    private int index = 0;

    void Start()
    {
        StartDialogue(currentDialogue);
    }

    public void StartDialogue(DialogueData dialogue)
    {
        currentDialogue = dialogue;
        index = 0;
        ShowLine();
    }

    public void ShowLine()
    {
        if (index < currentDialogue.lines.Length)
        {
            DialogueData.DialogueLine line = currentDialogue.lines[index];
            nameText.text = line.characterName;
            dialogueText.text = line.text;
            characterImage.sprite = line.characterSprite;
            index++;
        }
        else
        {
            EndDialogue();
        }
    }

    public void EndDialogue()
    {
        Debug.Log("Diálogo encerrado.");
        dialogueBox.SetActive(false);
    }

    public void NextLine()
    {
        ShowLine();
    }
}