using UnityEngine;


namespace SO
{
    [CreateAssetMenu(fileName = "AnimationFactory", menuName = "AnimationFactory/ShowBounce")]
    public class ShowOutBounceFactory : AnimatableFactory
    {
        public override IAnimatable CreateAnimationEffects()
        {
            return new ShowOutBounce();
        }
    }
}