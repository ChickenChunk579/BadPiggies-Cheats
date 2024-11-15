using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
	private void Awake()
	{
		
	}

	private void Update()
	{
		
	}

	private float updateInterval = 0.5f;

	private float frames;

	private float timeleft;

	private Stopwatch m_stopwatch = new Stopwatch();
}
