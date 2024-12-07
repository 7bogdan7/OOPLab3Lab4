
#include <iostream>
#include "faculty.hpp"
#include "students.hpp"
#include "util_funcs.hpp"

int main()
{
    Faculty faculties[5] = {
        Faculty("Inginerie meacnica, industriala si transporturi", "IMIT", "MECHANICAL_ENGINEER"),
        Faculty("Calculatoare informatica si microelectronica", "CIM", "SOFTWARE_ENGINEERING"),
        Faculty("Inginerie si management in industria alimentara", "TA", "FOOD_TECHNOLOGY"),
        Faculty("Planificare urbana si regionala", "UA", "URBANISM_ARCHITECTURE"),
        Faculty("Medecina veterinara", "MV", "VETERINARY_MEDICINE")
    };

    int choice1 = 1;
    int choice2 = 1;
    int faculty_choice;

    while (choice1 != 0)
    {
        std::cout << "<<<<<<<<<<<<< ************* >>>>>>>>>>>>> " << std::endl;
        std::cout << "************* ************* ************* " << std::endl;
        std::cout << "choose a number to work with:"              << std::endl;
        std::cout << "0. MECHANICAL_ENGINEER"                     << std::endl;
        std::cout << "1. SOFTWARE_ENGINEERING"                    << std::endl;
        std::cout << "2. FOOD_TECHNOLOGY"                         << std::endl;
        std::cout << "3. URBANISM_ARCHITECTURE"                   << std::endl;
        std::cout << "4. VETERINARY_MEDICINE"                     << std::endl;
        std::cout << "5. Exit"                                    << std::endl;
        std::cout << "************* ************* ************* " << std::endl;
        std::cout << "<<<<<<<<<<<<< ************* >>>>>>>>>>>>> " << std::endl;
        std::cin >> faculty_choice;
        
        if (faculty_choice == 5)
            exit(0);

        Show_menu();
        std::cin >> choice2;
        std::cin.ignore();
        switch (choice2)
        {
        case 1:
            faculties[faculty_choice].add_student();
            break;

        case 2:
            faculties[faculty_choice].graduate_student();
            break;

        case 3:
            faculties[faculty_choice].display_all_enrolled_students();
            break;

        case 4:
            faculties[faculty_choice].display_all_graduates();
            break;

        case 5:
            faculties[faculty_choice].verify_students_adherence();
            break;

        case 0:
            exit(0);
            break;

        default:
            std::cout << "Wrong number." << std::endl;
            break;
        }
    }

    return 0;
}



