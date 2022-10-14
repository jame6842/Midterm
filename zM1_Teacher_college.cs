class Teacher_college:Person{
    private int personnel_status;
    private string car_status;
    private string car_number;
    private string email;
    private string password;
    public Teacher_college(int gender,string name,string surname,int age,int personnel_status,string food_allergies,int religion,string car_status,string car_number,string email,string password)
    :base(gender,name,surname,age,food_allergies,religion){
        this.personnel_status = personnel_status;
        this.car_status = car_status;
        this.car_number = car_number;
        this.email = email;
        this.password = password;
    }
    public string get_personnel_status(){
        if (personnel_status == 1){
            return "คณบดี";
        }
        else if (personnel_status == 2){
            return "หัวหน้าภาควิชา";
        }
        else if (personnel_status == 3){
            return "อาจารย์ประจำ";
        }
        else return null;
    }
    public string Car_get_number(){
        return car_number;
    }
    public string get_email(){
        return email;
    }
    public string get_password(){
        return password;
    }
}