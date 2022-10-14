class Statistic{
    private int count_of_people;
    private int count_college_student;
    private int count_of_student;
    private int count_of_teacher;
    private int count_of_matha4;
    private int count_of_matha5;
    private int count_of_matha6;
    public Statistic (int count_of_people,int count_college_student,int count_of_student,int count_college_teacher,int count_of_matha4,int count_of_matha5,int count_of_matha6){
        this.count_of_people = count_of_people;
        this.count_college_student = count_college_student;
        this.count_of_student = count_of_student;
        this.count_of_teacher = count_college_teacher;
        this.count_of_matha4 = count_of_matha4;
        this.count_of_matha5 = count_of_matha5;
        this.count_of_matha6 = count_of_matha6;
    }
    public int get_count_people(){
        return count_of_people;
    }
    public int get_count_student(){
        return count_of_student;
    }
    public int get_count_teacher(){
        return count_of_teacher;
    }
    public int get_count_mat4(){
        return count_of_matha4;
    }
    public int get_count_mat5(){
        return count_of_matha5;
    }
    public int get_count_mat6(){
        return count_of_matha6;
    }
    public int get_count_college_student(){
        return count_college_student;
    }
}