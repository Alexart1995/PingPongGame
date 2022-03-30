using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButBeh : MonoBehaviour
{
    public void OnButtonPressed(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
}
