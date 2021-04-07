using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    bool isDead;
    [SerializeField] GameManager gameManager;

    public GameObject rightclick;
    public GameObject leftclick;
    public GameObject player;
    public GameObject enemy2;
    public GameObject enemyblock2;
    public GameObject playerblock2;

    //死ぬときのエフェクト
    [SerializeField] GameObject BreakEffect;
    //SE
    [SerializeField] AudioClip deathSE;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (isDead)
        {
            Debug.Log(isDead);

            audioSource.PlayOneShot(deathSE);

        }
        if (Enemy1.hp1 <= gameManager.count)
        {
            rightclick.SetActive(false);
            leftclick.SetActive(true);
        }

    }

    public void Event()
    {
        //敵を倒せる状態で敵を左クリック
        if (Enemy1.hp1 <= gameManager.count)
        {

            if (Input.GetMouseButtonUp(0))
                {
                isDead = true;
                //爆破エフェクト
                Instantiate(BreakEffect, this.transform.position, this.transform.rotation);

                //敵死ぬ。倒したメッセージ表示
                Destroy(gameObject);
                Destroy(leftclick.gameObject);

                Invoke(nameof(Enemy2), 0.3f);

                enemy2.SetActive(true);
                enemyblock2.SetActive(true);
                playerblock2.SetActive(true);

                //残り敵数を1減らす
                gameManager.enemy_count--;

                if (gameManager.enemy_count <= 0)
                {
                    gameManager.GameClear();
                }
            }
        }

    }
}
