class Main_menu{
    private bool Register_event = false;
    private bool Stats_event = false;
    private bool Login_status = false;
    private int Main_menu_check;

    public int Main_Menu_Check{
        set {
            Main_menu_check = value;
        }
    }
    public void Main_Menu_Choose_check(){
        if (Main_menu_check == 1){
            this.Register_event = true;
        }
        else if (Main_menu_check == 2){
            this.Stats_event = true ;
        }
        else if (Main_menu_check == 3 ){
            this.Login_status = true ;
        }
    }
    public bool get_open_register_event(){
        if (Register_event == true){
            return true;
        }
        else return false;
    }
    public bool get_open_stats_event(){
        if (Stats_event == true){
            return true;
        }
        else return false;
    }
    public bool get_open_login_event(){
        if (Login_status == true){
            return true;
        }
        else return false;
    }
    public void Main_menu_clear(){
        this.Register_event = false;
        this.Stats_event = false;
        this.Login_status = false;
    }

}