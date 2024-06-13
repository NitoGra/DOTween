using DG.Tweening;
using UnityEngine;

public class DORepeatedTransform : MonoBehaviour
{
	[SerializeField] protected LoopType LoopType;

	protected Vector3 TargetValue = new(0, 3, 10f);

	protected int Repeats = -1;
	protected float Duration = 2f;
}