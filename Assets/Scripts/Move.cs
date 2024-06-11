using UnityEngine;
using DG.Tweening;
using TMPro;

public class Move : DORepeatedTransform
{
	private void Start()
	{
		transform.DOMove(TargetPosition, Duration).SetLoops(Repeats, LoopType);
	}
}