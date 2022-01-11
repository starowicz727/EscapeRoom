using UnityEngine;


public class GameState : MonoBehaviour
{
    public static bool SoundOn = true;
    public static bool Level2Unlocked = false;
    public static bool Level3Unlocked = false;
    public static bool Level3Finished = false;
    public static bool LevelSpecialUnlocked = false;

    public static bool Item1Found = false; // to trzeba jeszcze dopisac do konstruktora do odblokowania lvl special 
    public static bool Item2Found = false;
    public static bool Item3Found = false;

    
    
    //public static int score = 0;
    //public static string nickGameState = Player.nick;
    //public static float timeGameState = Player.time;

    public static void SaveMyGameState() //będziemy zapisywać po przejściu na kolejny level oraz po kliknięciu quit 
    {
        //DataSave.SaveGameState(SoundOn, Level2Unlocked, Level3Unlocked, Level3Finished, LevelSpecialUnlocked);
        DataSave.SaveGameState(Level2Unlocked, Level3Unlocked, Level3Finished, LevelSpecialUnlocked);
    }
    public static void LoadMyGameState() // będziemy odczytywać dane przy Start() w menu 
    {
        PlayerData data = DataSave.LoadGameState();
        //SoundOn = data.SoundOn;
        Level2Unlocked = data.Level2Unlocked;
        Level3Unlocked = data.Level3Unlocked;
        Level3Finished = data.Level3Finished;
        LevelSpecialUnlocked = data.LevelSpecialUnlocked;
    }

    //public void UnlockLvl2() //użyte gdy w levelu 1 pokazuje się portal
    //{
    //    Level2Unlocked = true;
    //}
}
