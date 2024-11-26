using TMPro;
using UnityEngine;
using Yarn.Unity;

public class QuestManager : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public VariableStorageBehaviour variableStorage; // Kết nối Variable Storage từ Yarn
    public TMP_Text questStageText; // Text UI để hiển thị stage
    public int questStage;
    public GameObject fruits;

    private void Start()
    {
        if (variableStorage == null)
        {
            variableStorage = dialogueRunner.VariableStorage;
        }
    }

    private void Update()
    {
        questStage = GetQuestStage();

        UpdateQuestUI(questStage);
    }

    private int GetQuestStage()
    {
        if (variableStorage.TryGetValue("$quest_stage", out float questStageValue))
        {
            return Mathf.FloorToInt(questStageValue);
        }
        return 0;
    }

    private void UpdateQuestUI(int questStage)
    {
        questStageText.text = $"Talk to the Bat";

        if (questStage == 1)
        {
            questStageText.text = "\nTalk to the Rats!";
        }
        else if (questStage == 2)
        {
            questStageText.text = "\nReturn to the Bat!";
        }
        else if (questStage == 3)
        {
            questStageText.text = "\nQuest Complete!";
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Bat") && questStage == 2)
        {
            fruits.SetActive(true);
        }
    }
}
