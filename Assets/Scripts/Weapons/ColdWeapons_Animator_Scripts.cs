using Assets.Prefab.Player;
using UnityEngine;

public class coldWeapons1 : MonoBehaviour
{
    private Animator _animator => GetComponent<Animator>();
    private Player_Script _player_Script => GetComponent<Player_Script>();

    private void Update()
    {
        /*_animator.SetBool(PlayerAnimationStrings.Attacks, _animator.Attacks);*/
    }
}
