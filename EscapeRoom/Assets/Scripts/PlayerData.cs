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

    public PlayerData(bool level2Unlocked, bool level3Unlocked, bool level3Finished, bool levelSpecialUnlocked)
    {
        Level2Unlocked = level2Unlocked;
        Level3Unlocked = level3Unlocked;
        Level3Finished = level3Finished;
        LevelSpecialUnlocked = levelSpecialUnlocked;
    }
}
