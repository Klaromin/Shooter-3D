using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float gameTime;
    public int enemyNumber = 3;
    public int levelCount = 0;
    [SerializeField] TextMeshProUGUI text;
    public bool isFirstCheckpoint = false;

    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    private void Update()
    {
        gameTime += Time.deltaTime;
        LevelCounter();
        text.text = gameTime.ToString();
    }
    public void LevelCounter()
    {
        if (GameManager.Instance.enemyNumber == 0)
        {
            GameManager.Instance.levelCount++;
            GameManager.Instance.enemyNumber = 3;
        }
    }

    public enum GameState
    {

    }
}






//private static GameManager _instance = null;

//public static GameManager Instance
//{
//    get
//    {
//        if (_instance is null)
//        {
//            _instance = new GameObject("GameManager").AddComponent<GameManager>();
//        }
//        return _instance;
//    }
//}