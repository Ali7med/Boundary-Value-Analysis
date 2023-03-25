 namespace Boundary_Value_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        List<int> Years = new List<int>();
        List<int> Months = new List<int>();
        List<int> Days = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Days.Add(1);
            Days.Add(2);
            Days.Add(15);
            Days.Add(30);
            Days.Add(31);

            Months.Add(1);
            Months.Add(2);
            Months.Add(6);
            Months.Add(11);
            Months.Add(12);

            Years = new List<int>() { };

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {

            // generate the Year List
            Years = new List<int>() { };
            Years.Add((int)TxtDate1.Value);
            Years.Add((int)TxtDate1.Value + 1);
            Years.Add((((int)TxtDate2.Value - (int)TxtDate1.Value) / 2) + (int)TxtDate1.Value);

            Years.Add((int)TxtDate2.Value - 1);
            Years.Add((int)TxtDate2.Value);

            // get Random Chose of lists
            Random rnd = new Random();
            int number = 0;
            int RDay=0, RMonth=0, RYears=0;


            DGResult.Rows.Clear();
            for (int i = 1; i <= 13; i++)
            {
                try
                {
                    Start:
                    number = rnd.Next(1, 5);
                      RDay = Days[number];

                    number = rnd.Next(1, 5);
                      RMonth = Months[number];

                    number = rnd.Next(1, 5);
                      RYears = Years[number];



                    if (CheckDuplicate(RDay, RMonth, RYears))
                    {
                        goto Start;
                    }
                        
                    DisplayDay(index:i , year: RYears, month: RMonth , day: RDay);


                }
                catch (Exception exx)
                {
                    DisplayDay(index: i, year: RYears, month: RMonth, day: RDay);
                }

            }

        }

        private bool CheckDuplicate(int day, int month, int year)
        {
            for (int i = 0; i < DGResult.Rows.Count - 1; i++)
            {
                if (day == (int)DGResult.Rows[i].Cells["ColDay"].Value && month == (int)DGResult.Rows[i].Cells["ColMonth"].Value && year == (int)DGResult.Rows[i].Cells["ColYear"].Value)
                {
                    return true;
                }
            }
            return false;
        }
        private void DisplayDay(int index, int year , int month, int day)
        {
            
            try
            {
            DateTime dateValue = new DateTime(year, month, day);
                DGResult.Rows.Add(index, year, month, day, dateValue.ToString("dddd"));
            }
            catch (Exception ex)
            {
                DGResult.Rows.Add(index, year, month, day, " Invalid Date !!!");
            }
         
        }
    }
}