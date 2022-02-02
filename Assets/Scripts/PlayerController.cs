using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClickerGame {
  public class PlayerController : MonoBehaviour
  {
    private Rigidbody2D _rigidBody;
    private float _jumpForce = 100f;
    private int _clickCount  = 0;

    private void Start()
    {
      _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
      if (Input.GetMouseButtonDown(1)) {
        AddClickCount();
      } else {
        return;
      }
    }

  /// <summary>
  /// 右クリック時にクリック回数を増加させる
  /// </summary>
    private void AddClickCount()
    {
        _clickCount++;

        #if UNITY_EDITOR
        Debug.Log($"クリック回数:{_clickCount}");
        #endif

        // 上にジャンプ
        _rigidBody.AddForce(transform.up * _jumpForce);
    }
  }
}

