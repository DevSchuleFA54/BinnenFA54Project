namespace BinnenFA54Project.Main.ResourceData
{
    public enum State
    {
        
        Waiting  = 0, // Default value until the question as been answered.
        Answered = 1  // Mark for when a checkbox has been selected.
    }

    public enum ResultsEnum
    {        
        Wrong     = 0, // Wrong answer
        Right     = 1, // Right answer
        NoneRight = 2, // No correct answer for the question if CorrectAnswerNum = null.
        NoAnswer  = 3  // Default value
    }

    public class Answer
    {
        public int Id                   { get; set; }
        public string CorrectAnswerText { get; set; }
        public int? CorrectAnswerNum    { get; set; } // nullable type of int.
        public int? SelectedAnswer      { get; set; }
        public ResultsEnum ResultsEnum  { get; set; } = ResultsEnum.NoAnswer;
        public State State              { get; set; } = State.Waiting;
    }
}
