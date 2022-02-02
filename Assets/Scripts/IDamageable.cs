
namespace ClickerGame
{
  public interface IDamageable 
  {
    /// <summary>
    /// 敵にダメージを与える
    /// </summary>
    /// <param name="damage">与えるダメージ量</param>
    void AddDamage(int damage);
  }
}