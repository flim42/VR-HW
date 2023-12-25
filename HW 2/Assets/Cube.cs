using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
public GameObject Sphere;
public float Speed = 10f;

private ScoreManager scoreManager;
private Renderer cubeRenderer;
private Color originalColor = Color.white;

void Start()
{
    Sphere = GameObject.Find("Sphere");
    scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    cubeRenderer = GetComponent<Renderer>();
    originalColor = cubeRenderer.material.color;
}

void Update()
{
if (Input.GetKey(KeyCode.W))
{
    transform.Translate(Vector3.forward * Speed * Time.deltaTime);
}
if (Input.GetKey(KeyCode.A))
{
    transform.Rotate(Vector3.down * 5 * Speed * Time.deltaTime);
}
if (Input.GetKey(KeyCode.S))
{
    transform.Translate(Vector3.back * Speed * Time.deltaTime);
}
if (Input.GetKey(KeyCode.D))
{
    transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
}

if (scoreManager.Score <= -6)
{
    Destroy(Sphere);
    Debug.Log("Вы победили!");
}
}

private void OnCollisionEnter(Collision collision)
{
if (collision.gameObject == Sphere)
{
    scoreManager.Score -= 1;
    cubeRenderer.GetComponent<Renderer>().material.color = Color.red;
    StartCoroutine(ResetColorAfterDelay(0.5f));
}
}

private IEnumerator ResetColorAfterDelay(float delay)
{
    yield return new WaitForSeconds(delay);
    cubeRenderer.GetComponent<Renderer>().material.color = originalColor;
}

public void Heal()
{
scoreManager.Score = 5;
}
}
