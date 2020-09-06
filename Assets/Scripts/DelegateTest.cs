using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This class is simply written to test how a delegate works
/// </summary>
public class DelegateTest
{
    public delegate void WaveDelegate(); //tell the script the delegate exists
    public WaveDelegate wave; //set the delegate
    int waveNumber = 1; //Arbitrary wave number to increase difficulty per wave (every wave has one more gnome)

    void SetWave() //The function that sets the delegate. It does so by adding methods
    {
        wave += SpawnGoblin;
        for (int i = 0; i < waveNumber; i++)
        {
            wave += SpawnGnome;
        }
    }

    void SpawnWave()
    {
        wave.Invoke();
        waveNumber++;
    }

    public void SpawnGoblin()
    {
        Debug.Log("Spawned a goblin");
    }
    
    public void SpawnGnome()
    {
        Debug.Log("Spawned a gnome");
    }

    public void ClearWave()
    {
        wave = null;
    }
}
