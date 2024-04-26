using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;  //새성할 탄아의 원본 프리팹
    public float spawnRateMin = 0.5f;  //최소 생성 주기
    public float spawnRateMax = 3f;  //최대 생성 주기

    private Transform target;   //발사할 대상
    private float spawnRate;    //생성주기
    private float timeAfterSpawn;  //최근 생성시점에서 지난 시간
    void Start()
    {
        //최근 생성 이후의 누적 시간을 0으로 초기화
        timeAfterSpawn = 0f;
        //찬알 생성 간격을 spawnRateMin과 spawnRateMax 사이에서 랜덤 지정, 최소값은 포함.
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerConntroller 컴포넌트를 가진 게임 오브젝트를 찾아 조준 대상으로 설정
        target = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        //타인에 프터스퐌 기산 갱신 (Update때마다 흘러간 시간을 누적 합산)
        timeAfterSpawn += Time.deltaTime;
        // TimeAfterSpawn = 
        if (timeAfterSpawn > spawnRate) 
        {
            timeAfterSpawn = 0;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        }

    }
}
