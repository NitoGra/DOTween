using DG.Tweening;
using System.Collections;
using UnityEngine;

public class Text : MonoBehaviour
{
	[SerializeField] private UnityEngine.UI.Text _text;
	[SerializeField] private float _duration;
	private float _delayChange;

	private string _text1 = "текст заменён";
	private string _text2 = "текст добавлен";
	private string _text3 = "текст заменён с перебором";

	private void Start()
	{
		_delayChange = _duration + 1f;
		StartCoroutine(ChangeText());
	}

	private void FirstChange()
	{
		_text.DOText(_text1, _duration);
	}

	private void SecondChange()
	{
		_text.DOText(_text2, _duration).SetRelative();
	}

	private void ThirdChange()
	{
		_text.DOText(_text3, _duration, true, ScrambleMode.All);
	}

	private IEnumerator ChangeText()
	{
		WaitForSeconds waitForSeconds = new (_delayChange);

		FirstChange();
		yield return waitForSeconds;
		SecondChange();
		yield return waitForSeconds;
		ThirdChange();
	}
}