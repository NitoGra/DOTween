using DG.Tweening;

public class Rotater : DORepeatedTransform
{
	private void Start()
	{
		transform.DORotate(TargetValue, Duration).SetLoops(Repeats, LoopType);
	}
}