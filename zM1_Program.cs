using System;
class Program {
    public static College_student set_already_college_student(int gender,string name,string surname,int student_Id,int age,string food_allergies,int religion,string email,string password){
        return new College_student(gender,name,surname,student_Id,age,food_allergies,religion,email,password);
    }
    public static College_student create_new_register_college_student(){
        Console.Write("คำนำหน้า :");
        Console.Write("นาย(1) นาง(2) นางสาว(3)");
        int gender = int.Parse(Console.ReadLine());
        Console.Write("ชื่อ : ");
        string name = Console.ReadLine();
        Console.Write("นามสกุล : ");
        string surname = Console.ReadLine();
        Console.Write("รหัสนักศึกษา : ");
        int student_Id = int.Parse(Console.ReadLine());
        Console.Write("อายุ : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("อาหารที่แพ้ : ");
        string food_allergies = Console.ReadLine();
        Console.Write("ศาสนา : ");
        int religion = int.Parse(Console.ReadLine());
        Console.WriteLine("หากเป็นผู้ดูแลระบบให้ใส่ yes : ");
        string email_check = Console.ReadLine();
        string email="",password="";
        if (email_check == "yes"){
            Console.WriteLine("กรอกอีเมลล์ของคุณ");
            email = Console.ReadLine();
            Console.WriteLine("กรอกรหัสผ่านของคุณ");
            password = Console.ReadLine();
        }
        return new College_student(gender,name,surname,student_Id,age,food_allergies,religion,email,password);
    }
    public static Student_school set_already_school_student(int gender,string name,string surname,int age,int class_level,string food_allergies,int religion,string school_name){
        return new Student_school(gender,name,surname,age,class_level,food_allergies,religion,school_name);
    }
    public static Student_school create_new_register_student_school(){          
        Console.Write("คำนำหน้า :");      
        Console.Write("นาย(1) นาง(2) นางสาว(3)"); 
        int gender = int.Parse(Console.ReadLine());
        Console.Write("ชื่อ : ");
        string name = Console.ReadLine();
        Console.Write("นามสกุล :");
        string surname = Console.ReadLine();
        Console.Write("อายุ : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("ระดับชั้นการศึกษา : ");
        int class_level = int.Parse(Console.ReadLine());
        Console.Write("อาหารที่แพ้ : ");
        string food_allergies = Console.ReadLine();
        Console.Write("ศาสนา : ");
        int religion = int.Parse(Console.ReadLine());
        Console.Write("โรงเรียน : ");
        string school_name = Console.ReadLine();
        return new Student_school(gender,name,surname,age,class_level,food_allergies,religion,school_name);
    }
    public static Teacher_college set_already_teacher_college(int gender,string name,string surname,int age,int personnel_status,string food_allergies,int religion,string car_status,string car_number,string email,string password){
        return new Teacher_college(gender,name,surname,age,personnel_status,food_allergies,religion,car_status,car_number,email,password);
    }
    public static Teacher_college create_new_register_teacher_college(){       
        Console.Write("คำนำหน้า :");
        Console.Write("นาย(1) นาง(2) นางสาว(3)");
        int gender = int.Parse(Console.ReadLine());
        Console.Write("ชื่อ : ");
        string name = Console.ReadLine();
        Console.Write("นามสกุล :");
        string surname = Console.ReadLine();
        Console.Write("อายุ : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("ตำแหน่ง : ");
        int personnel_status = int.Parse(Console.ReadLine());
        Console.Write("อาหารที่แพ้ : ");
        string food_allergies = Console.ReadLine();
        Console.Write("ศาสนา : ");
        int religion = int.Parse(Console.ReadLine());
        Console.Write("มีรถหรือไม่ : ");
        string car_status = Console.ReadLine();
        string car_number = "";
        if (car_status == "have"){
            Console.Write("ทะเบียนรถ : ");
            car_number = Console.ReadLine();
        }
        Console.WriteLine("หากเป็นผู้ดูแลระบบให้ใส่ yes : ");
        string email_check = Console.ReadLine();
        string email="",password="";
        if (email_check == "yes"){
            Console.WriteLine("กรอกอีเมลล์ของคุณ");
            email = Console.ReadLine();
            Console.WriteLine("กรอกรหัสผ่านของคุณ");
            password = Console.ReadLine();
        }
        return new Teacher_college(gender,name,surname,age,personnel_status,food_allergies,religion,car_status,car_number,email,password);
    }
    public static void Main(){
        List<Person> all_person = new List<Person>();
        List<College_student> college_students = new List<College_student>();
        List<Student_school> student_schools = new List<Student_school>();
        List<Teacher_college> teachers = new List<Teacher_college>();
        college_students.Add(new College_student(2,"Laula","Croft",65,18,"beaver",2,"lala@mail.com","lala5555"));
        college_students.Add(new College_student(1,"Lala","Craft",21,19,"aoka",1,"",""));
        student_schools.Add(new Student_school(2,"prapa","porn",16,4,"veget",3,"wisut"));
        student_schools.Add(new Student_school(1,"napon","makmai",17,6,"kanom",3,"siwit"));
        teachers.Add(new Teacher_college(1,"จิรนันท์","หัวปักโคลน",19,1,"ข้าว",1,"have","79586","jira@mail.com","jira999"));
        teachers.Add(new Teacher_college(2,"papapa","waipaw",20,2,"nam",2,"no","","papa@mail.com","waipaw777"));
        Statistic statistic = create_statistic(all_person,college_students,student_schools,teachers);
        menu_open(all_person,college_students,student_schools,teachers,statistic);
    }
    
    static void register_menu_open(List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,Statistic statistic){
        Console.WriteLine("**********************************");
        Console.WriteLine("นักศึกษา(1) : นักเรียน(2) : อาจารย์(3)");
        Console.Write("กรุณากรอกประเภท : ");
        Register_menu regis = new Register_menu();
        regis.set_person_Type = int.Parse(Console.ReadLine());
        Console.WriteLine("**********************************");
        int registype = regis.get_person_type_check();
        register_choose_input(college_students,student_schools,teachers,registype);
        add_person(all_person,college_students,student_schools,teachers,registype,statistic);
    }
    static void register_last_index_put(List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,int registype,int count_college_student,int count_school_student,int count_college_teacher,Statistic statistic){
        int gender_check; string name_check,surname_check,email_check;
        if (registype == 1) {
            int list_count = college_students.Count;
            gender_check = college_students[list_count-1].get_number_gender();
            name_check = college_students[list_count-1].get_name();
            surname_check = college_students[list_count-1].get_surname();
            email_check = college_students[list_count-1].get_email();
            int type_check = 1;
            int name_count_use = count_college_student-1;
            int mail_count_use = count_college_student-1;
            register_check(all_person,gender_check,name_check,surname_check,college_students,student_schools,teachers,registype,count_college_student,count_school_student,count_college_teacher,name_count_use,mail_count_use,email_check,type_check,statistic);
        }
        else if (registype == 2){
            int list_count = student_schools.Count;
            gender_check = student_schools[list_count-1].get_number_gender();
            name_check = student_schools[list_count-1].get_name();
            surname_check = student_schools[list_count-1].get_surname();
            Console.WriteLine(name_check);
            email_check = "";
            int type_check = 2;
            int name_count_use = count_college_student+count_school_student-1;
            int mail_count_use = 0;
            register_check(all_person,gender_check,name_check,surname_check,college_students,student_schools,teachers,registype,count_college_student,count_school_student,count_college_teacher,name_count_use,mail_count_use,email_check,type_check,statistic);
        }
        else if (registype == 3){
            int list_count = teachers.Count;
            gender_check = teachers[list_count-1].get_number_gender();
            name_check = teachers[list_count-1].get_name();
            surname_check = teachers[list_count-1].get_surname();
            email_check = teachers[list_count-1].get_email();
            Console.WriteLine(name_check);
            int type_check = 3;
            int name_count_use = count_college_student+count_school_student+count_college_teacher-1;
            int mail_count_use = count_college_teacher-1;
            register_check(all_person,gender_check,name_check,surname_check,college_students,student_schools,teachers,registype,count_college_student,count_school_student,count_college_teacher,name_count_use,mail_count_use,email_check,type_check,statistic);
        }
    }
    static void register_choose_input(List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,int registype){
        if (registype ==1){
        college_students.Add(create_new_register_college_student());
        }
        else if (registype ==2){
        student_schools.Add(create_new_register_student_school());
        }
        else if (registype ==3){
        teachers.Add(create_new_register_teacher_college());
        }
    }

    
    static void register_check (List<Person> all_person,int gender_check,string name_check, string surname_check,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,int registype,int count_college_student,int count_school_student,int count_college_teacher,int name_count_use,int mail_count_use,string email_check,int type_check,Statistic statistic){
        int i = 0;
        foreach (Person stu in all_person){
            if (i == name_count_use)continue;
            if(stu.get_number_gender()==gender_check&&stu.get_name()==name_check&&stu.get_surname()==surname_check){ 
                Console.WriteLine("User is already registered. Please try again.");
                if (type_check == 1){
                    college_students.RemoveAt(count_college_student-1);
                }
                else if (type_check == 2){
                    student_schools.RemoveAt(count_school_student-1);
                }
                else teachers.RemoveAt(count_college_teacher-1);
                register_choose_input(college_students,student_schools,teachers,registype);
                add_person(all_person,college_students,student_schools,teachers,registype,statistic);
                }
            i+=1;
            }
        i = 0;
        foreach (College_student stu in college_students){
            if (i == mail_count_use)continue;
            if(stu.get_email().Equals(email_check)){   
                Console.WriteLine("Invalid email. Please try again.");
                college_students.RemoveAt(count_college_student-1);
                register_choose_input(college_students,student_schools,teachers,registype);
                add_person(all_person,college_students,student_schools,teachers,registype,statistic);
                }
            i+=1;
            }
        i = 0;
        foreach (Teacher_college stu in teachers){
            if (i == mail_count_use)continue;
            if(stu.get_email().Equals(email_check)){   
                Console.WriteLine("Invalid email. Please try again.");
                college_students.RemoveAt(count_college_teacher-1);
                register_choose_input(college_students,student_schools,teachers,registype);
                add_person(all_person,college_students,student_schools,teachers,registype,statistic);
                }
            i+=1;
            }
        menu_open(all_person,college_students,student_schools,teachers,statistic);
    }
    static void add_person(List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,int registype,Statistic statistic){
        foreach (College_student stu in college_students){
            all_person.Add(new Person(stu.get_number_gender(),stu.get_name(),stu.get_surname(),stu.get_age(),stu.get_food_allergies(),stu.get_number_religion()));
        }
        int count_college_student = college_students.Count();
        foreach (Student_school stu in student_schools){
            all_person.Add(new Person(stu.get_number_gender(),stu.get_name(),stu.get_surname(),stu.get_age(),stu.get_food_allergies(),stu.get_number_religion()));
        }
        int count_school_student = student_schools.Count();
        foreach (Teacher_college stu in teachers){
            all_person.Add(new Person(stu.get_number_gender(),stu.get_name(),stu.get_surname(),stu.get_age(),stu.get_food_allergies(),stu.get_number_religion()));
        }
        int count_college_teacher = student_schools.Count();
        register_last_index_put(all_person,college_students,student_schools,teachers,registype,count_college_student,count_school_student,count_college_teacher,statistic);
    }

    static void menu_choose_check(Main_menu menu,List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,Statistic statistic){
        if (menu.get_open_register_event() == true){
            register_menu_open(all_person,college_students,student_schools,teachers,statistic);
        }
        else if (menu.get_open_stats_event() == true){
            static_first_print(statistic,all_person,college_students,student_schools,teachers);
        }
        else if (menu.get_open_login_event() == true) {
            login_menu_open(all_person,college_students,student_schools,teachers,statistic);
        }     
    }
    static void menu_open(List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,Statistic statistic){
        Console.WriteLine("**********************************");
        Console.WriteLine("กรอก 1 เพื่อเปิดหน้า ลงทะเบียนเข้าร่วมงาน");
        Console.WriteLine("กรอก 2 เพื่อเปิดหน้า สถิติผู้เข้าร่วมงาน");
        Console.WriteLine("กรอก 3 เพื่อเปิดหน้า เข้าสู่ระบบ");
        Console.WriteLine("**********************************");
        Main_menu menu = new Main_menu();
        menu.Main_Menu_Check = int.Parse(Console.ReadLine());
        menu.Main_Menu_Choose_check();
        bool register_menu = menu.get_open_register_event();
        bool stats_menu = menu.get_open_stats_event();
        bool login_menu = menu.get_open_login_event();
        if (register_menu == true){
            Console.WriteLine("This is register menu");
            menu_choose_check(menu,all_person,college_students,student_schools,teachers,statistic);
        }
        else if (stats_menu == true){
            Console.WriteLine("This is stats menu");
            menu_choose_check(menu,all_person,college_students,student_schools,teachers,statistic);

        }
        else if (login_menu == true){
            Console.WriteLine("This is login menu");
            menu_choose_check(menu,all_person,college_students,student_schools,teachers,statistic);
        }
        else {
            Console.WriteLine("Invalid Menu Please Try Again");
            menu_open(all_person,college_students,student_schools,teachers,statistic);
        }
    }
    static void register_menu_print(int registype){
        if (registype == 1){
            Console.WriteLine("ประเภทของคุณคือ นักศึกษาปัจจุบัน");
        }
        else if (registype == 2){
            Console.WriteLine("ประเภทของคุณคือ นักเรียน");
        }
        else if (registype == 3){
            Console.WriteLine("ประเภทของคุณคือ อาจารย์");
        }
        else {
            throw new Exception("ไม่มีประเภทผู้เข้าร่วมงานนี้โปรดกรอกใหม่อีกครั้ง");
        }
    }

    static Login Createnew_login(){
        Console.WriteLine("กรุณากรอกอีเมลล์ของคุณ");
        string email = Console.ReadLine();
        Console.WriteLine("กรุณากรอกพาสเวิร์ด");
        string password = Console.ReadLine();
        return new Login(email,password);
    }
    static void login_menu_open(List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,Statistic statistic){
        Login login_inf = Createnew_login();
        login_check(all_person,college_students,student_schools,login_inf,teachers,statistic);
        menu_open(all_person,college_students,student_schools,teachers,statistic);
    }

    static void login_check(List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,Login login_inf,List<Teacher_college> teachers,Statistic statistic){
        if (login_inf.get_email() == "exit"){
            menu_open(all_person,college_students,student_schools,teachers,statistic);
        }
        else;
        foreach(College_student stu in college_students){
            if (login_inf.get_email()==stu.get_email()&&login_inf.get_password()==stu.get_password()) {
                Console.WriteLine("Login in success");
                open_login_menu(statistic,all_person,college_students,student_schools,teachers);
            }
        }
        foreach(Teacher_college stu in teachers){
            if (login_inf.get_email()==stu.get_email()&&login_inf.get_password()==stu.get_password()) {
                Console.WriteLine("Login in success");
                open_login_menu(statistic,all_person,college_students,student_schools,teachers);
            }
        }
    Console.WriteLine("Incorrect email or password. Please try again.");
        login_menu_open(all_person,college_students,student_schools,teachers,statistic);
    }
    
    static Statistic create_statistic(List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers){
        int four=0,five=0,six=0;
        foreach(Student_school stu in student_schools){
            if(stu.get_class_level() == 4){
                four +=1;
            }
            else if(stu.get_class_level() == 5){
                five +=1;
            }
            else if(stu.get_class_level() == 5){
                six +=1;
            }
        }
        return new Statistic(all_person.Count,college_students.Count,teachers.Count,student_schools.Count,four,five,six);
    }
    static void static_first_print(Statistic statistic,List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers){
        Console.WriteLine("*************************");
        Console.Write("จำนวนอาจารย์ที่ลงทะเบียนทั้งหมด : ");
        Console.WriteLine(statistic.get_count_teacher());
        Console.Write("จำนวนนักเรียนที่ลงทะเบียนทั้งหมด : ");
        Console.WriteLine(statistic.get_count_student());
        Console.Write("จำนวนนักศึกษาปัจจุบันที่ลงทะเบียนทั้งหมด : ");
        Console.WriteLine(statistic.get_count_college_student());
        Console.Write("จำนวนนักเรียนเฉพาะระดับชั้นมัธยมศึกษาปีที่ 4 ที่ลงทะเบียนทั้งหมด : ");
        Console.WriteLine(statistic.get_count_mat4());
        Console.Write("จำนวนนักเรียนเฉพาะระดับชั้นมัธยมศึกษาปีที่ 5 ที่ลงทะเบียนทั้งหมด : ");
        Console.WriteLine(statistic.get_count_mat5());
        Console.Write("จำนวนนักเรียนเฉพาะระดับชั้นมัธยมศึกษาปีที่ 6 ที่ลงทะเบียนทั้งหมด : ");
        Console.WriteLine(statistic.get_count_mat6());
        Console.WriteLine("*************************");
        Console.WriteLine("กดเพื่อไปต่อ");
        Console.ReadLine();
        menu_open(all_person,college_students,student_schools,teachers,statistic);
    }
    static void college_student_print(Statistic statistic,List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers){
        Console.WriteLine("นักศึกษาปัจจุบันที่เข้าร่วมคือ");
        Console.WriteLine("****************************");
        foreach(College_student stu in college_students){
            Console.WriteLine(stu.get_gender()+stu.get_name()+stu.get_surname());
        }
        Console.WriteLine("****************************");
        Console.WriteLine("กดเพื่อไปต่อ");
        Console.Read();
        menu_open(all_person,college_students,student_schools,teachers,statistic);
    }
    static void school_student_print(Statistic statistic,List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers){
        Console.WriteLine("รักเรียนปัจจุบัทที่เข้าร่วมคือ");
        Console.WriteLine("****************************");
        foreach(Student_school stu in student_schools){
            Console.WriteLine(stu.get_gender()+stu.get_name()+stu.get_surname());
        }
        Console.WriteLine("****************************");
        Console.WriteLine("กดเพื่อไปต่อ");
        Console.Read();
        menu_open(all_person,college_students,student_schools,teachers,statistic);
    }
    static void college_teacher_print(Statistic statistic,List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers){
        Console.WriteLine("อาจารย์ที่เข้าร่วมปัจจุบันคือ");
        Console.WriteLine("****************************");
        foreach(Teacher_college stu in teachers){
            Console.WriteLine(stu.get_gender()+stu.get_name()+stu.get_surname());
        }
        Console.WriteLine("****************************");
        Console.WriteLine("กดเพื่อไปต่อ");
        Console.Read();
        menu_open(all_person,college_students,student_schools,teachers,statistic);
    }

    static void open_login_menu(Statistic statistic,List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers){
        In_login num_log = new In_login();
        Console.WriteLine("****************************");
        Console.WriteLine("กรอก 1 เพื่อลงทะเบียนเข้าร่วมงาน");
        Console.WriteLine("กรอก 2 แสดงข้อมูลนักศึกษาปัจจุบันที่เข้าร่วมโครงการทั้งหมด");
        Console.WriteLine("กรอก 3 แสดงข้อมูลนักเรียนที่เข้าร่วมโครงการทั้งหมด");
        Console.WriteLine("กรอก 4 แสดงข้อมูลอาจารย์ที่เข้าร่วมโครงการทั้งหมด");
        Console.WriteLine("กรอก 5 ออกจากระบบ");
        Console.WriteLine("****************************");
        num_log.set_show_login_type = int.Parse(Console.ReadLine());
        already_login_menu_open(statistic,all_person,college_students,student_schools,teachers,num_log);
    }
    static void already_login_menu_open(Statistic statistic,List<Person> all_person,List<College_student> college_students,List<Student_school> student_schools,List<Teacher_college> teachers,In_login num_log){
        if (num_log.get_check_type()==1){
            register_menu_open(all_person,college_students,student_schools,teachers,statistic);
        }
        else if (num_log.get_check_type()==2){
            college_student_print(statistic,all_person,college_students,student_schools,teachers);
        }
        else if (num_log.get_check_type()==3){
            college_student_print(statistic,all_person,college_students,student_schools,teachers);
        }
        else if (num_log.get_check_type()==4){
            college_teacher_print(statistic,all_person,college_students,student_schools,teachers);
        }
        else if (num_log.get_check_type()==5){
            menu_open(all_person,college_students,student_schools,teachers,statistic);
        }
    }
}




