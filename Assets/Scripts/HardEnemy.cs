using UnityEngine;

namespace ClickerGame
{
  public class HardEnemy : MonoBehaviour, IDamageable
  {
    // 敵HP
    private int _hp     { get; set;}
    private int _shield { get; set;}

    private void Start() {
      _hp     = 5;
      _shield = 5;
    }

    public void AddDamage(int damage)
    {
      if (_shield > 0)
      {
        _shield -= damage;
      } else {
        _hp -= damage;
      }
    }
  }
}