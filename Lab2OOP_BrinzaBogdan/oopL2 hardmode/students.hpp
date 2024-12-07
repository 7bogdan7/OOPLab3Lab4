#include <iostream>
#include <string>
#include <list>
#ifndef STUDENTS     
#define STUDENTS    

class Students
{
public:
    std::string first_name{"no data"};
    std::string last_name{"no data"};
    std::string email{"no data"};
    std::string date_of_birth{"no data"};
    int study_year{0};

    static Students create_student()
    {
        Students new_student;
        std::cout << "Write first name:" << std::endl;
        getline(std::cin, new_student.first_name);
        std::cout << "Write last name:" << std::endl;
        getline(std::cin, new_student.last_name);
        std::cout << "Write email:" << std::endl;
        getline(std::cin, new_student.email);
        std::cout << "Write date of birth(DD/MM/YYYY):" << std::endl;
        getline(std::cin, new_student.date_of_birth);
        new_student.study_year = 1;
        return new_student;
    }
};


#endif