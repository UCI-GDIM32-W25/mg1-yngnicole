using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        // Decreases the number of seeds the player has left, which is displayed in the UI.
        _remainingText.text = "Seeds Remaining: " + seedsLeft--;
        
        // Increases the number of seeds the player has planted, which is displayed in the UI.
        _plantedText.text = "Seeds Planted: " + seedsPlanted++;

    }
}