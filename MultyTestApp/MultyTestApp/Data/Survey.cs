namespace MultyTestApp.Data
{
	public class Survey
	{
        public string Question { get; set; }
        public string Answer { get; set; }
		public Survey(string Question, string Answer)
		{
			this.Question = Question;
			this.Answer = Answer;
		}

		public bool CheckAnswer(string Answer)
		{
			return this.Answer.Equals(Answer);
		}
	}
}
