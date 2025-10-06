using UnityEngine;
using UnityEngine.InputSystem;

public class ControleTriangulo : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5;
    [SerializeField]
    float velocidadeangular = 30;
    InputSystem_Actions inputSystemActions;//isso é um campo 
    InputAction move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputSystemActions = new InputSystem_Actions();
        move = inputSystemActions.Player.Move;
        inputSystemActions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 sentido = move.ReadValue<Vector2>();
        transform.Translate(0, velocidade * sentido.y * Time.deltaTime, 0);
        transform.Rotate(0, 0, velocidadeangular * sentido.x * Time.deltaTime);
    }
}
