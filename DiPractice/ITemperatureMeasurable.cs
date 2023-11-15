using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiPractice
{
    /// <summary>
    /// ���x�𑪒肷��@�\��񋟂���C���^�[�t�F�C�X�ł��B
    /// ���̃C���^�[�t�F�C�X����������N���X�́A����̊��̉��x�𑪒肵�A
    /// ���̒l���_�u���Ƃ��ĕԂ��ӔC������܂��B
    /// </summary>
    public interface ITemperatureMeasurable
    {
        /// <summary>
        /// ���x�𑪒肵�A���̒l��Ԃ��܂��B
        /// ���肳��鉷�x�̒P�ʂ�͈͎͂����Ɉˑ����܂��B
        /// </summary>
        /// <returns>���肳�ꂽ���x�l�i�ێ��܂��͉؎��j</returns>
        double MeasureTemperature();
    }
}
