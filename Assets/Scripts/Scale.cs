using DG.Tweening;
using UnityEngine;

public class Scale : DORepeatedTransform
{
	private void Start()
	{
		transform.DOScale(TargetScale, Duration).SetLoops(Repeats, LoopType);
	}
}