using Assets.Prefab.Player;
using UnityEngine;

public class Player_Animator_Scripts : MonoBehaviour
{
    private Animator _animator => GetComponent<Animator>();
    private Player_Script _player_Script => GetComponent<Player_Script>();

    private void Update()
    {
        _animator.SetBool(PlayerAnimationStrings.IsMove, _player_Script.IsMove);
    }

    public void Flip(float x)
    {
        if ((x > 0 && transform.localScale.x < 0) || (x < 0 && transform.localScale.x > 0))
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
