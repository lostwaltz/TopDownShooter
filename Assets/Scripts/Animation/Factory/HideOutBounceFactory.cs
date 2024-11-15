using UnityEngine;


namespace SO
{
    [CreateAssetMenu(fileName = "AnimationFactory", menuName = "AnimationFactory/HideBounce")]
    public class HideOutBounceFactory : AnimatableFactory
    {
        public override IAnimatable CreateAnimationEffects()
        {
            return new HideOutBounce();
        }
    }
}