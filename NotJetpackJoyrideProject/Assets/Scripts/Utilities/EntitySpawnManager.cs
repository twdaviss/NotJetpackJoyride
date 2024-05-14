using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySpawnManager : MonoBehaviour
{
    [SerializeField] private CoinManager coinManager;
    [SerializeField] private ZapperManager zapperManager;
    [SerializeField] private RocketManager rocketManager;
    [SerializeField] private LaserManager laserManager;
    [SerializeField] private float zapperCoinSpawnDelay;
    [SerializeField] private float delayAfterCoinSpawn;
    [SerializeField] private float delayAfterZapperSpawn;
    [SerializeField] private float rocketSpawnDelay;
    [SerializeField] private float laserSpawnDelay;

    private float currentZapperCoinTimer = 0.0f;
    private float currentRocketTimer = 0.0f;
    private float currentLaserTimer = 0.0f;

    public void Update()
    {
        currentZapperCoinTimer += Time.deltaTime;
        currentRocketTimer += Time.deltaTime;
        currentLaserTimer += Time.deltaTime;

        if (currentZapperCoinTimer > zapperCoinSpawnDelay)
        {
            int zapperOrCoin = Random.Range(0, 5);
            if (zapperOrCoin == 0)
            {
                coinManager.SpawnCoins();
                zapperCoinSpawnDelay = delayAfterCoinSpawn;
            }
            else
            {
                zapperManager.SpawnZapper();
                zapperCoinSpawnDelay = delayAfterZapperSpawn;
            }
            currentZapperCoinTimer = 0.0f;
        }
        if (currentRocketTimer > rocketSpawnDelay)
        {
            rocketManager.SpawnRockets();
            currentRocketTimer = 0.0f;
        }
        if (currentLaserTimer > laserSpawnDelay)
        {
            laserManager.SpawnLaser();
            currentLaserTimer = 0.0f;
        }
    }
}
