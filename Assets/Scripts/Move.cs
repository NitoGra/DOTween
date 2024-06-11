using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
	[SerializeField] private LoopType _loopType;

	private int _repeats = -1;
	private Vector3 _randomPosition = new(0, 3, 10f);
	private float _duration = 2f;

	void Start()
	{
		transform.DOMove(_randomPosition, _duration).SetLoops( _repeats, _loopType);
	}
}