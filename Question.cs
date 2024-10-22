using System.Xml;

#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8618

namespace WinFormsApp1
{
    public class Answer
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }

    public class Question
    {
        public string Ask { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public string CorrectAnswer { get; set; }
    }

    public class Questions
    {
        public string Path { get; set; }
        public List<int> difficulty = new List<int>();
        public List<int> units = new List<int>();
        public List<Question> questions { get; } = new List<Question>();

        public Questions() { }

        public Questions(string path, List<int> difficulty, List<int> units)
        {
            Path = path;
            this.difficulty = difficulty;
            this.units = units;
        }

        public bool Initialize()
        {
            foreach (var unit in units)
            {
                foreach (var diff in difficulty)
                {
                    XmlDocument doc = new();
                    doc.Load(this.Path);

                    XmlNode unitNode = doc.SelectSingleNode($"/questions/unit[@unit='{unit}']/difficulty[@level='{diff}']");

                    if (unitNode != null)
                    {
                        XmlNodeList questionNodes = unitNode.SelectNodes("question");

                        foreach (XmlNode question in questionNodes)
                        {
                            string questionText = question["ask"].InnerText;
                            string correctAnswer = question["correctAnswer"].InnerText;

                            Question q = new();
                            q.Ask = questionText;
                            q.CorrectAnswer = correctAnswer;
                            
                            foreach (XmlNode answer in question["answers"].SelectNodes("answer"))
                            {
                                Answer a = new();
                                a.Text = answer.InnerText;
                                a.Id = answer.Attributes["answerId"].Value;
                                q.Answers.Add(a);
                            }

                            this.questions.Add(q);
                        }
                    }
                }
            }
            return true;
        }

        public Question[] Retrieve()
        {
            Question[] qs = new Question[questions.Count];
            questions.CopyTo(qs);
            return qs;
        }

        public Question ReturnRandomQuestion()
        {
            Random rand = new();
            int randomIndex = rand.Next(this.questions.Count);
            Question randQ = this.questions[randomIndex];

            this.questions.Remove(randQ);
            return randQ;
        }

        public void Clear()
        {
            this.questions.Clear();
        }
    }
}