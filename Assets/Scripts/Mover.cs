using DG.Tweening;

public class Mover : DORepeatedTransform
{
	private void Start()
	{
		transform.DOMove(TargetValue, Duration).SetLoops(Repeats, LoopType);
	}
}