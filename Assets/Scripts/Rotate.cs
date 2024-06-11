using UnityEngine;
using DG.Tweening;

public class Rotate : DORepeatedTransform
{
	private void Start()
	{
		transform.DORotate(TargetRotate, Duration).SetLoops(Repeats, LoopType);
	}
}