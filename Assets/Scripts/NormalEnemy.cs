using UnityEngine;
using UnityEngine.EventSystems;

namespace ClickerGame
{
  public class NormalEnemy : MonoBehaviour, IDamageable
  {
    [SerializeField] private EnemyManager _enemyManager = null;
    // 敵HP
    private int _hp { get; set;} = 5;
    
    private void Start()
    {
      EventTrigger trigger = GetComponent<EventTrigger>();
      EventTrigger.Entry entry = new EventTrigger.Entry();
      entry.eventID = EventTriggerType.PointerDown;
      entry.callback.AddListener((data) => { OnEnemyClickDelegate((PointerEventData)data); });
      trigger.triggers.Add(entry);
    }
    
    public void AddDamage(int damage)
    {
      _hp -= damage;
      PlayerManager.clickCount = 0; // クリック回数リセット
    }

    private void OnEnemyClickDelegate(PointerEventData data)
    {
      if (PlayerManager.clickCount <= 0 || Input.GetMouseButtonDown(1)) return;

      if (PlayerManager.clickCount >= _hp) {

        PlayerManager.clickCount -= _hp;
        _hp = 0;

        #if UNITY_EDITOR
        Debug.Log("敵を倒した！");
        #endif

        _enemyManager.enemyDestroyedNumber++;

        Destroy(gameObject);       

      } else {
        
        AddDamage(PlayerManager.clickCount);

        #if UNITY_EDITOR
        Debug.Log($"残りHP:{_hp}");
        #endif
      }
    }
  }
}