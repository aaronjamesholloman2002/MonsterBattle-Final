using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OnMenu()
    {
        SceneManager.LoadScene("MasterScene");
    }

    public void OnMaster() {

        SceneManager.LoadScene("BattleScene");
    }
}
