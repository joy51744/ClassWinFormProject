using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWinFormProject
{
    public partial class _10202_UnitConverter : Form
    {
        public _10202_UnitConverter()
        {
            InitializeComponent();
        }

        private void _10202_UnitConverter_Load(object sender, EventArgs e)
        {
            comboBoxLength1.SelectedIndex = 0;
            comboBoxLength2.SelectedIndex = 1;

            comboBoxWeight1.SelectedIndex = 0;
            comboBoxWeight2.SelectedIndex = 1;

            comboBoxVolume1.SelectedIndex = 0;
            comboBoxVolume2.SelectedIndex = 1;

            comboBoxArea1.SelectedIndex = 0;
            comboBoxArea2.SelectedIndex = 1;

            comboBoxStorage1.SelectedIndex = 0;
            comboBoxStorage2.SelectedIndex = 1;

            comboBoxCurrent1.SelectedIndex = 0;
            comboBoxCurrent2.SelectedIndex = 1;

            comboBoxTime1.SelectedIndex = 0;
            comboBoxTime2.SelectedIndex = 1;

            comboBoxTemperature1.SelectedIndex = 0;
            comboBoxTemperature2.SelectedIndex = 1;
        }

        private void buttonConversionLength_Click(object sender, EventArgs e)
        {
            string length1, length2;
            length1 = Convert.ToString(comboBoxLength1.SelectedItem);
            length2 = Convert.ToString(comboBoxLength2.SelectedItem);

            double len1, len2;

            if (textBoxLengthInput.Text == "")
            {
                textBoxLengthInput.Text = "1";
                len1 = 1;
            }
            else
            {
                len1 = Convert.ToDouble(textBoxLengthInput.Text);
            }

            if (length1 == length2)
            {
                len2 = len1;
                textBoxLengthOutput.Text = Convert.ToString(len2);
            }
            else
            {
                #region 公尺換算

                if (length1 == "公尺" && length2 == "公里")
                {
                    len2 = len1 / 1000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公尺" && length2 == "公分")
                {
                    len2 = len1 * 100;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公尺" && length2 == "毫米")
                {
                    len2 = len1 * 1000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公尺" && length2 == "微米")
                {
                    len2 = len1 * 1000000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公尺" && length2 == "奈米")
                {
                    len2 = len1 * 1000000000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公尺" && length2 == "英吋")
                {
                    len2 = len1 * 39.370079;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公尺" && length2 == "英呎")
                {
                    len2 = len1 * 3.28084;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                #endregion 公尺換算

                #region 公里換算

                if (length1 == "公里" && length2 == "公尺")
                {
                    len2 = len1 * 1000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公里" && length2 == "公分")
                {
                    len2 = len1 * 100000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公里" && length2 == "毫米")
                {
                    len2 = len1 * 1000000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公里" && length2 == "微米")
                {
                    len2 = len1 * 1000000000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公里" && length2 == "奈米")
                {
                    len2 = len1 * 999999999999.9999;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公里" && length2 == "英吋")
                {
                    len2 = len1 * 39370.07874;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公里" && length2 == "英呎")
                {
                    len2 = len1 * 3280.839895;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                #endregion 公里換算

                #region 公分換算

                if (length1 == "公分" && length2 == "公尺")
                {
                    len2 = len1 / 100;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公分" && length2 == "公里")
                {
                    len2 = len1 / 100000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公分" && length2 == "毫米")
                {
                    len2 = len1 * 10;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公分" && length2 == "微米")
                {
                    len2 = len1 * 10000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公分" && length2 == "奈米")
                {
                    len2 = len1 * 10000000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公分" && length2 == "英吋")
                {
                    len2 = len1 * 0.393701;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "公分" && length2 == "英呎")
                {
                    len2 = len1 * 0.032808;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                #endregion 公分換算

                #region 毫米換算

                if (length1 == "毫米" && length2 == "公尺")
                {
                    len2 = len1 / 1000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "毫米" && length2 == "公里")
                {
                    len2 = len1 / 1000000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "毫米" && length2 == "公分")
                {
                    len2 = len1 / 10;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "毫米" && length2 == "微米")
                {
                    len2 = len1 * 1000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "毫米" && length2 == "奈米")
                {
                    len2 = len1 * 1000000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "毫米" && length2 == "英吋")
                {
                    len2 = len1 * 0.03937;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "毫米" && length2 == "英呎")
                {
                    len2 = len1 * 0.003281;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                #endregion 毫米換算

                #region 微米換算

                if (length1 == "微米" && length2 == "公尺")
                {
                    len2 = len1 / 1000000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "微米" && length2 == "公里")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "微米" && length2 == "公分")
                {
                    len2 = len1 / 10000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "微米" && length2 == "毫米")
                {
                    len2 = len1 / 1000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "微米" && length2 == "奈米")
                {
                    len2 = len1 * 1000;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "微米" && length2 == "英吋")
                {
                    len2 = len1 * 0.000039;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "微米" && length2 == "英呎")
                {
                    len2 = len1 * 0.000003;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                #endregion 微米換算

                #region 奈米換算

                if (length1 == "奈米" && length2 == "公尺")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "奈米" && length2 == "公里")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "奈米" && length2 == "公分")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "奈米" && length2 == "毫米")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "奈米" && length2 == "微米")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "奈米" && length2 == "英吋")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "奈米" && length2 == "英呎")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                #endregion 奈米換算

                #region 英吋換算

                if (length1 == "英吋" && length2 == "公尺")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英吋" && length2 == "公里")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英吋" && length2 == "公分")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英吋" && length2 == "毫米")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英吋" && length2 == "微米")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英吋" && length2 == "奈米")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英吋" && length2 == "英呎")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                #endregion 英吋換算

                #region 英呎換算

                if (length1 == "英呎" && length2 == "公尺")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英呎" && length2 == "公里")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英呎" && length2 == "公分")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英呎" && length2 == "毫米")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英呎" && length2 == "微米")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英呎" && length2 == "奈米")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                if (length1 == "英呎" && length2 == "英吋")
                {
                    len2 = len1 * 0;
                    textBoxLengthOutput.Text = Convert.ToString(len2);
                }

                #endregion 英呎換算
            }
        }

        private void textBoxLengthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != 46)//允许输入退格键和小数点键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void ConversionWeight_Click(object sender, EventArgs e)
        {
            string weight1, weight2;
            weight1 = Convert.ToString(comboBoxWeight1.SelectedItem);
            weight2 = Convert.ToString(comboBoxWeight2.SelectedItem);

            double wei1, wei2;
            if (textBoxWeightInput.Text == "")
            {
                textBoxWeightInput.Text = "1";
                wei1 = 1;
            }
            else
            {
                wei1 = Convert.ToDouble(textBoxWeightInput.Text);
            }

            if (weight1 == weight2)
            {
                wei2 = wei1;
                textBoxWeightOutput.Text = Convert.ToString(wei2);
            }
            else
            {
                #region 公噸換算

                if (weight1 == "公噸" && weight2 == "公斤")
                {
                    wei2 = wei1 * 1000;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "公克")
                {
                    wei2 = wei1 * 1000000;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "斤")
                {
                    wei2 = wei1 * 2000;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "台斤")
                {
                    wei2 = wei1 * 1666.6667;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "英噸")
                {
                    wei2 = wei1 * 0.98421;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "英磅")
                {
                    wei2 = wei1 * 2204.6341;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "盎司")
                {
                    wei2 = wei1 * 35273.991;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                #endregion 公噸換算

                #region 公斤換算

                if (weight1 == "公斤" && weight2 == "公噸")
                {
                    wei2 = wei1 / 1000;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "公克")
                {
                    wei2 = wei1 * 1000;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "斤")
                {
                    wei2 = wei1 * 2;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "台斤")
                {
                    wei2 = wei1 * 1.66667;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "英噸")
                {
                    wei2 = wei1 * 0.00098;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "英磅")
                {
                    wei2 = wei1 * 2.20462;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公噸" && weight2 == "盎司")
                {
                    wei2 = wei1 * 35.27396;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                #endregion 公斤換算

                #region 公克換算

                if (weight1 == "公克" && weight2 == "公噸")
                {
                    wei2 = wei1 * 0;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公克" && weight2 == "公斤")
                {
                    wei2 = wei1 / 1000;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公克" && weight2 == "斤")
                {
                    wei2 = wei1 * 0.002;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公克" && weight2 == "台斤")
                {
                    wei2 = wei1 * 0.00167;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公克" && weight2 == "英噸")
                {
                    wei2 = wei1 * 0;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公克" && weight2 == "英磅")
                {
                    wei2 = wei1 * 0.0022;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "公克" && weight2 == "盎司")
                {
                    wei2 = wei1 * 0.03527;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                #endregion 公克換算

                #region 斤換算

                if (weight1 == "斤" && weight2 == "公噸")
                {
                    wei2 = wei1 * 0.0005;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "斤" && weight2 == "公斤")
                {
                    wei2 = wei1 * 0.5;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "斤" && weight2 == "公克")
                {
                    wei2 = wei1 * 500;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "斤" && weight2 == "台斤")
                {
                    wei2 = wei1 * 0.83333;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "斤" && weight2 == "英噸")
                {
                    wei2 = wei1 * 0.00049;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "斤" && weight2 == "英磅")
                {
                    wei2 = wei1 * 1.10232;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "斤" && weight2 == "盎司")
                {
                    wei2 = wei1 * 17.63699;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                #endregion 斤換算

                #region 台斤換算

                if (weight1 == "台斤" && weight2 == "公噸")
                {
                    wei2 = wei1 * 0.0006;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "台斤" && weight2 == "公斤")
                {
                    wei2 = wei1 * 0.6;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "台斤" && weight2 == "公克")
                {
                    wei2 = wei1 * 600;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "台斤" && weight2 == "斤")
                {
                    wei2 = wei1 * 1.2;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "台斤" && weight2 == "英噸")
                {
                    wei2 = wei1 * 0.00059;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "台斤" && weight2 == "英磅")
                {
                    wei2 = wei1 * 1.32278;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "台斤" && weight2 == "盎司")
                {
                    wei2 = wei1 * 21.16439;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                #endregion 台斤換算

                #region 英噸換算

                if (weight1 == "英噸" && weight2 == "公噸")
                {
                    wei2 = wei1 * 1.01605;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英噸" && weight2 == "公斤")
                {
                    wei2 = wei1 * 1016.0469;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英噸" && weight2 == "公克")
                {
                    wei2 = wei1 * 1016046.9;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英噸" && weight2 == "斤")
                {
                    wei2 = wei1 * 2032.0938;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英噸" && weight2 == "台斤")
                {
                    wei2 = wei1 * 1693.4115;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英噸" && weight2 == "英磅")
                {
                    wei2 = wei1 * 2240.0117;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英噸" && weight2 == "盎司")
                {
                    wei2 = wei1 * 35840.029;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                #endregion 英噸換算

                #region 英磅換算

                if (weight1 == "英磅" && weight2 == "公噸")
                {
                    wei2 = wei1 * 0.00045;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英磅" && weight2 == "公斤")
                {
                    wei2 = wei1 * 0.45359;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英磅" && weight2 == "公克")
                {
                    wei2 = wei1 * 453.59;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英磅" && weight2 == "斤")
                {
                    wei2 = wei1 * 0.90718;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英磅" && weight2 == "台斤")
                {
                    wei2 = wei1 * 0.75598;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英磅" && weight2 == "英噸")
                {
                    wei2 = wei1 * 0.00045;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "英磅" && weight2 == "盎司")
                {
                    wei2 = wei1 * 15.99993;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                #endregion 英磅換算

                #region 盎司換算

                if (weight1 == "盎司" && weight2 == "公噸")
                {
                    wei2 = wei1 * 0.00003;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "盎司" && weight2 == "公斤")
                {
                    wei2 = wei1 * 0.02835;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "盎司" && weight2 == "公克")
                {
                    wei2 = wei1 * 28.3495;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "盎司" && weight2 == "斤")
                {
                    wei2 = wei1 * 0.0567;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "盎司" && weight2 == "台斤")
                {
                    wei2 = wei1 * 0.04725;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "盎司" && weight2 == "英噸")
                {
                    wei2 = wei1 * 0.00003;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                if (weight1 == "盎司" && weight2 == "英磅")
                {
                    wei2 = wei1 * 0.0625;
                    textBoxWeightOutput.Text = Convert.ToString(wei2);
                }

                #endregion 盎司換算
            }
        }

        private void textBoxWeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != 46)//允许输入退格键和小数点键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonConversionVolume_Click(object sender, EventArgs e)
        {
            //升,分升,厘升,立方公分,毫升,立方公厘,微升,立方公尺,公石,十升,立方分米

            string volume1, volume2;
            volume1 = Convert.ToString(comboBoxVolume1.SelectedItem);
            volume2 = Convert.ToString(comboBoxVolume2.SelectedItem);

            double vol1, vol2;
            if (textBoxVolumeInput.Text == "")
            {
                textBoxVolumeInput.Text = "1";
                vol1 = 1;
            }
            else
            {
                vol1 = Convert.ToDouble(textBoxVolumeInput.Text);
            }

            if (volume1 == volume2)
            {
                vol2 = vol1;
                textBoxVolumeOutput.Text = Convert.ToString(vol2);
            }
            else
            {
                #region 升換算

                if (volume1 == "升" && volume2 == "分升")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "厘升")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "立方公分")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "毫升")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "微升")
                {
                    vol2 = vol1 * 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "公石")
                {
                    vol2 = vol1 / 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "十升")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "立方分米")
                {
                    vol2 = vol1 * 1;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 升換算

                #region 分升換算

                if (volume1 == "分升" && volume2 == "升")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "厘升")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "立方公分")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "毫升")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "微升")
                {
                    vol2 = vol1 * 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "公石")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "十升")
                {
                    vol2 = vol1 / 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "立方分米")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 分升換算

                #region 厘升換算

                if (volume1 == "厘升" && volume2 == "升")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "厘升" && volume2 == "分升")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "立方公分")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "毫升")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "微升")
                {
                    vol2 = vol1 * 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "公石")
                {
                    vol2 = vol1 / 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "十升")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "立方分米")
                {
                    vol2 = vol1 / 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 厘升換算

                #region 立方公分換算

                if (volume1 == "立方公分" && volume2 == "升")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公分" && volume2 == "分升")
                {
                    vol2 = vol1 / 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公分" && volume2 == "厘升")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "毫升")
                {
                    vol2 = vol1 * 1;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "升" && volume2 == "微升")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "公石")
                {
                    vol2 = vol1 / 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "十升")
                {
                    vol2 = vol1 / 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "分升" && volume2 == "立方分米")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 立方公分換算

                #region 毫升換算

                if (volume1 == "毫升" && volume2 == "升")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "分升")
                {
                    vol2 = vol1 / 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "厘升")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "立方公分")
                {
                    vol2 = vol1 * 1;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "微升")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "公石")
                {
                    vol2 = vol1 / 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "十升")
                {
                    vol2 = vol1 / 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "毫升" && volume2 == "立方分米")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 毫升換算

                #region 立方公厘換算

                if (volume1 == "立方公厘" && volume2 == "升")
                {
                    vol2 = vol1 / 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "分升")
                {
                    vol2 = vol1 / 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "厘升")
                {
                    vol2 = vol1 / 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "毫升")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 1;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "微升")
                {
                    vol2 = vol1 * 1;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 1000000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "公石")
                {
                    vol2 = vol1 / 100000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "十升")
                {
                    vol2 = vol1 / 10000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公厘" && volume2 == "立方分米")
                {
                    vol2 = vol1 / 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 立方公厘換算

                #region 微升換算

                if (volume1 == "微升" && volume2 == "升")
                {
                    vol2 = vol1 / 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "分升")
                {
                    vol2 = vol1 / 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "厘升")
                {
                    vol2 = vol1 / 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "立方公分")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "毫升")
                {
                    vol2 = vol1 / 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 1;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 1000000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "公石")
                {
                    vol2 = vol1 / 100000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "十升")
                {
                    vol2 = vol1 / 10000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "立方分米")
                {
                    vol2 = vol1 / 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 微升換算

                #region 立方公尺換算

                if (volume1 == "立方公尺" && volume2 == "升")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公尺" && volume2 == "分升")
                {
                    vol2 = vol1 * 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公尺" && volume2 == "厘升")
                {
                    vol2 = vol1 * 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公尺" && volume2 == "立方公分")
                {
                    vol2 = vol1 * 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公尺" && volume2 == "毫升")
                {
                    vol2 = vol1 * 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公尺" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 1000000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公尺" && volume2 == "微升")
                {
                    vol2 = vol1 * 1000000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公尺" && volume2 == "公石")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方公尺" && volume2 == "十升")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "微升" && volume2 == "立方分米")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 立方公尺換算

                #region 公石換算

                if (volume1 == "公石" && volume2 == "升")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "分升")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "厘升")
                {
                    vol2 = vol1 * 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "立方公分")
                {
                    vol2 = vol1 * 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "毫升")
                {
                    vol2 = vol1 * 100000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 100000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "微升")
                {
                    vol2 = vol1 * 100000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "十升")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "公石" && volume2 == "立方分米")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 公石換算

                #region 十升換算

                if (volume1 == "十升" && volume2 == "升")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "分升")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "厘升")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "立方公分")
                {
                    vol2 = vol1 * 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "毫升")
                {
                    vol2 = vol1 * 10000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 10000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "微升")
                {
                    vol2 = vol1 * 10000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "公石")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "十升" && volume2 == "立方分米")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 十升換算

                #region 立方分米換算

                if (volume1 == "立方分米" && volume2 == "升")
                {
                    vol2 = vol1 * 1;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "分升")
                {
                    vol2 = vol1 * 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "厘升")
                {
                    vol2 = vol1 * 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "立方公分")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "毫升")
                {
                    vol2 = vol1 * 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "立方公厘")
                {
                    vol2 = vol1 * 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "微升")
                {
                    vol2 = vol1 * 1000000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "立方公尺")
                {
                    vol2 = vol1 / 1000;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "公石")
                {
                    vol2 = vol1 / 100;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                if (volume1 == "立方分米" && volume2 == "十升")
                {
                    vol2 = vol1 / 10;
                    textBoxVolumeOutput.Text = Convert.ToString(vol2);
                }

                #endregion 立方分米換算
            }
        }

        private void textBoxVolumeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != 46)//允许输入退格键和小数点键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonConversionArea_Click(object sender, EventArgs e)
        {
            //公頃,平方米,平方分米,平方厘米,平方毫米

            string area1, area2;
            area1 = Convert.ToString(comboBoxArea1.SelectedItem);
            area2 = Convert.ToString(comboBoxArea2.SelectedItem);

            double a1, a2;
            if (textBoxAreaInput.Text == "")
            {
                textBoxAreaInput.Text = "1";
                a1 = 1;
            }
            else
            {
                a1 = Convert.ToDouble(textBoxAreaInput.Text);
            }

            if (area1 == area2)
            {
                a2 = a1;
                textBoxAreaOutput.Text = Convert.ToString(a2);
            }
            else
            {
                #region 公頃

                if (area1 == "公頃" && area2 == "平方米")
                {
                    a2 = a1 * 10000;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "公頃" && area2 == "平方分米")
                {
                    a2 = a1 * 1000000;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "公頃" && area2 == "平方厘米")
                {
                    a2 = a1 * 100000000;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "公頃" && area2 == "平方毫米")
                {
                    a2 = a1 * 10000000000;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                #endregion 公頃

                #region 平方米

                if (area1 == "平方米" && area2 == "公頃")
                {
                    a2 = a1 * 0.0001;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方米" && area2 == "平方分米")
                {
                    a2 = a1 * 100;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方米" && area2 == "平方厘米")
                {
                    a2 = a1 * 10000;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方米" && area2 == "平方毫米")
                {
                    a2 = a1 * 1000000;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                #endregion 平方米

                #region 平方分米

                if (area1 == "平方分米" && area2 == "公頃")
                {
                    a2 = a1 * 0.000001;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方分米" && area2 == "平方米")
                {
                    a2 = a1 * 0.01;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方分米" && area2 == "平方厘米")
                {
                    a2 = a1 * 100;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方分米" && area2 == "平方毫米")
                {
                    a2 = a1 * 10000;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                #endregion 平方分米

                #region 平方厘米

                if (area1 == "平方厘米" && area2 == "公頃")
                {
                    a2 = a1 * 0.00000001;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方厘米" && area2 == "平方米")
                {
                    a2 = a1 * 0.0001;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方厘米" && area2 == "平方分米")
                {
                    a2 = a1 * 0.01;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方厘米" && area2 == "平方毫米")
                {
                    a2 = a1 * 100;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                #endregion 平方厘米

                #region 平方毫米

                if (area1 == "平方毫米" && area2 == "公頃")
                {
                    a2 = a1 * 0.0000000001;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方毫米" && area2 == "平方米")
                {
                    a2 = a1 * 0.000001;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方毫米" && area2 == "平方分米")
                {
                    a2 = a1 * 0.0001;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                if (area1 == "平方毫米" && area2 == "平方厘米")
                {
                    a2 = a1 * 0.01;
                    textBoxAreaOutput.Text = Convert.ToString(a2);
                }

                #endregion 平方毫米
            }
        }

        private void textBoxAreaInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != 46)//允许输入退格键和小数点键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonConversionStorage_Click(object sender, EventArgs e)
        {
            //bit,byte,KB,MB,GB,TB,PB

            string storage1, storage2;
            storage1 = Convert.ToString(comboBoxStorage1.SelectedItem);
            storage2 = Convert.ToString(comboBoxStorage2.SelectedItem);

            double s1, s2;
            if (textBoxStorageInput.Text == "")
            {
                textBoxStorageInput.Text = "1";
                s1 = 1;
            }
            else
            {
                s1 = Convert.ToDouble(textBoxStorageInput.Text);
            }

            if (storage1 == storage2)
            {
                s2 = s1;
                textBoxStorageOutput.Text = Convert.ToString(s2);
            }
            else
            {
                #region bit

                if (storage1 == "bit" && storage2 == "byte")
                {
                    s2 = s1 * 0.125;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "bit" && storage2 == "KB")
                {
                    s2 = s1 * 0.000122;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "bit" && storage2 == "MB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "bit" && storage2 == "GB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "bit" && storage2 == "TB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "bit" && storage2 == "PB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                #endregion bit

                #region byte

                if (storage1 == "byte" && storage2 == "bit")
                {
                    s2 = s1 * 8;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "byte" && storage2 == "KB")
                {
                    s2 = s1 * 0.000977;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "byte" && storage2 == "MB")
                {
                    s2 = s1 * 0.000001;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "byte" && storage2 == "GB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "byte" && storage2 == "TB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "byte" && storage2 == "PB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                #endregion byte

                #region KB

                if (storage1 == "KB" && storage2 == "bit")
                {
                    s2 = s1 * 8192;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "KB" && storage2 == "byte")
                {
                    s2 = s1 * 1024;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "KB" && storage2 == "MB")
                {
                    s2 = s1 * 0.000977;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "KB" && storage2 == "GB")
                {
                    s2 = s1 * 0.000001;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "KB" && storage2 == "TB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "KB" && storage2 == "PB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                #endregion KB

                #region MB

                if (storage1 == "MB" && storage2 == "bit")
                {
                    s2 = s1 * 8388608;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "MB" && storage2 == "byte")
                {
                    s2 = s1 * 1048576;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "MB" && storage2 == "KB")
                {
                    s2 = s1 * 1024;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "MB" && storage2 == "GB")
                {
                    s2 = s1 * 0.000977;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "MB" && storage2 == "TB")
                {
                    s2 = s1 * 0.000001;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "MB" && storage2 == "PB")
                {
                    s2 = s1 * 0;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                #endregion MB

                #region GB

                if (storage1 == "GB" && storage2 == "bit")
                {
                    s2 = s1 * 8589934592;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "GB" && storage2 == "byte")
                {
                    s2 = s1 * 1073741824;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "GB" && storage2 == "KB")
                {
                    s2 = s1 * 1048576;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "GB" && storage2 == "MB")
                {
                    s2 = s1 * 1024;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "GB" && storage2 == "TB")
                {
                    s2 = s1 * 0.000977;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "GB" && storage2 == "PB")
                {
                    s2 = s1 * 0.000001;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                #endregion GB

                #region TB

                if (storage1 == "TB" && storage2 == "bit")
                {
                    s2 = s1 * 8796093022208;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "TB" && storage2 == "byte")
                {
                    s2 = s1 * 1099511627776;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "TB" && storage2 == "KB")
                {
                    s2 = s1 * 1073741824;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "TB" && storage2 == "MB")
                {
                    s2 = s1 * 1048576;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "TB" && storage2 == "GB")
                {
                    s2 = s1 * 1024;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "TB" && storage2 == "PB")
                {
                    s2 = s1 * 0.000977;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                #endregion TB

                #region PB

                if (storage1 == "PB" && storage2 == "bit")
                {
                    s2 = s1 * 9007199254740992;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "PB" && storage2 == "byte")
                {
                    s2 = s1 * 1125899906842624;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "PB" && storage2 == "KB")
                {
                    s2 = s1 * 1099511627776;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "PB" && storage2 == "MB")
                {
                    s2 = s1 * 1073741824;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "PB" && storage2 == "GB")
                {
                    s2 = s1 * 1048576;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                if (storage1 == "PB" && storage2 == "TB")
                {
                    s2 = s1 * 1024;
                    textBoxStorageOutput.Text = Convert.ToString(s2);
                }

                #endregion PB
            }
        }

        private void textBoxStorageInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != 46)//允许输入退格键和小数点键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonConversionCurrent_Click(object sender, EventArgs e)
        {
            string current1, current2;
            current1 = Convert.ToString(comboBoxCurrent1.SelectedItem);
            current2 = Convert.ToString(comboBoxCurrent2.SelectedItem);

            double c1, c2;
            if (textBoxCurrentInput.Text == "")
            {
                c1 = 1;
            }
            else
            {
                c1 = Convert.ToDouble(textBoxCurrentInput.Text);
            }

            if (current1 == current2)
            {
                c2 = c1;
                textBoxCurrentInput.Text = Convert.ToString(c2);
            }
            else
            {
                #region 安培

                if (current1 == "安培" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "兆安培")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "千安培")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "毫安培")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "微安")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "奈安")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "皮安")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "電磁安培")
                {
                    c2 = c1 * 0.1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "安培" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 安培

                #region 兆安

                if (current1 == "兆安" && current2 == "安培")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "千兆安培")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "兆安培")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "千安培")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "毫安培")
                {
                    c2 = c1 * 1000000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "微安")
                {
                    c2 = c1 * 1000000000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "奈安")
                {
                    c2 = c1 * 1e+21;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "皮安")
                {
                    c2 = c1 * 1e+24;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "電磁安培")
                {
                    c2 = c1 * 100000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 兆安

                #region 千兆安培

                if (current1 == "千兆安培" && current2 == "安培")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "兆安")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "兆安培")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "千安培")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "毫安培")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "微安")
                {
                    c2 = c1 * 1000000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "奈安")
                {
                    c2 = c1 * 1000000000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "皮安")
                {
                    c2 = c1 * 1e+21;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "電磁安培")
                {
                    c2 = c1 * 100000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千兆安培" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 千兆安培

                #region 兆安培

                if (current1 == "兆安培" && current2 == "安培")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "兆安")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "千兆安培")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "千安培")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "毫安培")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "微安")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "奈安")
                {
                    c2 = c1 * 1000000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "皮安")
                {
                    c2 = c1 * 1000000000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "電磁安培")
                {
                    c2 = c1 * 100000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "兆安培" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 兆安培

                #region 千安培

                if (current1 == "千安培" && current2 == "安培")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "千兆安培")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "兆安培")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "毫安培")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "微安")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "奈安")
                {
                    c2 = c1 * 999999999999.9999;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "皮安")
                {
                    c2 = c1 * 1000000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "電磁安培")
                {
                    c2 = c1 * 100;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "千安培" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 千安培

                #region 毫安培

                if (current1 == "毫安培" && current2 == "安培")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "千安培")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "微安")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "奈安")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "皮安")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "電磁安培")
                {
                    c2 = c1 * 0.0001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "毫安培" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 毫安培

                #region 微安

                if (current1 == "微安" && current2 == "安培")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "千安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "毫安培")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "奈安")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "皮安")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "電磁安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "微安" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 微安

                #region 奈安

                if (current1 == "奈安" && current2 == "安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "千安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "毫安培")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "微安")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "皮安")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "電磁安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "奈安" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 奈安

                #region 皮安

                if (current1 == "皮安" && current2 == "安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "千安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "毫安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "微安")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "奈安")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "電磁安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "皮安" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 皮安

                #region 電磁安培

                if (current1 == "電磁安培" && current2 == "安培")
                {
                    c2 = c1 * 10;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "兆安培")
                {
                    c2 = c1 * 0.00001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "千安培")
                {
                    c2 = c1 * 0.01;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "毫安培")
                {
                    c2 = c1 * 10000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "微安")
                {
                    c2 = c1 * 10000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "奈安")
                {
                    c2 = c1 * 10000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "皮安")
                {
                    c2 = c1 * 10000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 10;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 10;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "電磁安培" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 10;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 電磁安培

                #region 伏特/歐姆

                if (current1 == "伏特/歐姆" && current2 == "安培")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "兆安培")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "千安培")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "毫安培")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "微安")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "奈安")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "皮安")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "電磁安培")
                {
                    c2 = c1 * 0.1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == "瓦特/伏特")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "伏特/歐姆" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 伏特/歐姆

                #region 瓦特/伏特

                if (current1 == "瓦特/伏特" && current2 == "安培")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "兆安培")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "千安培")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "毫安培")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "微安")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "奈安")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "皮安")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "電磁安培")
                {
                    c2 = c1 * 0.1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "瓦特/伏特" && current2 == " 庫侖/秒")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 瓦特/伏特

                #region 庫侖/秒

                if (current1 == "庫侖/秒" && current2 == "安培")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "兆安")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "千兆安培")
                {
                    c2 = c1 * 0;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "兆安培")
                {
                    c2 = c1 * 0.000001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "千安培")
                {
                    c2 = c1 * 0.001;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "毫安培")
                {
                    c2 = c1 * 1000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "微安")
                {
                    c2 = c1 * 1000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "奈安")
                {
                    c2 = c1 * 1000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "皮安")
                {
                    c2 = c1 * 1000000000000;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "電磁安培")
                {
                    c2 = c1 * 0.1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == "伏特/歐姆")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                if (current1 == "庫侖/秒" && current2 == " 瓦特/伏特")
                {
                    c2 = c1 * 1;
                    textBoxCurrentOutput.Text = Convert.ToString(c2);
                }

                #endregion 庫侖/秒
            }
        }

        private void textBoxCurrentInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != 46)//允许输入退格键和小数点键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonConversionTime_Click(object sender, EventArgs e)
        {            //年,月,周,天,小時,分鐘,秒,毫秒
            string time1, time2;
            time1 = Convert.ToString(comboBoxTime1.SelectedItem);
            time2 = Convert.ToString(comboBoxTime2.SelectedItem);

            double t1, t2;
            if (textBoxTimeInput.Text == "")
            {
                textBoxTimeInput.Text = "1";
                t1 = 1;
            }
            else
            {
                t1 = Convert.ToDouble(textBoxTimeInput.Text);
            }

            if (time1 == time2)
            {
                t2 = t1;
                textBoxTimeOutput.Text = Convert.ToString(t2);
            }
            else
            {
                #region 年換算

                if (time1 == "年" && time2 == "月")
                {
                    t2 = t1 * 12;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "年" && time2 == "周")
                {
                    t2 = t1 * 52;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "年" && time2 == "天")
                {
                    t2 = t1 * 365;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "年" && time2 == "小時")
                {
                    t2 = t1 * 8766;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "年" && time2 == "分鐘")
                {
                    t2 = t1 * 525960;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "年" && time2 == "秒")
                {
                    t2 = t1 * 31557600;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "年" && time2 == "毫秒")
                {
                    t2 = t1 * 31557600000;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                #endregion 年換算

                #region 月換算

                if (time1 == "月" && time2 == "年")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法計算";
                }

                if (time1 == "月" && time2 == "周")
                {
                    t2 = t1 * 4.35;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "月" && time2 == "天")
                {
                    t2 = t1 * 30.44;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "月" && time2 == "小時")
                {
                    t2 = t1 * 730.5;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "月" && time2 == "分鐘")
                {
                    t2 = t1 * 43830;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }
                if (time1 == "月" && time2 == "秒")
                {
                    t2 = t1 * 2629800;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "月" && time2 == "毫秒")
                {
                    t2 = t1 * 2629800000;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                #endregion 月換算

                #region 周換算

                if (time1 == "周" && time2 == "年")
                {
                    t2 = t1 * 0.02;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "周" && time2 == "月")
                {
                    t2 = t1 * 0.23;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "周" && time2 == "天")
                {
                    t2 = t1 * 7;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "周" && time2 == "小時")
                {
                    t2 = t1 * 168;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "周" && time2 == "分鐘")
                {
                    t2 = t1 * 10080;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "周" && time2 == "秒")
                {
                    t2 = t1 * 604800.02;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "周" && time2 == "毫秒")
                {
                    t2 = t1 * 604800016.56;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                #endregion 周換算

                #region 天換算

                if (time1 == "天" && time2 == "年")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "天" && time2 == "月")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "天" && time2 == "周")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "天" && time2 == "小時")
                {
                    t2 = t1 * 24;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "天" && time2 == "分鐘")
                {
                    t2 = t1 * 1440;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "天" && time2 == "秒")
                {
                    t2 = t1 * 86400;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "天" && time2 == "毫秒")
                {
                    t2 = t1 * 86400000;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                #endregion 天換算

                #region 小時換算

                if (time1 == "小時" && time2 == "年")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "小時" && time2 == "月")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "小時" && time2 == "周")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "小時" && time2 == "天")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "小時" && time2 == "分鐘")
                {
                    t2 = t1 * 60;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }
                if (time1 == "小時" && time2 == "秒")
                {
                    t2 = t1 * 3600;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "小時" && time2 == "毫秒")
                {
                    t2 = t1 * 3600000;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                #endregion 小時換算

                #region 分鐘換算

                if (time1 == "分鐘" && time2 == "年")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "分鐘" && time2 == "月")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "分鐘" && time2 == "周")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "分鐘" && time2 == "天")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "分鐘" && time2 == "小時")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "分鐘" && time2 == "秒")
                {
                    t2 = t1 * 60;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                if (time1 == "分鐘" && time2 == "毫秒")
                {
                    t2 = t1 * 60000;
                    textBoxTimeOutput.Text = Convert.ToString(t2);
                }

                #endregion 分鐘換算

                #region 秒換算

                if (time1 == "秒" && time2 == "年")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "秒" && time2 == "月")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "秒" && time2 == "周")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "秒" && time2 == "天")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "秒" && time2 == "小時")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }

                if (time1 == "秒" && time2 == "分鐘")
                {
                    textBoxTimeInput.ReadOnly = true;
                    textBoxTimeOutput.Text = "無法精確計算";
                }
                if (time1 == "秒" && time2 == "毫秒")
                {
                    t2 = t1 * 1000;
                }

                #endregion 秒換算
            }
        }

        private void textBoxTimeInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != 46)//允许输入退格键和小数点键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonConversionTemperature_Click(object sender, EventArgs e)
        {
            string temperature1, temperature2;
            temperature1 = Convert.ToString(comboBoxTemperature1.SelectedItem);
            temperature2 = Convert.ToString(comboBoxTemperature2.SelectedItem);

            double tem1, tem2;
            if (textBoxTemperatureInput.Text == "")
            {
                textBoxTemperatureInput.Text = "1";
                tem1 = 1;
            }
            else
            {
                tem1 = Convert.ToDouble(textBoxTemperatureInput.Text);
            }

            if (temperature1 == temperature2)
            {
                tem2 = tem1;
                textBoxTemperatureOutput.Text = Convert.ToString(tem2);
            }
            else
            {
                #region 攝氏

                if (temperature1 == "攝氏" && temperature2 == "華氏")
                {
                    tem2 = tem1 * 1.8 + 32;
                    textBoxTemperatureOutput.Text = Convert.ToString(tem2);
                }

                if (temperature1 == "攝氏" && temperature2 == "凱氏")
                {
                    tem2 = tem1 + 273.15;
                    textBoxTemperatureOutput.Text = Convert.ToString(tem2);
                }

                if (temperature1 == "攝氏" && temperature2 == "蘭金")
                {
                    tem2 = (tem1 + 273.15) * 1.8;
                    textBoxTemperatureOutput.Text = Convert.ToString(tem2);
                }

                if (temperature1 == "攝氏" && temperature2 == "德利爾")
                {
                    tem2 = (100 - tem1) * 1.5;
                    textBoxTemperatureOutput.Text = Convert.ToString(tem2);
                }

                if (temperature1 == "攝氏" && temperature2 == "牛頓")
                {
                    tem2 = tem1 * 0.33;
                    textBoxTemperatureOutput.Text = Convert.ToString(tem2);
                }

                if (temperature1 == "攝氏" && temperature2 == "列氏")
                {
                    tem2 = tem1 * 0.8;
                    textBoxTemperatureOutput.Text = Convert.ToString(tem2);
                }

                if (temperature1 == "攝氏" && temperature2 == "羅氏")
                {
                    tem2 = tem1 * 0.525 + 7.5;
                    textBoxTemperatureOutput.Text = Convert.ToString(tem2);
                }

                #endregion 攝氏
            }
        }

        private void textBoxTemperatureInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != 46)//允许输入退格键和小数点键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
    }
}