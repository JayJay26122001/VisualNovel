using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue System/Dialogue")]
public class DialogueData : ScriptableObject
{
    [System.Serializable]
    public struct DialogueLine
    {
        public string characterName;
        [TextArea(3, 5)] public string text;
        public Sprite characterSprite;
    }

    public DialogueLine[] lines;
}
