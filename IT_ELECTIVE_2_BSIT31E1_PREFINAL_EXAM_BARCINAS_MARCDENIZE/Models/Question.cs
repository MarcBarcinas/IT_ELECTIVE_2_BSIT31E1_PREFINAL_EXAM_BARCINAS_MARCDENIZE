namespace IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_BARCINAS_MARCDENIZE.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Choices { get; set; } = new List<string>();
        public int CorrectIndex { get; set; }
    }
}