using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiPractice
{
    /// <summary>
    /// �d���𑪒肷��@�\��񋟂���C���^�[�t�F�C�X�ł��B
    /// ���̃C���^�[�t�F�C�X����������N���X�́A����̓d�����̓d���𑪒肵�A
    /// ���̒l���_�u���Ƃ��ĕԂ��ӔC������܂��B
    /// </summary>
    public interface ICurrentMeasurable
    {
        /// <summary>
        /// �d���𑪒肵�A���̒l��Ԃ��܂��B
        /// ���肳���d���̒P�ʂ�͈͎͂����Ɉˑ����܂��B
        /// </summary>
        /// <returns>���肳�ꂽ�d���l�i�A���y�A�P�ʁj</returns>
        double MeasureCurrent();
    }
}
