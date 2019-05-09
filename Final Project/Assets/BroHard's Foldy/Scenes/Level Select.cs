using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

	public int ID { get; set; }
	public string stage1 { get; set; }
	public bool Locked {get; set;}

	public Level (int id, string stage1, bool locked)
	{
		this.ID =  id;
		this.LevelName = LevelName;
		this.Locked = locked;
	}

	public void Lock()
	{
		this.Locked = true;
	}

	public void Unlock()
	{
		this.Locked = false;
	}
}
///NEED MORE///