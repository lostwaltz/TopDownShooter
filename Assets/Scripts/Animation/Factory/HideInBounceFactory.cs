using UnityEngine;


namespace SO
{
    [CreateAssetMenu(fileName = "AnimationFactory", menuName = "AnimationFactory/HideFlash")]
    public class HideInBounceFactory : AnimatableFactory
    {
        public override IAnimatable CreateAnimationEffects()
        {
            return new HideInBounce();
        }
    }
}