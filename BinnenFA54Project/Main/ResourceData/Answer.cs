namespace BinnenFA54Project.Main.ResourceData
{

    /// <summary>
    /// In the QuizForm if a CheckBox event used, we updating the state of the question.
    /// </summary>
    public enum State
    {
        
        Waiting  = 0, // Default value until the question as been answered.
        Answered = 1  // Mark for when a checkbox has been selected.
    }


    /// <summary>
    /// Answer flags when we store results in the QuizForm.
    /// </summary>
    public enum ResultsEnum
    {        
        Wrong     = 0, // Wrong answer
        Right     = 1, // Right answer
        NoneRight = 2, // No correct answer for the question if CorrectAnswerNum = null.
        NoAnswer  = 3  // Default value
    }


    /// <summary>
    /// The structure of the Answer class which will be used as list in the AnswerMgr.
    /// </summary>
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
