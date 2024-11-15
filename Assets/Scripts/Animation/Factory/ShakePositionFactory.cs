using UnityEngine;


namespace SO
{
    [CreateAssetMenu(fileName = "AnimationFactory", menuName = "AnimationFactory/ShakePosition")]
    public class ShakePositionFactory : AnimatableFactory
    {
        public override IAnimatable CreateAnimationEffects()
        {
            return new ShakePosition();
        }
    }
}