using UnityEngine;

[CreateAssetMenu(fileName = "BasicAnimBased", menuName = "Module Actions/BasicAnimBased", order = 1)]
class BasicAnimBased : Module_Action
{
    public Animator anim;
    public override void Action()
    {
        base.Action();
        // anim.Play(AnimationNodeName);
        anim.Play(AnimationNodeName);

        if (Module_Manager._instance.Characters[0] != anim.GetComponentInParent<Character_Manager>())
        {
            Module_Manager._instance.Characters[0].DecreaseLife(amount);
        }else
            Module_Manager._instance.Characters[1].DecreaseLife(amount);

    }
}
