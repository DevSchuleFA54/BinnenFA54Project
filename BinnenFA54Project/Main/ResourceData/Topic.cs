namespace BinnenFA54Project.Main.ResourceData
{
    /// <summary>
    /// The structure of the Topic class which will be used as list in the TopicMgr.
    /// </summary>
    public class Topic
    {
        public int Id                 { get; set; }
        public string Name            { get; set; }
        public string Description     { get; set; }
        public byte? CorrectAnswerNum { get; set; }
    }
}
