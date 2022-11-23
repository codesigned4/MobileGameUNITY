using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    private Vector3 newPosition;
    private Vector3 offset;
    public HeroStackController lastCube;
    [SerializeField] private float lerpValue;



    public void Start()
    {
        SetOffsetValue();
    }


    public void LateUpdate()
    {
        SetCameraSmoothFollow();
    }



    public void SetOffsetValue()
    {
        offset = transform.position - lastCube.GetElement().transform.position;
    }



    public void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, lastCube.GetElement().transform.position.y, lastCube.GetElement().transform.position.z) + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
