#include <iostream>
#include "util_funcs.hpp"
void Show_menu()
{
    std::cout << "Choose one option:" << std::endl;
    std::cout << "1.Add a student to a faculty" << std::endl;
    std::cout << "2.Graduate a student from a faculty" << std::endl;
    std::cout << "3.Display all enrolled students" << std::endl;
    std::cout << "4.Display graduates" << std::endl;
    std::cout << "5.Verify belonging of a student" << std::endl;
    std::cout << "0.Exit" << std::endl;
}