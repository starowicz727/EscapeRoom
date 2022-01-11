using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class DataSave //klasa statyczna ¿eby nie utworzyæ ró¿nych instancji 
{
   public static void SaveGameState(bool level2Unlocked, bool level3Unlocked, bool level3Finished, bool levelSpecialUnlocked)
   {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/FindItGameState.txt"; //persistentDataPath to w³aœciwoœæ uniwersalna dla ka¿dego systemu operacyjnego 
        FileStream stream = new FileStream(path, FileMode.Create);

        //PlayerData gameStateData = new PlayerData(soundOn, level2Unlocked, level3Unlocked, level3Finished, levelSpecialUnlocked);
        PlayerData gameStateData = new PlayerData(level2Unlocked, level3Unlocked, level3Finished, levelSpecialUnlocked);

        formatter.Serialize(stream, gameStateData);
        stream.Close();
   }

    public static PlayerData LoadGameState() //odczytujemy plik do obiektu PlayerData
    {
        string path = Application.persistentDataPath + "/FindItGameState.txt"; //persistentDataPath to w³aœciwoœæ uniwersalna dla ka¿dego systemu operacyjnego 
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData gameStateData = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return gameStateData;
        }
        else
        {
            Debug.LogError("File not found in " + path);
            return null;
        }
    }

}
