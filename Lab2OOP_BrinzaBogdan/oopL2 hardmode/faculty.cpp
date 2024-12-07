
#include "faculty.hpp"

Faculty::Faculty() {}

Faculty::Faculty(std::string p_faculty_name, std::string p_faclt_abreviation, std::string p_study_field)
{
    faculty_name = p_faculty_name;
    faclt_abreviation = p_faclt_abreviation;
    study_field = p_study_field;
}

void Faculty::add_student()
{
    Students new_student = Students().create_student();  
    students.push_back(new_student);                      
}
void Faculty::show_all_info()
{
    std::cout << "Faculty: " << faculty_name << ", " << faclt_abreviation << ", Study Field: " << study_field << std::endl;
}

void Faculty::graduate_student()
{
    std::string students_email;
    std::cout << "Write student's email" << std::endl;
    std::cin >> students_email;
    for (auto iter = students.begin(); iter != students.end(); ++iter)
    {
        if (iter->email == students_email)
        {
            iter->study_year += 1;
            std::cout << "Student: " << iter->first_name << " " << iter->last_name << " is now year " << iter->study_year << std::endl;
            break;
        }
    }
}

void Faculty::display_all_graduates()
{
    std::cout << "Graduates students of " << faculty_name << std::endl;
    for (auto iter = students.begin(); iter != students.end(); ++iter)
    {
        if (iter->study_year >= 4)
        {
            std::cout << iter->first_name << " " << iter->last_name << " - year " << iter->study_year;
            std::cout << " email: " << iter->email << " date of birth: " << iter->date_of_birth << std::endl;
        }
    }
}

void Faculty::display_all_enrolled_students()
{
    std::cout << "Enrolled students of (" << faculty_name << ")" << std::endl;
    for (auto iter = students.begin(); iter != students.end(); ++iter)
    {
        if (iter->study_year < 4)
        {
            std::cout << iter->first_name << " " << iter->last_name << " - year " << iter->study_year;
            std::cout << " email: " << iter->email << " date of birth: " << iter->date_of_birth << std::endl;
        }
    }
}

void Faculty::verify_students_adherence()
{
    std::string email;
    std::cout << "Enter student's email" << std::endl;
    std::cin >> email;
    for (auto iter = students.begin(); iter != students.end(); ++iter)
    {
        if (iter->email == email)
        {
            std::cout << "Student: " << iter->first_name << " " << iter->last_name << " - year " << iter->study_year;
            std::cout << " belongs to " << faclt_abreviation << std::endl;
            return;
        }
    }
    std::cout << "Such student doesn't exist" << std::endl;
}

void Faculty::display_all_faculties()
{
    std::cout << "All faculties available:" << std::endl;
    std::cout << "1. " << faculty_name << " (" << faclt_abreviation << ")" << std::endl;
}
