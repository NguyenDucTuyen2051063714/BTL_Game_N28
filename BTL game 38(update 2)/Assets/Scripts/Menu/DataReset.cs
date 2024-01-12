using UnityEngine;

public class DataReset : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        ResetGameData();
    }

    // �?t ph��ng th?c n�y �? x�a s?ch d? li?u
    private void ResetGameData()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("D? li?u �? ��?c x�a s?ch.");
    }
}
