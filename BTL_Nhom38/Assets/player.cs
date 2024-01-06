using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Lấy giá trị trục ngang từ bàn phím hoặc thiết bị nhập liệu
        float horizontalInput = Input.GetAxis("Horizontal");

        // Di chuyển đối tượng sang phải hoặc sang trái
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
    }
}
