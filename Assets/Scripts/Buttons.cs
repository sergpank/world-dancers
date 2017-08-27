using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public Sprite button_image, pressed_button_image;

    public string scene_name_to_load;

    private readonly string default_scene_name = "MainScene";

	void OnMouseDown() {
        GetComponent<SpriteRenderer>().sprite = pressed_button_image;
    }

    void OnMouseUp() {
        GetComponent<SpriteRenderer>().sprite = button_image;
    }

    void OnMouseUpAsButton() {
        string currentSceneName = SceneManager.GetActiveScene().name;
        bool isCurrentSceneDefault = currentSceneName.Equals(default_scene_name, StringComparison.InvariantCultureIgnoreCase);
        SceneManager.LoadScene(isCurrentSceneDefault ? scene_name_to_load : default_scene_name);
    }
}
