using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
	[SerializeField] private LoopType _loopType;

	private int _repeats = -1;
	private Vector3 _randomPosition = new(99, 99, 99f);
	private float _duration = 2f;

	void Start()
	{
		transform.DORotate(_randomPosition, _duration).SetLoops(_repeats, _loopType);
	}
}