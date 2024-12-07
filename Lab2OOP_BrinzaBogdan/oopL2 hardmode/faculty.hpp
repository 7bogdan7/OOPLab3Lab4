
#include <iostream>
#include "students.hpp"
#include <string>
#include <list>

enum study_field { MECHANICAL_ENGINEER = 0, SOFTWARE_ENGINEERING = 1, FOOD_TECHNOLOGY = 2,
                   URBANISM_ARCHITECTURE = 3, VETERINARY_MEDICINE = 4 };

class Faculty
{
public:
    std::string faculty_name;
    std::string faclt_abreviation;
    std::string study_field;
    std::list<Students> students;

    Faculty();
    Faculty(std::string p_faculty_name, std::string p_faclt_abreviation, std::string p_study_field);
    void add_student();
    void show_all_info();
    void graduate_student();
    void display_all_graduates();
    void display_all_enrolled_students();
    void verify_students_adherence();
    void display_all_faculties();
};
