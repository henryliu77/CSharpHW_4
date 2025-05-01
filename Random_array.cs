namespace Random_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void bubbleSort(int[] data)
        {
            try
            {
                int len = data.Length;
                for (int i = 0; i < len - 1; i++)
                {
                    for (int j = 0; j < len - i - 1; j++)
                    {
                        if (data[j + 1] < data[j])
                        {
                            int temp = data[j + 1];
                            data[j + 1] = data[j];
                            data[j] = temp;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("排序發生錯誤: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();

                int[] num = new int[5];
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = random.Next(1,200);
                }

                int[] arrayToSort = num.ToArray();
                bubbleSort(arrayToSort);


                textBox1.Text = string.Join(" , ", arrayToSort);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("執行發生錯誤: " + ex.Message);
            }
        }
    }
}
