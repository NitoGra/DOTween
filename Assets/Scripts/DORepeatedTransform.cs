using DG.Tweening;
using UnityEngine;

public class DORepeatedTransform : MonoBehaviour
{
	[SerializeField] protected LoopType LoopType;

	protected Vector3 TargetPosition = new(0, 3, 10f);
	protected Vector3 TargetRotate = new(99, 99, 99f);
	protected Vector3 TargetScale = new(0.01f, 99, 1);

	protected int Repeats = -1;
	protected float Duration = 2f;
}