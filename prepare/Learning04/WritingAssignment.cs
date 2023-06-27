public class WritingAssignemnt : Assignment {

    private string _title;

    public WritingAssignemnt(string studentName, string topic, string title) : base(studentName,topic){
        _title = title;
    }

    public string GetWritingInformation(){
        return $"{_title} by {_studentName}";
    }

}