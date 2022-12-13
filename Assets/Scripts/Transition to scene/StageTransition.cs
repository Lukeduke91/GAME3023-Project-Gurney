using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageTransition : MonoBehaviour
{
    public void changeToMainGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
