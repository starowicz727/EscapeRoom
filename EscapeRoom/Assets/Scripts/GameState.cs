using UnityEngine;


public class GameState : MonoBehaviour
{
    public static bool SoundOn = true;
    public static bool Level2Unlocked = false;
    public static bool Level3Unlocked = false;
    public static bool Level3Finished = false;
    public static bool LevelSpecialUnlocked = false;

    public static bool Item1Found = false; 
    public static bool Item2Found = false;
    public static bool Item3Found = false;

    public static void SaveMyGameState() //będziemy zapisywać po przejściu na kolejny level oraz po kliknięciu quit 
    {
        DataSave.SaveGameState(Level2Unlocked, Level3Unlocked, Level3Finished, LevelSpecialUnlocked,Item1Found,Item2Found,Item3Found);
    }
    public static void LoadMyGameState() // będziemy odczytywać dane przy Start() w menu oraz Start() przy BackgroundMusic.cs   
    {                                                                                       //bo ten skrypt jest na każdej scenie
        PlayerData data = DataSave.LoadGameState();
        Level2Unlocked = data.Level2Unlocked;
        Level3Unlocked = data.Level3Unlocked;
        Level3Finished = data.Level3Finished;
        LevelSpecialUnlocked = data.LevelSpecialUnlocked;
        Item1Found = data.Item1Found;
        Item2Found = data.Item2Found;
        Item3Found = data.Item3Found;
    }
}
