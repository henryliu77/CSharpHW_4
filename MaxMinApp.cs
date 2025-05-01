using System;
using System.Linq;
using System.Windows.Forms;
namespace MinMaxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindMinMax_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = new int[6];
                numbers[0] = int.Parse(txtNumber1.Text);
                numbers[1] = int.Parse(txtNumber2.Text);
                numbers[2] = int.Parse(txtNumber3.Text);
                numbers[3] = int.Parse(txtNumber4.Text);
                numbers[4] = int.Parse(txtNumber5.Text);
                numbers[5] = int.Parse(txtNumber6.Text);

                // 呼叫函數計算最小值和最大值
                int minValue = arrMin(numbers);
                int maxValue = arrMax(numbers);

                // 顯示結果
                lblResult1.Text = $"最小值: {minValue}";
                lblResult2.Text = $"最大值: {maxValue}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("請確認輸入的值是有效的整數。\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // arrMin 函數
        private int arrMin(int[] arr)
        {
            return arr.Min();
        }

        // arrMax 函數
        private int arrMax(int[] arr)
        {
            return arr.Max();
        }

    }
}
