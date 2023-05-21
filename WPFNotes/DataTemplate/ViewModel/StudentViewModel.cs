using DataTemplate.Model;
using System.Collections.ObjectModel;

namespace DataTemplate.ViewModel
{
    internal class StudentViewModel
    {
        public ObservableCollection<StudentModel> StudentModelCollection { get; set; } = new ObservableCollection<StudentModel>();
        public StudentModel SelectedStudentModel { get; set; }

        public StudentViewModel()
        {
            StudentModel studentModel1 = new StudentModel(1, "宋一");
            StudentModel studentModel2 = new StudentModel(2, "赵二");
            StudentModel studentModel3 = new StudentModel(3, "张三");
            StudentModel studentModel4 = new StudentModel(4, "李四");
            StudentModel studentModel5 = new StudentModel(5, "王老五");

            StudentModelCollection.Add(studentModel1);
            StudentModelCollection.Add(studentModel2);
            StudentModelCollection.Add(studentModel3);
            StudentModelCollection.Add(studentModel4);
            StudentModelCollection.Add(studentModel5);

            SelectedStudentModel = StudentModelCollection[0];
        }
    }
}
