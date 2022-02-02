using UnityEngine;

namespace ClickerGame
{
  public class NormalEnemy : MonoBehaviour, IDamageable
  {
    // 敵HP
    private int _hp { get; set;}

    private void Start() {
      _hp = 5;
    }
    
    public void AddDamage(int damage)
    {
      _hp -= damage;
    }
  }
}