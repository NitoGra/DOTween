using DG.Tweening;
using UnityEngine;

public class Scale : MonoBehaviour
{
	[SerializeField] private LoopType _loopType;

	private int _repeats = -1;
	private Vector3 _targetScale = new(0.01f, 99, 1);
	private float _duration = 2f;

	private void Start()
	{
		transform.DOScale(_targetScale, _duration).SetLoops(_repeats, _loopType);
	}
}