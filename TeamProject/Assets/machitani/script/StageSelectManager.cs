using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectManager : MonoBehaviour
{
    public void OnStageSelectButtonPressed(int bossID)
    {
        SceneManager.LoadScene(bossID + 1);
    }
}
