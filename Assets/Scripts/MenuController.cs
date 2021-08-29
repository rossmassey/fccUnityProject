using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string GAMEPLAY_SCENE = "Gameplay";

    public void PlayGame()
    {
        string playerChoice = UnityEngine.EventSystems.EventSystem
            .current.currentSelectedGameObject.name;

        int player = int.Parse(playerChoice);

        GameManager.instance.CharIndex = player;

        SceneManager.LoadScene(GAMEPLAY_SCENE);
    }
}
