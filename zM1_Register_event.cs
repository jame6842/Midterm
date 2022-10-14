class Register_menu{
    private int person_type;
    public int set_person_Type{
        set{
            person_type = value;
        }
    }
    public int get_person_type_check(){
        if (person_type == 1){
            return 1;
        }
        else if (person_type == 2){
            return 2;
        }
        else if (person_type == 3){
            return 3;
        }
        else return 0;
    }
}