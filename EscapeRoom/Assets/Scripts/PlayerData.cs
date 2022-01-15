using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData //klasa potrzebna ¿eby jej instancje wrzuciæ w BinaryFormatter
{
    public  bool Level2Unlocked = false;
    public  bool Level3Unlocked = false;
    public  bool Level3Finished = false;
    public  bool LevelSpecialUnlocked = false;
    public  bool Item1Found = false;
    public  bool Item2Found = false;
    public  bool Item3Found = false;

    public PlayerData(bool level2Unlocked, bool level3Unlocked, bool level3Finished, bool levelSpecialUnlocked, bool item1Found, bool item2Found, bool item3Found)
    {
        Level2Unlocked = level2Unlocked;
        Level3Unlocked = level3Unlocked;
        Level3Finished = level3Finished;
        LevelSpecialUnlocked = levelSpecialUnlocked;
        Item1Found = item1Found;
        Item2Found = item2Found;
        Item3Found = item3Found;
    }
}
