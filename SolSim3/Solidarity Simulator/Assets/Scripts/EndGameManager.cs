using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGameManager : MonoBehaviour {

    public GameObject blackoutManager;
    public int endIndex;
    public GameObject youWonText;
    public GameObject healthcareText;
    public GameObject dentalText;
    public GameObject childcareText;
    public GameObject annualRaisesText;
    public GameObject boardRepresentationText;
    public GameObject layoffProtectionText;
    public GameObject retirementContributionsText;
    public GameObject negotiationPanel;
    public GameObject achievementManager;
    public GameObject brokeWorkstationBadge;
    public GameObject topClimbBadge;
    public GameObject maxSolidarityBadge;

    public void Start()
    {
        youWonText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
    }

    public void Update()
    {
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().healthcare == true)
        {
            healthcareText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0,255,128,255);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().healthcare == false)
        {
            healthcareText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255,0,42,100);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().dental == true)
        {
            dentalText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().dental == false)
        {
            dentalText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 100);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().childcare == true)
        {
            childcareText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().childcare == false)
        {
            childcareText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 100);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().raises == true)
        {
            annualRaisesText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().raises == false)
        {
            annualRaisesText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 100);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().boardRep == true)
        {
            boardRepresentationText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().boardRep == false)
        {
            boardRepresentationText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 100);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().layoffProtections == true)
        {
            layoffProtectionText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().layoffProtections == false)
        {
            layoffProtectionText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 100);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().retirement == true)
        {
            retirementContributionsText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(0, 255, 128, 255);
        }
        if (negotiationPanel.GetComponent<NegotiationDialogueManager>().retirement == false)
        {
            retirementContributionsText.GetComponent<TextMeshProUGUI>().faceColor = new Color32(255, 0, 42, 100);
        }
    }

    private void OnGUI()
    {
        if (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space")))
        {
            youWonText.GetComponent<BenefitTextManager>().NextSentence();
            healthcareText.GetComponent<BenefitTextManager>().NextSentence(); ;
            dentalText.GetComponent<BenefitTextManager>().NextSentence(); ;
            childcareText.GetComponent<BenefitTextManager>().NextSentence(); ;
            annualRaisesText.GetComponent<BenefitTextManager>().NextSentence(); ;
            boardRepresentationText.GetComponent<BenefitTextManager>().NextSentence(); ;
            layoffProtectionText.GetComponent<BenefitTextManager>().NextSentence(); ;
            retirementContributionsText.GetComponent<BenefitTextManager>().NextSentence();
        }

        if (achievementManager.GetComponent<AchievementManager>().brokeWorkstation == true && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))))
        {
            brokeWorkstationBadge.GetComponent<Animator>().SetTrigger("EndAchievedBroke");
        }
        if (achievementManager.GetComponent<AchievementManager>().solidarityMaxed == true && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))))
        {
            maxSolidarityBadge.GetComponent<Animator>().SetTrigger("EndAchievedMax");
        }
        if (achievementManager.GetComponent<AchievementManager>().topClimbed == true && (Event.current.Equals(Event.KeyboardEvent("return")) || Event.current.Equals(Event.KeyboardEvent("space"))))
        {
            topClimbBadge.GetComponent<Animator>().SetTrigger("EndAchievedClimbed");
        }
    }
}
