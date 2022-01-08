using UnityEngine;

[System.Serializable]
public class GameState : MonoBehaviour
{
    public static bool SoundOn = true;
    public static bool Level2Unlocked = false;
    public static bool Level3Unlocked = false;
    public static bool LevelSpecialUnlocked = false;
    
    //public static int score = 0;
    //public static string nickGameState = Player.nick;
    //public static float timeGameState = Player.time;

    public GameState(bool soundOn, bool level2Unlocked)
    {
        SoundOn = soundOn;
        Level2Unlocked = level2Unlocked;
    }

    public void UnlockLvl2()
    {
        Level2Unlocked = true;
    }
}
