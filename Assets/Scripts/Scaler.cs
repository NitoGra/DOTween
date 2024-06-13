using DG.Tweening;

public class Scaler : DORepeatedTransform
{
	private void Start()
	{
		transform.DOScale(TargetValue, Duration).SetLoops(Repeats, LoopType);
	}
}