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
            "���B�j��", 
            "�a�x�D�{�ܬG", 
            "�Ʒ~���B�C���A���ɩx�i��", 
            "�Ʒ~�_��j", 
            "�ˤH�f���n��", 
            "�Q�]�����U",
            "����@�|����" };

        readonly String[] suggest = { 
            "�ְ��a�ơA�]�����h�F�`�פT���v",
            "�O������A�@�s�٦��@�s���A���J�٦����J�|",
            "���ݥL�H�A���n���N�J���O�H�A���D�A�Ԥ���",
            "���I��ı�A���n�M�ۦۤv���o��A�N���N���]",
            "�p�ߤp�H�A�i�ׯB���ཪ��A����w�L�U���s",
            "���n���i�A�A�b��ı���ɭԡA����H�٦b�W�Z��",
            "���d�Ĥ@�A�w�������ˬd���԰O��ͫ�򻡡Adoctor!",
            "í�w�����A���Ѥ��}�ߨS���Y�A�ϥ����Ѥ]���|�}��" };

        //readonly List<string> analysis = new() {
        //    "������¾���������D�Ԧb���ۧA",
        //    "���P�f��A�v�T��A���]�Ȫ��p",
        //    "�A�o�{�A���]�B������n",
        //    "�A�ɨ賣��N�D�b�������R������",
        //    "�Aı�o�ۤv���V�O�P�^����������",
        //    "�p�󥭽Ĭ��|�ɶ��P�u�@�ɶ��@���O�A�W�o",
        //    "�A��ۤv�n�D�����P�ɡA��O�H�]�꦳�������n�D",
        //    "¾�����@�ӱ��@�Ӫ����|�O�A���ʮi�{��O���ɾ�",
        //    "�@�Ǧ��w���è��餺����f�B�±w�������Ӱ�",
        //    "¾�����G�`�O�b�D�ԧA�����u"
        //};
        //readonly List<string> suggest = new() {
        //    "�`�N�����A�~�קK�@���S�@�����f�h",
        //    "�h�ѥ[�E�|�P���ʡA���U���榨�\",
        //    "���n��۶}�l�@�q�s���Y",
        //    "���n�]�Ӯ�k�Ӱ���A�u�n���n�����A�ݩ�A���^���@�w�|�X�{",
        //    "�b¾���W�n�ɶq���U�ۤv����K�A�קK�P�P�ƪ��n",
        //    "�A�ɩ��P�õήi���ߡA�~�ష�d�`�n",
        //    "���I�ɶ��C�C�F�ѹ��A�O�@���d���~������O�H���P������",
        //    "�O���@�����[���ߡA�ť[���߲z�t��",
        //    "�ԷV���O�A�Ȧh�F�]���N��n��o��h",
        //    "�˵��@�U�ۤv���z�I�A�N��j�Ƭ��s���ޯ�"
        //};

        private void Button_Click(object sender, EventArgs e) {
            if (!result) {
                bool passed = true;
                if (string.IsNullOrWhiteSpace(NameTextBox.Text)) {
                    NameLabel2.Text = "���楼��g"; passed = false;
                } else NameLabel2.Text = "";

                if (string.IsNullOrWhiteSpace(GenderTextBox.Text)) {
                    GenderLabel2.Text = "���楼��g"; passed = false;
                } else if (!GenderTextBox.Text.Equals("�k") && !GenderTextBox.Text.Equals("�k")) {
                    GenderLabel2.Text = "��J�����kor�k"; passed = false;
                } else GenderLabel2.Text = "";

                if (string.IsNullOrWhiteSpace(BirthTextBox.Text)) {
                    BirthLabel2.Text = "���楼��g"; passed = false;
                } else BirthLabel2.Text = "";

                if (string.IsNullOrWhiteSpace(DateTextBox.Text)) {
                    DateLabel2.Text = "���楼��g"; passed = false;
                } else DateLabel2.Text = "";

                if (string.IsNullOrWhiteSpace(CdTextBox.Text)) {
                    CdLabel2.Text = "���楼��g"; passed = false;
                } else if (!CdTextBox.Text.Equals("��") && !CdTextBox.Text.Equals("��")) {
                    CdLabel2.Text = "��J������or��"; passed = false;
                } else CdLabel2.Text = "";

                if (passed) {
                    result = true;
                    Title.Text = "���ٮɨ�";

                    NameLabel2.Text = NameTextBox.Text;
                    GenderLabel2.Text = GenderTextBox.Text;
                    BirthLabel2.Text = BirthTextBox.Text;
                    DateLabel2.Text = DateTextBox.Text;
                    CdLabel2.Text = CdTextBox.Text;
                    Button.Text = "�ӡA�U���@��~~";

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
                    AnaLabel.Text = $"�B��: {analysis[random.Next(analysis.Length)]}";
                    SugLabel.Show(); //Visible = true;
                    SugLabel.Text = $"��ĳ: {suggest[random.Next(suggest.Length)]}";
                }
            } else {
                result = false;
                Title.Text = "��ƿ�J";

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
                Button.Text = "AI�j���Чi�D�ڵ��קa";
            }
        }
    }
}