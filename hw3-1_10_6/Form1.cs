using System.Collections.Generic;
using System;

namespace hw3_1_10_6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        bool result = false;
        readonly Random random = new();
        readonly String[] analysis = { 
            "桃花運大漲", 
            "家庭遭逢變故", 
            "事業平步青雲，有升官可能", 
            "事業起伏大", 
            "親人病情好轉", 
            "被財神眷顧",
            "近期一帆風順" };

        readonly String[] suggest = { 
            "少做壞事，夜路走多了總匯三明治",
            "保持謙虛，一山還有一山高，雞蛋還有雞蛋糕",
            "善待他人，不要任意嘲笑別人，除非你忍不住",
            "早點睡覺，不要仗著自己長得醜，就任意熬夜",
            "小心小人，可謂浮雲能蔽日，輕舟已過萬重山",
            "不要偷懶，你在睡覺的時候，美國人還在上班阿",
            "健康第一，定期身體檢查並謹記醫生怎麼說，doctor!",
            "穩定情緒，今天不開心沒關係，反正明天也不會開心" };

        //readonly List<string> analysis = new() {
        //    "有不少職場相關的挑戰在等著你",
        //    "金星逆行，影響到你的財務狀況",
        //    "你發現你的財運明顯轉好",
        //    "你時刻都能沐浴在甜美的愛情之中",
        //    "你覺得自己的努力與回報不成正比",
        //    "如何平衝約會時間與工作時間一直令你苦惱",
        //    "你對自己要求高的同時，對別人也抱有極高的要求",
        //    "職場中一個接一個的機會令你不缺展現實力的時機",
        //    "一些早已潛藏身體內的毛病、舊患正伺機而動",
        //    "職場似乎總是在挑戰你的底線"
        //};
        //readonly List<string> suggest = new() {
        //    "注意飲食，才避免一場又一場的病痛",
        //    "多參加聚會與活動，有助於脫單成功",
        //    "不要急著開始一段新關係",
        //    "不要因而氣餒而停止，只要做好本分，屬於你的回報一定會出現",
        //    "在職場上要盡量壓下自己的氣焰，避免與同事爭吵",
        //    "適時放鬆並舒展身心，才能健康常駐",
        //    "花點時間慢慢了解對方，別一不留神誤插足到別人的感情之中",
        //    "保持一顆樂觀的心，勿加重心理負擔",
        //    "謹慎消費，賺多了也不代表要花得更多",
        //    "檢視一下自己的弱點，將其強化為新的技能"
        //};

        private void Button_Click(object sender, EventArgs e) {
            if (!result) {
                bool passed = true;
                if (string.IsNullOrWhiteSpace(NameTextBox.Text)) {
                    NameLabel2.Text = "此欄未填寫"; passed = false;
                } else NameLabel2.Text = "";

                if (string.IsNullOrWhiteSpace(GenderTextBox.Text)) {
                    GenderLabel2.Text = "此欄未填寫"; passed = false;
                } else if (!GenderTextBox.Text.Equals("男") && !GenderTextBox.Text.Equals("女")) {
                    GenderLabel2.Text = "輸入應為男or女"; passed = false;
                } else GenderLabel2.Text = "";

                if (string.IsNullOrWhiteSpace(BirthTextBox.Text)) {
                    BirthLabel2.Text = "此欄未填寫"; passed = false;
                } else BirthLabel2.Text = "";

                if (string.IsNullOrWhiteSpace(DateTextBox.Text)) {
                    DateLabel2.Text = "此欄未填寫"; passed = false;
                } else DateLabel2.Text = "";

                if (string.IsNullOrWhiteSpace(CdTextBox.Text)) {
                    CdLabel2.Text = "此欄未填寫"; passed = false;
                } else if (!CdTextBox.Text.Equals("貓") && !CdTextBox.Text.Equals("狗")) {
                    CdLabel2.Text = "輸入應為貓or狗"; passed = false;
                } else CdLabel2.Text = "";

                if (passed) {
                    result = true;
                    Title.Text = "神諭時刻";

                    NameLabel2.Text = NameTextBox.Text;
                    GenderLabel2.Text = GenderTextBox.Text;
                    BirthLabel2.Text = BirthTextBox.Text;
                    DateLabel2.Text = DateTextBox.Text;
                    CdLabel2.Text = CdTextBox.Text;
                    Button.Text = "來，下面一位~~";

                    NameTextBox.Text = "";
                    NameTextBox.Hide(); //Visible = false;
                    GenderTextBox.Text = "";
                    GenderTextBox.Hide(); //Visible = false;
                    BirthTextBox.Text = "";
                    BirthTextBox.Hide(); //Visible = false;
                    DateTextBox.Text = "";
                    DateTextBox.Hide(); //Visible = false;
                    CdTextBox.Text = "";
                    CdTextBox.Hide(); //Visible = false;

                    NameLabel.Location = new Point(220, 60);
                    NameLabel2.Location = new Point(220, 90);
                    GenderLabel.Location = new Point(510, 60);
                    GenderLabel2.Location = new Point(510, 90);
                    BirthLabel.Location = new Point(70, 120);
                    BirthLabel2.Location = new Point(70, 150);
                    DateLabel.Location = new Point(370, 120);
                    DateLabel2.Location = new Point(370, 150);
                    CdLabel.Location = new Point(640, 120);
                    CdLabel2.Location = new Point(640, 150);

                    AnaLabel.Show(); //Visible = true;
                    AnaLabel.Text = $"運勢: {analysis[random.Next(analysis.Length)]}";
                    SugLabel.Show(); //Visible = true;
                    SugLabel.Text = $"建議: {suggest[random.Next(suggest.Length)]}";
                }
            } else {
                result = false;
                Title.Text = "資料輸入";

                NameTextBox.Show(); //Visible = true;
                GenderTextBox.Show(); //Visible = true;
                BirthTextBox.Show(); //Visible = true;
                DateTextBox.Show(); //Visible = true;
                CdTextBox.Show(); //Visible = true;

                NameLabel.Location = new Point(120, 80);
                NameLabel2.Location = new Point(580, 80);
                NameLabel2.Text = "";
                GenderLabel.Location = new Point(120, 140);
                GenderLabel2.Location = new Point(580, 140);
                GenderLabel2.Text = "";
                BirthLabel.Location = new Point(120, 200);
                BirthLabel2.Location = new Point(580, 200);
                BirthLabel2.Text = "";
                DateLabel.Location = new Point(120, 260);
                DateLabel2.Location = new Point(580, 260);
                DateLabel2.Text = "";
                CdLabel.Location = new Point(120, 320);
                CdLabel2.Location = new Point(580, 320);
                CdLabel2.Text = "";

                AnaLabel.Hide(); //Visible = false;
                SugLabel.Hide(); //Visible = false;
                Button.Text = "AI大神請告訴我答案吧";
            }
        }
    }
}