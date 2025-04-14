using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Classe responsable uniquement de l'affichage des messages à l'utilisateur
public class UIMessageDisplay : MonoBehaviour
{
    [SerializeField] private GameObject messagePanel;
    [SerializeField] private Text messageText;
    [SerializeField] private float defaultDisplayTime = 3f;
    
    // Affiche un message à l'utilisateur
    public void ShowMessage(string message, float displayTime = -1)
    {
        if (messagePanel == null || messageText == null)
            return;
            
        messageText.text = message;
        messagePanel.SetActive(true);
        
        // Utiliser le temps par défaut si non spécifié
        if (displayTime < 0)
            displayTime = defaultDisplayTime;
            
        // Masquer le message après le délai
        StopAllCoroutines();
        StartCoroutine(HideMessageAfterDelay(displayTime));
    }
    
    // Masque immédiatement le message
    public void HideMessage()
    {
        if (messagePanel != null)
        {
            messagePanel.SetActive(false);
        }
    }
    
    // Masque le message après un délai
    private IEnumerator HideMessageAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        HideMessage();
    }
}