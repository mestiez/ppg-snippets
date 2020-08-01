public class SuperCoolBehaviour : MonoBehaviour
{
    private void Awake()
    {
        //create polygon collider for demonstration purposes
        var poly = gameObject.AddComponent<PolygonCollider2D>();
        poly.SetPath(0, new[]{
            new Vector2(0,0),
            new Vector2(5,0),
            new Vector2(0,5),
        });
    }

    //you should generally draw debug primitives in OnWillRenderObject
    private void OnWillRenderObject()
    {
        //NEVER USE ModAPI.Draw IN YOUR RELEASED MOD
        //THEY ARE SLOW AND NOT MEANT FOR ANYTHING OTHER THAN DEBUGGING

        //draw line from this GameObject to some place else
        ModAPI.Draw.Line(transform.position, new Vector3(76, 43));

        //draw rectangle here and with width 4, height 2
        ModAPI.Draw.Rect(transform.position, new Vector3(4,2));

        //draw a cool circle with a radius of 8 at the transform position
        ModAPI.Draw.Circle(transform.position, 8);

        //draw the effective shapes of all colliders attached to this object
        foreach (var item in GetComponents<Collider2D>())
        {
            ModAPI.Draw.Collider(item);
        }
    }
}
