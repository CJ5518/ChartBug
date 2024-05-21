using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DataVisualizer;

public class Main : MonoBehaviour {
	public DataSeriesChart chart;

	void Start() {
		
	}
	float dt = 1.0f;
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			var category = chart.DataSource.GetCategory("top").Data; // obtain category data
			category.Append(0.0f, 1000000.0f); // call append to add a new point to the graph

			var category2 = chart.DataSource.GetCategory("bottom").Data; // obtain category data
			category2.Append(0.0f, 1.0f);
		}
	}
}
