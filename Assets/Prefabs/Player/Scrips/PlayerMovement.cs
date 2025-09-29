using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// fuerza que se aplicará al objeto cada cierto intervalo de tiempo
    /// </summary>
    private Vector3 forceToApply;
    /// <summary>
    /// tiempo transcurrido desde la última aplicación de fuerza
    /// </summary>
    private float timeSinceLastForce;
    /// <summary>
    /// intervalo de tiempo en segundos entre cada aplicación de fuerza
    /// </summary>
    private float intervalTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    #region Ciclo de vida 
    void Start()
    {
        forceToApply = new Vector3(0, 0, 300);
        timeSinceLastForce = 0f;
        intervalTime = 2f; // Apply force every 2 seconds

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        timeSinceLastForce += Time.fixedDeltaTime;
        if (timeSinceLastForce >= intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply);
            timeSinceLastForce = 0f;
        }

    }
    #endregion
}
