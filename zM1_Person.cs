class Person{
    private int gender;
    private string name;
    private string surname;
    private int age;
    private string food_allergies;
    private int religion;
    private bool develop_check=false;
    public Person (int gender,string name,string surname,int age,string food_allergies,int religion){
        this.gender = gender;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.food_allergies = food_allergies;
        this.religion = religion;
    }
    public int get_number_gender(){
        return gender;
    }
    public int get_number_religion(){
        return religion;
    }
    public string get_gender(){
        if (gender == 1){
            return ("นาย");
        }
        else if (gender == 2 ){
            return ("นาง");
        }
        else if (gender == 3 ){
            return ("นางสาว");
        }
        else {
            return null;
        }
    }
    public string get_name(){
        return name;
    }
    public string get_surname(){
        return surname;
    }
    public int get_age(){
        return age;
    }
    public string get_food_allergies(){
        return food_allergies;
    }
    public string get_religion(){
        if (religion == 1){
            return ("พุทธ");
        }
        else if (religion == 2 ){
            return ("คริสต์");
        }
        else if (religion == 3){
            return ("อิสลาม");
        }
        else {
            return ("อื่นๆ");
        }
    }
    public bool Develop_set{
        set{
            develop_check = value;
        }
        get{
            if (develop_check == false){
                return false;
            }
            else {
                Console.WriteLine("Please Input your Email and Password");
                return true;
            }
        }
    }
}