class Login{
    private string email;
    private string password;
    public Login (string email,string password){
        this.email = email;
        this.password = password;
    }
    public string get_email(){
        return email;
    }
    public string get_password(){
        return password;
    }
}