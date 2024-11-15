using UnityEngine;


namespace SO
{
    [CreateAssetMenu(fileName = "AnimationFactory", menuName = "AnimationFactory/UpScaleBounceOut")]
    public class UpScaleBounceOutFactory : AnimatableFactory
    {
        public override IAnimatable CreateAnimationEffects()
        {
            return new UpScaleBounceOut();
        }
    }
}