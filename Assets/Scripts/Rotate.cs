using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
	[SerializeField] private LoopType _loopType;

	private int _repeats = -1;
	private Vector3 _targetRotate = new(99, 99, 99f);
	private float _duration = 2f;

	private void Start()
	{
		transform.DORotate(_targetRotate, _duration).SetLoops(_repeats, _loopType);
	}
}