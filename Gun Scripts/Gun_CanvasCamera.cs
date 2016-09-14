using UnityEngine;
using System.Collections;

public class Gun_CanvasCamera : MonoBehaviour {
	public Canvas weap;
	public Canvas heal;
	public RectTransform weapR;
	public RectTransform healR;
	void Start(){
		weapR.localPosition.Equals (healR.localPosition);
	}



}
