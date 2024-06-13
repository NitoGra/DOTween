using DG.Tweening;
using UnityEngine;

public class Colorer : DORepeatedTransform
{
	[SerializeField] private SpriteRenderer _spriteRenderer;
	[SerializeField] private Color32 _color;

	private float _duration = 2f;

	private void Start()
	{
		_spriteRenderer.DOColor(_color, _duration).SetLoops(Repeats, LoopType);
	}
}