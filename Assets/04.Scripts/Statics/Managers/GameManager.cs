﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 게임 시작과 동시에 싱글톤을 구성
    void Awake()
    {
        instance = this;
    }

    public void GameStart()
    {
        SpritesUI.instance.StartLoop();
        StartCoroutine(_MakePlatform());
    }

    public void Restart()
    {
        if (!isGameover) return;
        DBManager.bestScore = Mathf.Max(DBManager.bestScore, score);
        SceneManager.LoadScene(SceneName.PLAY);
    }

    // 점수를 증가시키는 메서드
    public void AddScore(int value)
    {
        if (isGameover) return;
        score += value;
        PlayCanvas.instance.IngameUI.scoreText.Update_(score);
    }

    // 플레이어 캐릭터가 사망시 게임 오버를 실행하는 메서드
    public void OnPlayerDead()
    {
        isGameover = true;
        PlayCanvas.instance.gameOverUI.SetActive(true);
    }

    IEnumerator _MakePlatform()
    {
        while (!isGameover)
        {
            var platform = ObjectPool.instance.GetPlatform();
            platform.gameObject.SetActive(true);
            
            yield return new WaitForSeconds(platformSpawnTime);
        }
    }

    public static GameManager instance = null;
    public bool isGameover { get; private set; } = false; // 게임 오버 상태
    public float platformSpawnTime = 2f;
    
    int score = 0; // 게임 점수
}