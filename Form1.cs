namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        private int time;
        private int totalTime;
        private List<int> difficulty = new List<int>();
        private List<int> units = new List<int>();
        private bool isPlaying = false;
        Questions questions = new();
        private int questionsAnswered = 0;
        private List<int> correctQuestions = new List<int>();
        private string currentCorrectAnswer = "";
        private int questionCount;
        private List<string> answers = new List<string>();
        private List<string> correctAnswers = new List<string>();
        private Question[] storedQuestions;

        const float DesiredQuestionsPerMinute = 10f;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void EndOfQuiz()
        {
            timer1.Enabled = false;
            totalTime -= time;
            isPlaying = false;
            pnlQuestion.Visible = false;
            pnlEndScreen.Visible = true;
            
            float scoreRaw = (float)correctQuestions.Count / (float)questionsAnswered * ((float)correctQuestions.Count / ((float)totalTime / 60f * DesiredQuestionsPerMinute)) * 100f;
            int score = (int)scoreRaw;

            lblPoints.Text = score.ToString();
            lblTotalAnswers.Text = questionsAnswered.ToString();
            lblCorrectAnswers.Text = correctQuestions.Count.ToString();

            for (int i = 0; i < questionsAnswered; i++)
            {
                EndscreenQuestion q = new() { Text = (i + 1).ToString() };
                q.SubItems.Add(answers[i]);
                q.SubItems.Add(storedQuestions[i].CorrectAnswer);
                if (answers[i] != storedQuestions[i].CorrectAnswer) { q.BackColor = Color.Red; }
                else { q.BackColor = Color.White; }
                lswEndScreenReview.Items.Add(q);
            }
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && pnlMainMenu.Visible)
            {
                robloxeasteregg.Visible = !robloxeasteregg.Visible;
            }
            else if (e.KeyCode == Keys.D && pnlMainMenu.Visible)
            {
                discordeasteregg.Visible = !discordeasteregg.Visible;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlMainMenu.Visible = false;
            pnlPrepMenu.Visible = true;
        }

        private void DisplayNextQuestion()
        {
            Question q = questions.ReturnRandomQuestion();
            storedQuestions[questionsAnswered] = q;

            lblQuestion.Text = q.Ask;

            float fontSize = lblQuestion.Font.Size;
            SizeF labelSize = new SizeF(lblQuestion.Width, lblQuestion.Height);
            while (fontSize > 1)
            {
                Font testFont = new Font(lblQuestion.Font.FontFamily, fontSize);
                Size textSize = TextRenderer.MeasureText(lblQuestion.Text, testFont, lblQuestion.Size, TextFormatFlags.WordBreak);

                if (textSize.Width <= labelSize.Width && textSize.Height <= labelSize.Height)
                {
                    lblQuestion.Font = testFont;
                    break;
                }

                fontSize -= 0.5f;
            }

            rdbAnswerA.Text = q.Answers[0].Text;
            rdbAnswerB.Text = q.Answers[1].Text;
            rdbAnswerC.Text = q.Answers[2].Text;
            rdbAnswerD.Text = q.Answers[3].Text;
            rdbAnswerE.Text = q.Answers[4].Text;
            currentCorrectAnswer = q.CorrectAnswer;

            correctAnswers.Add(currentCorrectAnswer);
        }

        private void LoadReviewQuestion(Question q)
        {
            lblQuestionReview.Text = q.Ask;
            lblReviewAnswerA.Text = q.Answers[0].Text;
            lblReviewAnswerB.Text = q.Answers[1].Text;
            lblReviewAnswerC.Text = q.Answers[2].Text;
            lblReviewAnswerD.Text = q.Answers[3].Text;
            lblReviewAnswerE.Text = q.Answers[4].Text;

            int questionIndex = Array.IndexOf(storedQuestions, q);

            lblReviewAnswerA.BackColor = Color.Salmon;
            lblReviewAnswerB.BackColor = Color.Salmon;
            lblReviewAnswerC.BackColor = Color.Salmon;
            lblReviewAnswerD.BackColor = Color.Salmon;
            lblReviewAnswerE.BackColor = Color.Salmon;

            if (answers[questionIndex] == q.CorrectAnswer)
            {
                if (q.CorrectAnswer == "a") { lblReviewAnswerA.BackColor = Color.Green; }
                else if (q.CorrectAnswer == "b") { lblReviewAnswerB.BackColor = Color.Green; }
                else if (q.CorrectAnswer == "c") { lblReviewAnswerC.BackColor = Color.Green; }
                else if (q.CorrectAnswer == "d") { lblReviewAnswerD.BackColor = Color.Green; }
                else if (q.CorrectAnswer == "e") { lblReviewAnswerE.BackColor = Color.Green; }
            }
            else
            {
                if (q.CorrectAnswer == "a") { lblReviewAnswerA.BackColor = Color.Green; }
                else if (q.CorrectAnswer == "b") { lblReviewAnswerB.BackColor = Color.Green; }
                else if (q.CorrectAnswer == "c") { lblReviewAnswerC.BackColor = Color.Green; }
                else if (q.CorrectAnswer == "d") { lblReviewAnswerD.BackColor = Color.Green; }
                else if (q.CorrectAnswer == "e") { lblReviewAnswerE.BackColor = Color.Green; }

                if (answers[questionIndex] == "a") { lblReviewAnswerA.BackColor = Color.Red; }
                else if (answers[questionIndex] == "b") { lblReviewAnswerB.BackColor = Color.Red; }
                else if (answers[questionIndex] == "c") { lblReviewAnswerC.BackColor = Color.Red; }
                else if (answers[questionIndex] == "d") { lblReviewAnswerD.BackColor = Color.Red; }
                else if (answers[questionIndex] == "e") { lblReviewAnswerE.BackColor = Color.Red; }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool canContinue = true;

            if (clbUnits.CheckedItems.Count == 0)
            {
                canContinue = false;
                lblUnits.ForeColor = Color.Red;
            }
            else
            {
                lblUnits.ForeColor = Form.DefaultForeColor;
            }

            if (clbDifficulty.CheckedItems.Count == 0)
            {
                canContinue = false;
                lblDifficulty.ForeColor = Color.Red;
            }
            else
            {
                lblDifficulty.ForeColor = Form.DefaultForeColor;
            }

            if (nudTime.Value == 0)
            {
                canContinue = false;
                lblTime.ForeColor = Color.Red;
            }
            else
            {
                lblTime.ForeColor = Form.DefaultForeColor;
            }

            if (!canContinue) { return; }

            foreach (string item in clbUnits.CheckedItems)
            {
                int unit = Convert.ToInt32("0" + item[^1]);
                units.Add(unit);
            }

            foreach (string item in clbDifficulty.CheckedItems)
            {
                if (item == "Kolay") { difficulty.Add(1); }
                else if (item == "Orta") { difficulty.Add(2); }
                else if (item == "Zor") { difficulty.Add(3); }
            }

            pnlPrepMenu.Visible = false;

            questions.units = units;
            questions.difficulty = difficulty;
            questions.Path = "Questions.xml";
            questions.Initialize();
            questionCount = questions.questions.Count;
            storedQuestions = new Question[questionCount];
            DisplayNextQuestion();

            pnlQuestion.Visible = true;
            time = (int)nudTime.Value * 60;
            totalTime = time;
            lblTimeRemaining.Text = $"Süre: {(time - time % 60) / 60}:{((time - ((time - time % 60) / 60) * 60 < 10) ? '0' : "")}{time - ((time - time % 60) / 60) * 60}";
            timer1.Enabled = true;
            isPlaying = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lblTimeRemaining.Text = $"Süre: {(time - time % 60) / 60}:{((time < 10) ? '0' : "")}{time - ((time - time % 60) / 60) * 60}";
            if (time == 0)
            {
                EndOfQuiz();
            }
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            pnlEndScreen.Visible = false;
            pnlMainMenu.Visible = true;
            questionsAnswered = 0;
            correctQuestions.Clear();
            difficulty.Clear();
            units.Clear();
            questions.Clear();
            lswEndScreenReview.Items.Clear();
            answers.Clear();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (!isPlaying) { return; }
            if (!rdbAnswerA.Checked && !rdbAnswerB.Checked && !rdbAnswerC.Checked && !rdbAnswerD.Checked && !rdbAnswerE.Checked) { return; }
            questionsAnswered++;

            if (rdbAnswerA.Checked) { answers.Add("a"); }
            else if (rdbAnswerB.Checked) { answers.Add("b"); }
            else if (rdbAnswerC.Checked) { answers.Add("c"); }
            else if (rdbAnswerD.Checked) { answers.Add("d"); }
            else if (rdbAnswerE.Checked) { answers.Add("e"); }

            if (rdbAnswerA.Checked && currentCorrectAnswer == "a") { correctQuestions.Add(questionsAnswered); }
            else if (rdbAnswerB.Checked && currentCorrectAnswer == "b") { correctQuestions.Add(questionsAnswered); }
            else if (rdbAnswerC.Checked && currentCorrectAnswer == "c") { correctQuestions.Add(questionsAnswered); }
            else if (rdbAnswerD.Checked && currentCorrectAnswer == "d") { correctQuestions.Add(questionsAnswered); }
            else if (rdbAnswerE.Checked && currentCorrectAnswer == "e") { correctQuestions.Add(questionsAnswered); }

            if (questionsAnswered == questionCount) { EndOfQuiz(); }
            else { DisplayNextQuestion(); }
        }

        private void lswEndScreenReview_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selected = lswEndScreenReview.SelectedItems[0];
            pnlReviewQuestion.Visible = true;
            pnlEndScreen.Visible = false;
            int questionNo = Convert.ToInt32(selected.Text) - 1;
            Question? q = storedQuestions[questionNo];
            LoadReviewQuestion(q);
        }

        private void btnReturnToEnd_Click(object sender, EventArgs e)
        {
            pnlEndScreen.Visible = true;
            pnlReviewQuestion.Visible = false;
        }
    }
}
