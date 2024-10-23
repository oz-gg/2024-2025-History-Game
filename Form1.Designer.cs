namespace WinFormsApp1
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            robloxeasteregg = new Label();
            btnPlay = new Button();
            pnlMainMenu = new Panel();
            discordeasteregg = new Label();
            pnlPrepMenu = new Panel();
            btnStart = new Button();
            pnlTime = new Panel();
            nudTime = new NumericUpDown();
            lblTime = new Label();
            pnlDifficulty = new Panel();
            clbDifficulty = new CheckedListBox();
            lblDifficulty = new Label();
            pnlUnits = new Panel();
            lblUnits = new Label();
            clbUnits = new CheckedListBox();
            pnlQuestion = new Panel();
            btnNextQuestion = new Button();
            pnlAnswers = new Panel();
            rdbAnswerE = new RadioButton();
            rdbAnswerD = new RadioButton();
            rdbAnswerC = new RadioButton();
            rdbAnswerB = new RadioButton();
            rdbAnswerA = new RadioButton();
            lblQuestion = new Label();
            lblTimeRemaining = new Label();
            lblQuestionCount = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlEndScreen = new Panel();
            btnReturnToMenu = new Button();
            lblQuestions = new Label();
            lswEndScreenReview = new ListView();
            clhQuestionNo = new ColumnHeader();
            clhYourAnswer = new ColumnHeader();
            clhCorrectAnswer = new ColumnHeader();
            lblCorrectAnswers = new Label();
            lblTotalAnswers = new Label();
            lblPoints = new Label();
            lblYCA = new Label();
            lblYTA = new Label();
            lblYourPoints = new Label();
            lblGameOver = new Label();
            pnlReviewQuestion = new Panel();
            btnReturnToEnd = new Button();
            lblReviewAnswerE = new Label();
            lblReviewAnswerD = new Label();
            lblReviewAnswerC = new Label();
            lblReviewAnswerB = new Label();
            lblReviewAnswerA = new Label();
            lblQuestionReview = new Label();
            pnlMainMenu.SuspendLayout();
            pnlPrepMenu.SuspendLayout();
            pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTime).BeginInit();
            pnlDifficulty.SuspendLayout();
            pnlUnits.SuspendLayout();
            pnlQuestion.SuspendLayout();
            pnlAnswers.SuspendLayout();
            pnlEndScreen.SuspendLayout();
            pnlReviewQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(784, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "10/B Sınıfı 2024-2025 Eğitim Öğretim Yılı Tarih Dersi Quiz oyunu";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // robloxeasteregg
            // 
            robloxeasteregg.Dock = DockStyle.Bottom;
            robloxeasteregg.Font = new Font("Segoe UI", 10F);
            robloxeasteregg.Location = new Point(0, 438);
            robloxeasteregg.Name = "robloxeasteregg";
            robloxeasteregg.Size = new Size(784, 23);
            robloxeasteregg.TabIndex = 1;
            robloxeasteregg.Text = "ROBLOX AÇILSIN";
            robloxeasteregg.TextAlign = ContentAlignment.MiddleCenter;
            robloxeasteregg.Visible = false;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 40F);
            btnPlay.Location = new Point(302, 191);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(180, 90);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Oyna";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // pnlMainMenu
            // 
            pnlMainMenu.BackColor = Color.Salmon;
            pnlMainMenu.Controls.Add(discordeasteregg);
            pnlMainMenu.Controls.Add(btnPlay);
            pnlMainMenu.Controls.Add(robloxeasteregg);
            pnlMainMenu.Controls.Add(lblTitle);
            pnlMainMenu.Dock = DockStyle.Fill;
            pnlMainMenu.Location = new Point(0, 0);
            pnlMainMenu.Name = "pnlMainMenu";
            pnlMainMenu.Size = new Size(784, 461);
            pnlMainMenu.TabIndex = 3;
            // 
            // discordeasteregg
            // 
            discordeasteregg.Dock = DockStyle.Bottom;
            discordeasteregg.Font = new Font("Segoe UI", 10F);
            discordeasteregg.Location = new Point(0, 415);
            discordeasteregg.Name = "discordeasteregg";
            discordeasteregg.Size = new Size(784, 23);
            discordeasteregg.TabIndex = 3;
            discordeasteregg.Text = "DISCORD AÇILSIN";
            discordeasteregg.TextAlign = ContentAlignment.MiddleCenter;
            discordeasteregg.Visible = false;
            // 
            // pnlPrepMenu
            // 
            pnlPrepMenu.BackColor = Color.Salmon;
            pnlPrepMenu.Controls.Add(btnStart);
            pnlPrepMenu.Controls.Add(pnlTime);
            pnlPrepMenu.Controls.Add(pnlDifficulty);
            pnlPrepMenu.Controls.Add(pnlUnits);
            pnlPrepMenu.Dock = DockStyle.Fill;
            pnlPrepMenu.Location = new Point(0, 0);
            pnlPrepMenu.Name = "pnlPrepMenu";
            pnlPrepMenu.Size = new Size(784, 461);
            pnlPrepMenu.TabIndex = 4;
            pnlPrepMenu.Visible = false;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.Window;
            btnStart.Font = new Font("Segoe UI", 30F);
            btnStart.Location = new Point(332, 342);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 80);
            btnStart.TabIndex = 5;
            btnStart.Text = "Başla";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // pnlTime
            // 
            pnlTime.Controls.Add(nudTime);
            pnlTime.Controls.Add(lblTime);
            pnlTime.Location = new Point(332, 181);
            pnlTime.Margin = new Padding(0);
            pnlTime.Name = "pnlTime";
            pnlTime.Size = new Size(150, 100);
            pnlTime.TabIndex = 4;
            // 
            // nudTime
            // 
            nudTime.BackColor = SystemColors.Window;
            nudTime.Dock = DockStyle.Bottom;
            nudTime.Font = new Font("Segoe UI", 20F);
            nudTime.Location = new Point(0, 57);
            nudTime.Margin = new Padding(0);
            nudTime.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudTime.Name = "nudTime";
            nudTime.Size = new Size(150, 43);
            nudTime.TabIndex = 4;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Top;
            lblTime.Font = new Font("Segoe UI", 20F);
            lblTime.Location = new Point(0, 0);
            lblTime.Margin = new Padding(0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(150, 35);
            lblTime.TabIndex = 3;
            lblTime.Text = "Süre (dk)";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDifficulty
            // 
            pnlDifficulty.Controls.Add(clbDifficulty);
            pnlDifficulty.Controls.Add(lblDifficulty);
            pnlDifficulty.Location = new Point(451, 9);
            pnlDifficulty.Margin = new Padding(0);
            pnlDifficulty.Name = "pnlDifficulty";
            pnlDifficulty.Size = new Size(150, 100);
            pnlDifficulty.TabIndex = 3;
            // 
            // clbDifficulty
            // 
            clbDifficulty.BackColor = Color.Salmon;
            clbDifficulty.BorderStyle = BorderStyle.None;
            clbDifficulty.CheckOnClick = true;
            clbDifficulty.Dock = DockStyle.Bottom;
            clbDifficulty.FormattingEnabled = true;
            clbDifficulty.Items.AddRange(new object[] { "Kolay", "Orta", "Zor" });
            clbDifficulty.Location = new Point(0, 46);
            clbDifficulty.Margin = new Padding(0);
            clbDifficulty.Name = "clbDifficulty";
            clbDifficulty.Size = new Size(150, 54);
            clbDifficulty.TabIndex = 3;
            // 
            // lblDifficulty
            // 
            lblDifficulty.Dock = DockStyle.Top;
            lblDifficulty.Font = new Font("Segoe UI", 20F);
            lblDifficulty.Location = new Point(0, 0);
            lblDifficulty.Margin = new Padding(0);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new Size(150, 35);
            lblDifficulty.TabIndex = 2;
            lblDifficulty.Text = "Zorluk";
            lblDifficulty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlUnits
            // 
            pnlUnits.Controls.Add(lblUnits);
            pnlUnits.Controls.Add(clbUnits);
            pnlUnits.Location = new Point(216, 9);
            pnlUnits.Margin = new Padding(0);
            pnlUnits.Name = "pnlUnits";
            pnlUnits.Size = new Size(150, 150);
            pnlUnits.TabIndex = 2;
            // 
            // lblUnits
            // 
            lblUnits.Dock = DockStyle.Top;
            lblUnits.Font = new Font("Segoe UI", 20F);
            lblUnits.Location = new Point(0, 0);
            lblUnits.Margin = new Padding(0);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(150, 35);
            lblUnits.TabIndex = 1;
            lblUnits.Text = "Üniteler";
            lblUnits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clbUnits
            // 
            clbUnits.BackColor = Color.Salmon;
            clbUnits.BorderStyle = BorderStyle.None;
            clbUnits.CheckOnClick = true;
            clbUnits.Dock = DockStyle.Bottom;
            clbUnits.FormattingEnabled = true;
            clbUnits.Items.AddRange(new object[] { "Ünite 1", "Ünite 2", "Ünite 3", "Ünite 4", "Ünite 5" });
            clbUnits.Location = new Point(0, 42);
            clbUnits.Margin = new Padding(0);
            clbUnits.Name = "clbUnits";
            clbUnits.Size = new Size(150, 108);
            clbUnits.TabIndex = 0;
            // 
            // pnlQuestion
            // 
            pnlQuestion.BackColor = Color.Salmon;
            pnlQuestion.Controls.Add(btnNextQuestion);
            pnlQuestion.Controls.Add(pnlAnswers);
            pnlQuestion.Controls.Add(lblQuestion);
            pnlQuestion.Controls.Add(lblTimeRemaining);
            pnlQuestion.Controls.Add(lblQuestionCount);
            pnlQuestion.Dock = DockStyle.Fill;
            pnlQuestion.Location = new Point(0, 0);
            pnlQuestion.Name = "pnlQuestion";
            pnlQuestion.Size = new Size(784, 461);
            pnlQuestion.TabIndex = 5;
            pnlQuestion.Visible = false;
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.BackColor = SystemColors.Window;
            btnNextQuestion.Font = new Font("Segoe UI", 12F);
            btnNextQuestion.Location = new Point(635, 422);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(129, 31);
            btnNextQuestion.TabIndex = 4;
            btnNextQuestion.Text = "Sonraki Soru >";
            btnNextQuestion.UseVisualStyleBackColor = false;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // pnlAnswers
            // 
            pnlAnswers.Controls.Add(rdbAnswerE);
            pnlAnswers.Controls.Add(rdbAnswerD);
            pnlAnswers.Controls.Add(rdbAnswerC);
            pnlAnswers.Controls.Add(rdbAnswerB);
            pnlAnswers.Controls.Add(rdbAnswerA);
            pnlAnswers.Location = new Point(12, 238);
            pnlAnswers.Name = "pnlAnswers";
            pnlAnswers.Size = new Size(760, 175);
            pnlAnswers.TabIndex = 3;
            // 
            // rdbAnswerE
            // 
            rdbAnswerE.AutoSize = true;
            rdbAnswerE.Font = new Font("Segoe UI", 13F);
            rdbAnswerE.Location = new Point(3, 144);
            rdbAnswerE.Name = "rdbAnswerE";
            rdbAnswerE.Size = new Size(93, 29);
            rdbAnswerE.TabIndex = 4;
            rdbAnswerE.TabStop = true;
            rdbAnswerE.Text = "Cevap E";
            rdbAnswerE.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerD
            // 
            rdbAnswerD.AutoSize = true;
            rdbAnswerD.Font = new Font("Segoe UI", 13F);
            rdbAnswerD.Location = new Point(3, 109);
            rdbAnswerD.Name = "rdbAnswerD";
            rdbAnswerD.Size = new Size(97, 29);
            rdbAnswerD.TabIndex = 3;
            rdbAnswerD.TabStop = true;
            rdbAnswerD.Text = "Cevap D";
            rdbAnswerD.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerC
            // 
            rdbAnswerC.AutoSize = true;
            rdbAnswerC.Font = new Font("Segoe UI", 13F);
            rdbAnswerC.Location = new Point(3, 73);
            rdbAnswerC.Name = "rdbAnswerC";
            rdbAnswerC.Size = new Size(95, 29);
            rdbAnswerC.TabIndex = 2;
            rdbAnswerC.TabStop = true;
            rdbAnswerC.Text = "Cevap C";
            rdbAnswerC.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerB
            // 
            rdbAnswerB.AutoSize = true;
            rdbAnswerB.Font = new Font("Segoe UI", 13F);
            rdbAnswerB.Location = new Point(3, 38);
            rdbAnswerB.Name = "rdbAnswerB";
            rdbAnswerB.Size = new Size(94, 29);
            rdbAnswerB.TabIndex = 1;
            rdbAnswerB.TabStop = true;
            rdbAnswerB.Text = "Cevap B";
            rdbAnswerB.UseVisualStyleBackColor = true;
            // 
            // rdbAnswerA
            // 
            rdbAnswerA.AutoSize = true;
            rdbAnswerA.Font = new Font("Segoe UI", 13F);
            rdbAnswerA.Location = new Point(3, 3);
            rdbAnswerA.Name = "rdbAnswerA";
            rdbAnswerA.Size = new Size(96, 29);
            rdbAnswerA.TabIndex = 0;
            rdbAnswerA.TabStop = true;
            rdbAnswerA.Text = "Cevap A";
            rdbAnswerA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.Tomato;
            lblQuestion.Font = new Font("Segoe UI", 20F);
            lblQuestion.Location = new Point(12, 55);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(750, 150);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Soru";
            // 
            // lblTimeRemaining
            // 
            lblTimeRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTimeRemaining.AutoSize = true;
            lblTimeRemaining.Font = new Font("Segoe UI", 15F);
            lblTimeRemaining.Location = new Point(680, 9);
            lblTimeRemaining.Name = "lblTimeRemaining";
            lblTimeRemaining.Size = new Size(97, 28);
            lblTimeRemaining.TabIndex = 1;
            lblTimeRemaining.Text = "Süre: 0:00";
            lblTimeRemaining.TextAlign = ContentAlignment.TopRight;
            // 
            // lblQuestionCount
            // 
            lblQuestionCount.AutoSize = true;
            lblQuestionCount.Font = new Font("Segoe UI", 15F);
            lblQuestionCount.Location = new Point(12, 9);
            lblQuestionCount.Name = "lblQuestionCount";
            lblQuestionCount.Size = new Size(73, 28);
            lblQuestionCount.TabIndex = 0;
            lblQuestionCount.Text = "Soru: 0";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pnlEndScreen
            // 
            pnlEndScreen.BackColor = Color.Salmon;
            pnlEndScreen.Controls.Add(btnReturnToMenu);
            pnlEndScreen.Controls.Add(lblQuestions);
            pnlEndScreen.Controls.Add(lswEndScreenReview);
            pnlEndScreen.Controls.Add(lblCorrectAnswers);
            pnlEndScreen.Controls.Add(lblTotalAnswers);
            pnlEndScreen.Controls.Add(lblPoints);
            pnlEndScreen.Controls.Add(lblYCA);
            pnlEndScreen.Controls.Add(lblYTA);
            pnlEndScreen.Controls.Add(lblYourPoints);
            pnlEndScreen.Controls.Add(lblGameOver);
            pnlEndScreen.Dock = DockStyle.Fill;
            pnlEndScreen.Location = new Point(0, 0);
            pnlEndScreen.Name = "pnlEndScreen";
            pnlEndScreen.Size = new Size(784, 461);
            pnlEndScreen.TabIndex = 6;
            pnlEndScreen.Visible = false;
            // 
            // btnReturnToMenu
            // 
            btnReturnToMenu.Font = new Font("Segoe UI", 13F);
            btnReturnToMenu.Location = new Point(15, 419);
            btnReturnToMenu.Name = "btnReturnToMenu";
            btnReturnToMenu.Size = new Size(159, 34);
            btnReturnToMenu.TabIndex = 9;
            btnReturnToMenu.Text = "Ana Menüye Dön";
            btnReturnToMenu.UseVisualStyleBackColor = true;
            btnReturnToMenu.Click += btnReturnToMenu_Click;
            // 
            // lblQuestions
            // 
            lblQuestions.Anchor = AnchorStyles.Top;
            lblQuestions.Font = new Font("Segoe UI", 15F);
            lblQuestions.Location = new Point(12, 58);
            lblQuestions.Name = "lblQuestions";
            lblQuestions.Size = new Size(550, 28);
            lblQuestions.TabIndex = 8;
            lblQuestions.Text = "Sorular";
            lblQuestions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lswEndScreenReview
            // 
            lswEndScreenReview.BackColor = SystemColors.Window;
            lswEndScreenReview.BorderStyle = BorderStyle.None;
            lswEndScreenReview.Columns.AddRange(new ColumnHeader[] { clhQuestionNo, clhYourAnswer, clhCorrectAnswer });
            lswEndScreenReview.FullRowSelect = true;
            lswEndScreenReview.GridLines = true;
            lswEndScreenReview.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lswEndScreenReview.Location = new Point(12, 89);
            lswEndScreenReview.MultiSelect = false;
            lswEndScreenReview.Name = "lswEndScreenReview";
            lswEndScreenReview.Size = new Size(550, 330);
            lswEndScreenReview.TabIndex = 7;
            lswEndScreenReview.UseCompatibleStateImageBehavior = false;
            lswEndScreenReview.View = View.Details;
            lswEndScreenReview.DoubleClick += lswEndScreenReview_DoubleClick;
            // 
            // clhQuestionNo
            // 
            clhQuestionNo.Text = "Soru N°";
            clhQuestionNo.Width = 183;
            // 
            // clhYourAnswer
            // 
            clhYourAnswer.Text = "Cevabınız";
            clhYourAnswer.Width = 183;
            // 
            // clhCorrectAnswer
            // 
            clhCorrectAnswer.Text = "Doğru Cevap";
            clhCorrectAnswer.Width = 183;
            // 
            // lblCorrectAnswers
            // 
            lblCorrectAnswers.Anchor = AnchorStyles.Top;
            lblCorrectAnswers.Font = new Font("Segoe UI", 45F);
            lblCorrectAnswers.Location = new Point(591, 330);
            lblCorrectAnswers.Name = "lblCorrectAnswers";
            lblCorrectAnswers.Size = new Size(149, 89);
            lblCorrectAnswers.TabIndex = 6;
            lblCorrectAnswers.Text = "0";
            lblCorrectAnswers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalAnswers
            // 
            lblTotalAnswers.Anchor = AnchorStyles.Top;
            lblTotalAnswers.Font = new Font("Segoe UI", 45F);
            lblTotalAnswers.Location = new Point(591, 213);
            lblTotalAnswers.Name = "lblTotalAnswers";
            lblTotalAnswers.Size = new Size(149, 89);
            lblTotalAnswers.TabIndex = 5;
            lblTotalAnswers.Text = "0";
            lblTotalAnswers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPoints
            // 
            lblPoints.Anchor = AnchorStyles.Top;
            lblPoints.Font = new Font("Segoe UI", 45F);
            lblPoints.Location = new Point(591, 89);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(149, 89);
            lblPoints.TabIndex = 4;
            lblPoints.Text = "0";
            lblPoints.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYCA
            // 
            lblYCA.Anchor = AnchorStyles.Top;
            lblYCA.AutoSize = true;
            lblYCA.Font = new Font("Segoe UI", 15F);
            lblYCA.Location = new Point(591, 302);
            lblYCA.Name = "lblYCA";
            lblYCA.Size = new Size(149, 28);
            lblYCA.TabIndex = 3;
            lblYCA.Text = "Doğru Cevaplar";
            // 
            // lblYTA
            // 
            lblYTA.Anchor = AnchorStyles.Top;
            lblYTA.AutoSize = true;
            lblYTA.Font = new Font("Segoe UI", 15F);
            lblYTA.Location = new Point(587, 185);
            lblYTA.Name = "lblYTA";
            lblYTA.Size = new Size(157, 28);
            lblYTA.TabIndex = 2;
            lblYTA.Text = "Toplam Cevaplar";
            // 
            // lblYourPoints
            // 
            lblYourPoints.Anchor = AnchorStyles.Top;
            lblYourPoints.AutoSize = true;
            lblYourPoints.Font = new Font("Segoe UI", 15F);
            lblYourPoints.Location = new Point(623, 61);
            lblYourPoints.Name = "lblYourPoints";
            lblYourPoints.Size = new Size(85, 28);
            lblYourPoints.TabIndex = 1;
            lblYourPoints.Text = "Puanınız";
            // 
            // lblGameOver
            // 
            lblGameOver.Anchor = AnchorStyles.Top;
            lblGameOver.Font = new Font("Segoe UI", 25F);
            lblGameOver.Location = new Point(0, 0);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(784, 50);
            lblGameOver.TabIndex = 0;
            lblGameOver.Text = "Oyun Bitti!";
            lblGameOver.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlReviewQuestion
            // 
            pnlReviewQuestion.BackColor = Color.Salmon;
            pnlReviewQuestion.Controls.Add(btnReturnToEnd);
            pnlReviewQuestion.Controls.Add(lblReviewAnswerE);
            pnlReviewQuestion.Controls.Add(lblReviewAnswerD);
            pnlReviewQuestion.Controls.Add(lblReviewAnswerC);
            pnlReviewQuestion.Controls.Add(lblReviewAnswerB);
            pnlReviewQuestion.Controls.Add(lblReviewAnswerA);
            pnlReviewQuestion.Controls.Add(lblQuestionReview);
            pnlReviewQuestion.Dock = DockStyle.Fill;
            pnlReviewQuestion.Location = new Point(0, 0);
            pnlReviewQuestion.Name = "pnlReviewQuestion";
            pnlReviewQuestion.Size = new Size(784, 461);
            pnlReviewQuestion.TabIndex = 7;
            pnlReviewQuestion.Visible = false;
            // 
            // btnReturnToEnd
            // 
            btnReturnToEnd.Font = new Font("Segoe UI", 15F);
            btnReturnToEnd.Location = new Point(15, 394);
            btnReturnToEnd.Name = "btnReturnToEnd";
            btnReturnToEnd.Size = new Size(133, 41);
            btnReturnToEnd.TabIndex = 9;
            btnReturnToEnd.Text = "< Geri Dön";
            btnReturnToEnd.UseVisualStyleBackColor = true;
            btnReturnToEnd.Click += btnReturnToEnd_Click;
            // 
            // lblReviewAnswerE
            // 
            lblReviewAnswerE.Font = new Font("Segoe UI", 13F);
            lblReviewAnswerE.Location = new Point(12, 342);
            lblReviewAnswerE.Name = "lblReviewAnswerE";
            lblReviewAnswerE.Size = new Size(750, 27);
            lblReviewAnswerE.TabIndex = 8;
            lblReviewAnswerE.Text = "Cevap";
            // 
            // lblReviewAnswerD
            // 
            lblReviewAnswerD.Font = new Font("Segoe UI", 13F);
            lblReviewAnswerD.Location = new Point(12, 308);
            lblReviewAnswerD.Name = "lblReviewAnswerD";
            lblReviewAnswerD.Size = new Size(750, 27);
            lblReviewAnswerD.TabIndex = 7;
            lblReviewAnswerD.Text = "Cevap";
            // 
            // lblReviewAnswerC
            // 
            lblReviewAnswerC.Font = new Font("Segoe UI", 13F);
            lblReviewAnswerC.Location = new Point(12, 275);
            lblReviewAnswerC.Name = "lblReviewAnswerC";
            lblReviewAnswerC.Size = new Size(750, 27);
            lblReviewAnswerC.TabIndex = 6;
            lblReviewAnswerC.Text = "Cevap";
            // 
            // lblReviewAnswerB
            // 
            lblReviewAnswerB.Font = new Font("Segoe UI", 13F);
            lblReviewAnswerB.Location = new Point(12, 243);
            lblReviewAnswerB.Name = "lblReviewAnswerB";
            lblReviewAnswerB.Size = new Size(750, 27);
            lblReviewAnswerB.TabIndex = 5;
            lblReviewAnswerB.Text = "Cevap";
            // 
            // lblReviewAnswerA
            // 
            lblReviewAnswerA.Font = new Font("Segoe UI", 13F);
            lblReviewAnswerA.Location = new Point(12, 208);
            lblReviewAnswerA.Name = "lblReviewAnswerA";
            lblReviewAnswerA.Size = new Size(750, 27);
            lblReviewAnswerA.TabIndex = 4;
            lblReviewAnswerA.Text = "Cevap";
            // 
            // lblQuestionReview
            // 
            lblQuestionReview.BackColor = Color.Tomato;
            lblQuestionReview.Font = new Font("Segoe UI", 20F);
            lblQuestionReview.Location = new Point(15, 16);
            lblQuestionReview.Name = "lblQuestionReview";
            lblQuestionReview.Size = new Size(750, 189);
            lblQuestionReview.TabIndex = 3;
            lblQuestionReview.Text = "Soru";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(pnlReviewQuestion);
            Controls.Add(pnlQuestion);
            Controls.Add(pnlMainMenu);
            Controls.Add(pnlPrepMenu);
            Controls.Add(pnlEndScreen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "10/B \"Tarih Oyunu\" 2024";
            KeyDown += MainMenu_KeyDown;
            pnlMainMenu.ResumeLayout(false);
            pnlPrepMenu.ResumeLayout(false);
            pnlTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudTime).EndInit();
            pnlDifficulty.ResumeLayout(false);
            pnlUnits.ResumeLayout(false);
            pnlQuestion.ResumeLayout(false);
            pnlQuestion.PerformLayout();
            pnlAnswers.ResumeLayout(false);
            pnlAnswers.PerformLayout();
            pnlEndScreen.ResumeLayout(false);
            pnlEndScreen.PerformLayout();
            pnlReviewQuestion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label robloxeasteregg;
        private Button btnPlay;
        private Panel pnlMainMenu;
        private Panel pnlPrepMenu;
        private Panel pnlUnits;
        private Label lblUnits;
        private CheckedListBox clbUnits;
        private Panel pnlDifficulty;
        private Label lblDifficulty;
        private CheckedListBox clbDifficulty;
        private Panel pnlTime;
        private Label lblTime;
        private NumericUpDown nudTime;
        private Button btnStart;
        private Panel pnlQuestion;
        private Label lblQuestionCount;
        private Label lblQuestion;
        private Label lblTimeRemaining;
        private Panel pnlAnswers;
        private RadioButton rdbAnswerE;
        private RadioButton rdbAnswerD;
        private RadioButton rdbAnswerC;
        private RadioButton rdbAnswerB;
        private RadioButton rdbAnswerA;
        private Button btnNextQuestion;
        private System.Windows.Forms.Timer timer1;
        private Panel pnlEndScreen;
        private Label lblGameOver;
        private Label lblYTA;
        private Label lblYourPoints;
        private Label lblYCA;
        private Label lblPoints;
        private Label lblTotalAnswers;
        private Label lblCorrectAnswers;
        private Label lblQuestions;
        private ListView lswEndScreenReview;
        private Button btnReturnToMenu;
        private ColumnHeader clhQuestionNo;
        private ColumnHeader clhYourAnswer;
        private ColumnHeader clhCorrectAnswer;
        private Panel pnlReviewQuestion;
        private Label lblReviewAnswerA;
        private Label lblQuestionReview;
        private Label lblReviewAnswerE;
        private Label lblReviewAnswerD;
        private Label lblReviewAnswerC;
        private Label lblReviewAnswerB;
        private Button btnReturnToEnd;
        private Label discordeasteregg;
    }
}