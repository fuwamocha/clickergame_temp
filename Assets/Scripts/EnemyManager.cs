using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager :MonoBehaviour
{
    [SerializeField] private GameObject[] _enemy;

    internal int allEnemyNumber {get; set;}
    internal int enemyDestroyedNumber {get; set;}

    private bool isAppear = false;

    private void Start()
    {
        allEnemyNumber = _enemy.Length;
    }

    private void Update() {

        if (enemyDestroyedNumber == 1 && !isAppear) {
            isAppear = true;
            Instantiate(_enemy[enemyDestroyedNumber]);
        }
    }
}
