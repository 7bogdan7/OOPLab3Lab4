#include <iostream>
#include <string>
#include <list>

using namespace std;

// 1. Class definitions for Carte and Bibliotecă
class Carte {
private:
    string title;
    string author;
    string isbn;

public:
    // Constructor
    Carte(string t, string a, string i) : title(t), author(a), isbn(i) {}

    // Destructor
    ~Carte() {
        cout << "Carte object destroyed: " << title << endl;
    }

    // Friend function declaration
    friend class Biblioteca;

    // Display method for book details
    void display() const {
        cout << "Title: " << title << ", Author: " << author << ", ISBN: " << isbn << endl;
    }
};

class Biblioteca {
private:
    list<Carte> books;

public:
    // Method to add a book
    void addBook(const Carte& book) {
        books.push_back(book);
        cout << "Book added: " << book.title << endl;
    }

    // Method to remove a book
    void removeBook(const string& isbn) {
        for (auto it = books.begin(); it != books.end(); ++it) {
            if (it->isbn == isbn) {
                cout << "Removing book: " << it->title << endl;
                books.erase(it);
                return;
            }
        }
        cout << "The book with ISBN: " << isbn << " NOT FOUND." << endl;
    }

    // Method to display all books
    void displayBooks() const {
        if (books.empty()) {
            cout << "There are no books in the library." << endl;
            return;
        }
        for (const auto& book : books) {
            book.display();
        }
    }
};

// 2. Demonstrating Inheritance
class DeBaza {
public:
    DeBaza() {
        cout << "DeBaza class constructor called." << endl;
    }
    virtual ~DeBaza() {
        cout << "DeBaza class destructor called." << endl;
    }
};

class DerivataDeLaBaza : public DeBaza {
public:
    DerivataDeLaBaza() {
        cout << "DerivataDeLaBaza class constructor called." << endl;
    }
    ~DerivataDeLaBaza() {
        cout << "DerivataDeLaBaza class destructor called." << endl;
    }
};

// 3. Friend class to demonstrate access
class FriendClass {
public:
    void showLibraryBooks(Biblioteca& lib) {
        cout << "Accessing Library's private data using a friend class:" << endl;
        lib.displayBooks();
    }
};

int main() {
    cout << "Inheritance demonstration:" << endl;
    DerivataDeLaBaza d; 

    Biblioteca lib;
    FriendClass fc;

    int choice;
    string title, author, isbn;

    do {
        cout << "\n------------- Enter a number between 0-4 -------------" << endl;
        cout << "0. ------- Exit ------- " << endl;
        cout << "1. ------- Add a book ------- " << endl;
        cout << "2. ------- Remove a book ------- " << endl;
        cout << "3. ------- Display all books ------- " << endl;
        cout << "4. ------- Display books using a friend class ------- " << endl;
        cout << "------------- Enter a number between 0-4: -------------" << endl;

        cin >> choice;
        cin.ignore();

        switch (choice) {
            case 0:
                cout << "Quitting..." << endl;
                break;
            case 1:
                cout << "Enter a title for the next book: ";
                getline(cin, title);
                cout << "Enter an author for the book: ";
                getline(cin, author);
                cout << "Enter its ISBN: ";
                getline(cin, isbn);
                lib.addBook(Carte(title, author, isbn));
                break;
            case 2:
                cout << "Enter the book's ISBN to remove from the list: ";
                getline(cin, isbn);
                lib.removeBook(isbn);
                break;
            case 3:
                cout << "Displaying the list of books ->" << endl;
                lib.displayBooks();
                break;
            case 4:
                cout << "Displaying books using a friend class ->" << endl;
                fc.showLibraryBooks(lib);
                break;
            default:
                cout << "Enter a number from 0-4." << endl;
                break;
        }

    } while (choice != 0);

    return 0;
}
