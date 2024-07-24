using static ShtarXml.Service.ShtarService;
namespace ShtarXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateXmlIfNotExists();
            LoadComboBoxes();


        }


        public void LoadComboBoxes()
        {
            List<string> weekDaysList = new(["ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי"]);
            WeekDayComboBox.DataSource = weekDaysList;
            List<string> monthDaysList = new(["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"]);
            MonthDayComboBox.DataSource = monthDaysList;
            List<string> monthsList = new(["תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול"]);
            MonthComboBox.DataSource = monthsList;
            List<string> yearsList = new(["תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "ת\"שצ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג"]);
            YearComboBox.DataSource = yearsList;
        }

        public void createAndAddHebrewDate()
        {
            string weekDay = WeekDayComboBox.Text;
            string monthDay = MonthDayComboBox.Text;
            string month = MonthComboBox.Text;
            string year = YearComboBox.Text;

            MessageBox.Show($"{weekDay}, {monthDay}");

            var wDay = weekDay switch
            {
                null => "",
                "ראשון" => "באחד בשבת",
                "שני" => " בשבת בשני",
                "שלישי" => "בשלישי בשבת",
                "רביעי" => "ברביעי בשבת",
                "חמישי" => "בחמישי בשבת",
                "ששי" => "בששי בשבת",
                _ => string.Empty,
            };

            var nextMonth = month switch
            {
                "תשרי" => "מרחשון",
                "מרחשון" => "כסלו",
                "כסלו" => "טבת",
                "טבת" => "שבט",
                "שבט" => "אדר",
                "אדר" => "ניסן",
                "אדר ראשון" => "אדר שני",
                "אדר שני" => "ניסן",
                "ניסן" => "אייר",
                "אייר" => "סיון",
                "תמוז" => "אב",
                "אב" => "אלול",
                "אלול" => "תשרי"
            };

            var mDay = monthDay switch
            {
                "1" => $"יום אחד לירח {month}",
                "2" => $"שני ימים לירח {month}",
                "3" => $"שלשה ימים לירח {month}",
                "4" => $"ארבעה ימים לירח {month}",
                "5" => $"חמשה ימים לירח {month}",
                "6" => $"ששה ימים לירח {month}",
                "7" => $"שבעה ימים לירח {month}",
                "8" => $"שמנה ימים לירח {month}",
                "9" => $"תשעה ימים לירח {month}",
                "10" => $"עשרה ימים לירח {month}",
                "11" => $"אחד עשר יום לירח {month}",
                "12" => $"שני עשר  יום לירח {month}",
                "13" => $"שלשה עשר יום לירח {month}",
                "14" => $"ארבעה עשר יום לירח {month}",
                "15" => $"חמששה עשר יום לירח {month}",
                "16" => $"ששה עשר יום לירח {month}",
                "17" => $"שבעה עשר יום לירח {month}",
                "18" => $"שמנה עשר יום לירח {month}",
                "19" => $"תשעה עשר יום לירח {month}",
                "20" => $"עשרים יום לירח {month}",
                "21" => $"אחד ועשרים יום לירח {month}",
                "22" => $"שנים ועשרים יום לירח {month}",
                "23" => $"שלשה ועשרים יום לירח {month}",
                "24" => $"ארבעה ועשרים יום לירח {month}",
                "25" => $"חמשה ועשרים יום לירח {month}",
                "26" => $"ששה ועשרים יום לירח {month}",
                "27" => $"שבעה ועשרים יום לירח {month}",
                "28" => $"שמנה ועשרים יום לירח {month}",
                "29" => $"תשעה ועשרים יום לירח {month}",
                "30" => $"יום שלושים לחודש {month} שהוא ראש חודש {nextMonth}"
            };

            var yearPart = year switch
            {
                "תשפ\"ד" => "שמנים וארבע",
                "תשפ\"ה" => "שמנים וחמש",
                "תשפ\"ו" => "שמנים ושש",
                "תשפ\"ז" => "שמנים ושבע",
                "תשפ\"ח" => "שמנים ושמנה",
                "תשפ\"ט" => "שמנים ותשע",
                "ת\"שצ" => "תשעים",
                "תשצ\"א" => "תשעים ואחת",
                "תשצ\"ב" => "תשעים ושתים",
                "תשצ\"ג" => "תשעים ושלוש"
            };

            string result = $"{wDay} {mDay} שנת חמשת אלפים ושבע מאות ו{yearPart} לבריאת העולם";

            MessageBox.Show(result);

            addDateToXml(weekDay, monthDay, month, year, result);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            createAndAddHebrewDate();
        }
    }
}
