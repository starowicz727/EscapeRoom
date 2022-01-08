using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class DataSave //klasa statyczna ¿eby nie utworzyæ ró¿nych instancji 
{
   public static void SaveGameState(bool soundOn, bool level2Unlocked)
   {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/FindItGameState.txt"; //persistentDataPath to w³aœciwoœæ uniwersalna dla ka¿dego systemu operacyjnego 
        FileStream stream = new FileStream(path, FileMode.Create);

        GameState gameStateData = new GameState(soundOn, level2Unlocked);

        formatter.Serialize(stream, gameStateData);
        stream.Close();
   }

    public static GameState LoadGameState()
    {
        string path = Application.persistentDataPath + "/FindItGameState.txt"; //persistentDataPath to w³aœciwoœæ uniwersalna dla ka¿dego systemu operacyjnego 
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameState gameStateData = formatter.Deserialize(stream) as GameState;
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
