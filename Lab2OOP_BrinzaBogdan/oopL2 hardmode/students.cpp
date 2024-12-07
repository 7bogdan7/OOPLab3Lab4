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

    Students create_student();
};

#endif
