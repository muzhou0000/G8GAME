using UnityEngine;  // 引用 Unity API

// 類別 類別名稱
public class Chicken : MonoBehaviour
{
    #region 欄位區域
    // 宣告變數 (定義欄位 Field)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // 私人 - 隱藏 private (預設)
    // 公開 - 顯示 public 
    [Header("移動速度")]
    [Range(1, 2000)]
    public int speed = 10;             // 整數 1, 9999, -100
    [Header("旋轉速度"), Tooltip("G8雞的旋轉速度"), Range(1.5f, 200f)]
    public float turn = 20.5f;         // 浮點數
    [Header("是否完成任務")]
    public bool mission;               // 布林值 true false
    [Header("玩家名稱")]
    public string _name = "G8雞";      // 字串 ""
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;
    public AudioClip auc;
    public AudioSource AS;
    public Rigidbody rigcatch;
    private void Update()
    {
        Turn();
        Run();
        Bark();
        Catch();

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "雞腿" && ani.GetCurrentAnimatorStateInfo(0).IsName("Eat"))
        {
            Physics.IgnoreCollision(other,GetComponent<Collider>());
            other.GetComponent<HingeJoint>().connectedBody = rigcatch;
        }
        if (other.name == "區域" && ani.GetCurrentAnimatorStateInfo(0).IsName("Eat"))
        {
            GameObject.Find("雞腿").GetComponent<HingeJoint>().connectedBody = null;
        }
    }

    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("Eat")) return;
        float v = Input.GetAxis("Vertical");        // W 上 1、S 下 -1、沒按 0
        // rig.AddForce(0, 0, speed * v);           // 世界座標
        // tran.right   區域座標 X 軸
        // tran.up      區域座標 Y 軸
        // tran.forward 區域座標 Z 軸
        // Time.deltaTime 當下裝置一幀的時間
        rig.AddForce(tran.forward * speed * v * Time.deltaTime);     // 區域座標

        ani.SetBool("走路", v != 0);
    }

    /// <summary>
    /// 旋轉
    /// </summary>
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal");    // A 左 -1、D 右 1、沒按 0
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }

    /// <summary>
    /// 亂叫
    /// </summary>
    private void Bark()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 按下空白鍵拍翅膀
            ani.SetTrigger("翅膀");
            AS.PlayOneShot(auc);
        }
    }

    /// <summary>
    /// 撿東西
    /// </summary>
    private void Catch()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // 按下左鍵撿東西
            ani.SetTrigger("吃");
        }
    }

    /// <summary>
    /// 檢視任務
    /// </summary>
    private void Task()
    {

    }
    #endregion
}