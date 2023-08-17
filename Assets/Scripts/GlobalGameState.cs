using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class GlobalGameState
{
    public static GameStates currentGameState = GameStates.UIShowOnScreen
        public static void ChangeGameState()
    {
        switch (currentGameState)
        {
            case GameStates.UIShowOnScreen:
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
                break;
            case GameStates.AbleToMove:
                Cursor.lockState = CursorLockMode.Locked; 
                Cursor.visible = false; 
                break;
            case GameStates.NotAbleToMove:
                Cursor.lockState = CursorLockMode.Locked;
                Cursor visible = false;
                break;
                default;
                break; 
        }
    }
        
}
public enum GameStates
{
    UIShowOnScreen
        AbleToMove
        NotAbleToMove

}