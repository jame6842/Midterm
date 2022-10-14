class Student_school:Person{
    private int class_level;
    private string school_name;
    public Student_school (int gender,string name,string surname,int age,int class_level,string food_allergies,int religion,string school_name):base(gender,name,surname,age,food_allergies,religion){
        this.class_level = class_level;
        this.school_name = school_name;
    }
    public int get_class_level (){
        return (class_level);
    }
    public string get_school_name(){
        return (school_name);
    }
}