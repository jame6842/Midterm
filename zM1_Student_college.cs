class College_student : Person{
    private int student_Id;
    private string email;
    private string password;
    public College_student (int gender,string name,string surname,int student_Id,int age,string food_allergies,int religion,string email,string password)
    :base(gender,name,surname,age,food_allergies,religion)
    {
        this.student_Id = student_Id;
        this.email = email;
        this.password = password;
    }
    public int get_student_id(){
        return student_Id;
    }
    public string get_email(){
        return email;
    }
    public string get_password(){
        return password;
    }
}