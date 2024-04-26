using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;  //������ ź���� ���� ������
    public float spawnRateMin = 0.5f;  //�ּ� ���� �ֱ�
    public float spawnRateMax = 3f;  //�ִ� ���� �ֱ�

    private Transform target;   //�߻��� ���
    private float spawnRate;    //�����ֱ�
    private float timeAfterSpawn;  //�ֱ� ������������ ���� �ð�
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        //���� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� ����, �ּҰ��� ����.
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        //PlayerConntroller ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        //Ÿ�ο� ���ͽ��p ��� ���� (Update������ �귯�� �ð��� ���� �ջ�)
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
