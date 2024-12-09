using Assets.Prefab.Weapons.ColdWeapons.Sword1;
using UnityEngine;

public class Sword1_Animator_Scripts : MonoBehaviour
{
    private Animator _animator => GetComponent<Animator>();
    private Sword1 sword1 => GetComponent<Sword1>();

    private void Update()
    {
        _animator.SetBool(Sword1AnimationStrings.Attacks, sword1.Attacks);
        Debug.Log(sword1.Attacks);
    }
}
