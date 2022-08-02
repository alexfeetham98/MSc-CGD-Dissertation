using UnityEngine;

//complete list of unity inpector attributes https://docs.unity3d.com/ScriptReference/AddComponentMenu.html?_ga=2.45747431.2107391006.1601167752-1733939537.1520033247
//inspector attributes https://unity3d.college/2017/05/22/unity-attributes/
//Nvidia Flex video https://youtu.be/TNAKv1dkYyQ

public class BoneCube : MonoBehaviour
{
    /*
        E --------- F
        |           |
        |   A --------- B
        |   |       |   |
        |   |       |   |
        H --|------ G   |
            |           |
            D --------- C
    */
    [Header("Bones")]
    public GameObject A = null;
    public GameObject B = null;
    public GameObject C = null;
    public GameObject D = null;
    public GameObject E = null;
    public GameObject F = null;
    public GameObject G = null;
    public GameObject H = null;
    public GameObject I = null;
    public GameObject J = null;
    public GameObject K = null;
    public GameObject L = null;
    public GameObject M = null;
    public GameObject N = null;
    public GameObject O = null;
    public GameObject P = null;
    [Header("Spring Joint Settings")]
    [Tooltip("Strength of spring")]
    public float Spring = 100f;
    [Tooltip("Higher the value the faster the spring oscillation stops")]
    public float Damper = 0.2f;
    [Header("Other Settings")]
    public Softbody.ColliderShape Shape = Softbody.ColliderShape.Box;
    public float ColliderSize = 0.002f;
    public float RigidbodyMass = 1f; 
    public LineRenderer PrefabLine = null;
    public bool ViewLines = true;

    private void Start()
    {
        Softbody.Init(Shape, ColliderSize, RigidbodyMass, Spring, Damper, RigidbodyConstraints.None, PrefabLine, ViewLines);

        Softbody.AddCollider(ref A);
        Softbody.AddCollider(ref B);
        Softbody.AddCollider(ref C);
        Softbody.AddCollider(ref D);
        Softbody.AddCollider(ref E);
        Softbody.AddCollider(ref F);
        Softbody.AddCollider(ref G);
        Softbody.AddCollider(ref H);

        Softbody.AddCollider(ref I);
        Softbody.AddCollider(ref J);
        Softbody.AddCollider(ref K);
        Softbody.AddCollider(ref L);
        Softbody.AddCollider(ref M);
        Softbody.AddCollider(ref N);
        Softbody.AddCollider(ref O);
        Softbody.AddCollider(ref P);

        // down outer
        Softbody.AddSpring(ref A, ref D);
        Softbody.AddSpring(ref B, ref C);
        Softbody.AddSpring(ref F, ref G);
        Softbody.AddSpring(ref E, ref H);

        // down inner
        Softbody.AddSpring(ref I, ref L);
        Softbody.AddSpring(ref J, ref K);
        Softbody.AddSpring(ref M, ref P);
        Softbody.AddSpring(ref N, ref O);

        // diagonals inner
        //Softbody.AddSpring(ref A, ref G);
        //Softbody.AddSpring(ref B, ref H);
        //Softbody.AddSpring(ref F, ref D);
        //Softbody.AddSpring(ref E, ref C);
        Softbody.AddSpring(ref A, ref I);
        Softbody.AddSpring(ref B, ref J);
        Softbody.AddSpring(ref F, ref N);
        Softbody.AddSpring(ref E, ref M);
        Softbody.AddSpring(ref D, ref L);
        Softbody.AddSpring(ref C, ref K);
        Softbody.AddSpring(ref G, ref O);
        Softbody.AddSpring(ref H, ref P);

        // diagonals outer
        Softbody.AddSpring(ref A, ref C);
        Softbody.AddSpring(ref B, ref D);
        Softbody.AddSpring(ref B, ref G);
        Softbody.AddSpring(ref F, ref C);
        Softbody.AddSpring(ref F, ref H);
        Softbody.AddSpring(ref E, ref G);
        Softbody.AddSpring(ref E, ref D);
        Softbody.AddSpring(ref A, ref H);

        // top outer
        Softbody.AddSpring(ref A, ref B);
        Softbody.AddSpring(ref B, ref F);
        Softbody.AddSpring(ref F, ref E);
        Softbody.AddSpring(ref E, ref A);

        // top inner
        Softbody.AddSpring(ref I, ref J);
        Softbody.AddSpring(ref J, ref N);
        Softbody.AddSpring(ref N, ref M);
        Softbody.AddSpring(ref M, ref I);

        // bottom outer
        Softbody.AddSpring(ref D, ref C);
        Softbody.AddSpring(ref C, ref G);
        Softbody.AddSpring(ref G, ref H);
        Softbody.AddSpring(ref H, ref D);

        // bottom inner
        Softbody.AddSpring(ref L, ref K);
        Softbody.AddSpring(ref K, ref O);
        Softbody.AddSpring(ref O, ref P);
        Softbody.AddSpring(ref P, ref L);
    }
}
