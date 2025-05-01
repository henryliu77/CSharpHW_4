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

                // ㊣ㄧ计璸衡程㎝程
                int minValue = arrMin(numbers);
                int maxValue = arrMax(numbers);

                // 陪ボ挡狦
                lblResult1.Text = $"程: {minValue}";
                lblResult2.Text = $"程: {maxValue}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("叫絋粄块琌Τ俱计\n" + ex.Message, "岿粇", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // arrMin ㄧ计
        private int arrMin(int[] arr)
        {
            return arr.Min();
        }

        // arrMax ㄧ计
        private int arrMax(int[] arr)
        {
            return arr.Max();
        }

    }
}
