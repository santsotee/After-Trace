using UnityEngine;
public interface IPointsCollector
{
    void AddScore(int points);
}

public class Player : MonoBehaviour, IPointsCollector
{
    public float speed = 5f;
    public int pointsCollected;
    private StateMachine stateMachine;
    private InputManager inputManager;


    void Start()
    {
        inputManager = GetComponent<InputManager>();
        if (inputManager == null)
        {
            inputManager = gameObject.AddComponent<InputManager>();
        }

        stateMachine = GetComponent<StateMachine>();

        if (stateMachine == null)
        {
            stateMachine = gameObject.AddComponent<StateMachine>();
        }

        stateMachine.RegisterState("Idle", new IdleState(stateMachine, this));
        stateMachine.RegisterState("Move", new MoveState(stateMachine, this));

        stateMachine.ChangeState("Idle");

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
            rb.gravityScale = 0;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }

        // Agregar FragmentSpawner si no existe
        if (FindObjectOfType<FragmentSpawner>() == null)

        {
            gameObject.AddComponent<FragmentSpawner>();
        }

        // Agregar GameManager si no existe
        if (GameManager.Instance == null)
        {
            GameObject gmGO = new GameObject("GameManager");
            GameManager gm = gmGO.AddComponent<GameManager>();
            gm.gameObject.AddComponent<ScoreSystem>();
        }

        // Agregar UIManager si no existe
        if (FindObjectOfType<UIManager>() == null)
        {
            GameObject uiGO = new GameObject("UIManager");
            uiGO.AddComponent<UIManager>();
        }
    }

    public StateMachine GetStateMachine()
    {
        return stateMachine;
    }

    public void AddScore(int points)
    {
        pointsCollected += points;
    }
}
