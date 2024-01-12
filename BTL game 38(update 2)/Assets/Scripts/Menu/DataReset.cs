using UnityEngine;

public class DataReset : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        ResetGameData();
    }

    // Ð?t phýõng th?c này ð? xóa s?ch d? li?u
    private void ResetGameData()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("D? li?u ð? ðý?c xóa s?ch.");
    }
}
