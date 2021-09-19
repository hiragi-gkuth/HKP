using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    #region Define
    /// <summary>
    /// �L�����N�^�̏�Ԃ�\��
    /// </summary>
    public struct CharacterStatus
    {
        public enum Flag : uint
        {
            Invalid = 0u,
            Idle = 1u << 0,
            Walk = 1u << 1,
            Run  = 1u << 2,
            Dash = 1u << 3,
            Jump = 1u << 4,
            Dead = 1u << 31,
        }
        /// <summary>
        /// �����Ă邩�ǂ�������
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool isPop(Flag f) 
            => 0 != (_Status & f);

        /// <summary>
        /// �r�b�g�𗧂Ă�
        /// </summary>
        /// <param name="f"></param>
        public void on(Flag f)
            => _Status |= f;

        /// <summary>
        /// �r�b�g��������
        /// </summary>
        /// <param name="f"></param>
        public void off(Flag f)
            => _Status &= ~f;

        /// <summary>
        /// ������
        /// </summary>
        public void clear()
            => _Status ^= _Status;

        public Flag Status
        {
            get => _Status;
            set => _Status = value;
        }
        private Flag _Status;

        /// <summary>
        /// �f�o�b�O�\���p
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var flags = (Flag[])System.Enum.GetValues(typeof(Flag));
            var sb = new System.Text.StringBuilder();

            foreach (var f in flags)
                if (isPop(f)) sb.Append(f.ToString() + ", "); 

            return sb.ToString();
        }
    }
    #endregion

    #region Property
    public CharacterStatus Status => _Stat;

    public int Health
    {
        get => _Health;
        private set
        {
            if (0 == (_Health = value))
                _Stat.on(CharacterStatus.Flag.Dead);
            else
                _Stat.off(CharacterStatus.Flag.Dead);
        }
    }

    #endregion

    #region Field
    private CharacterStatus _Stat;
    private int _Health = 5;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        _Stat.on(CharacterStatus.Flag.Idle);
        _Stat.on(CharacterStatus.Flag.Dead);
        _Stat.on(CharacterStatus.Flag.Run);
        Debug.Log(_Stat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
