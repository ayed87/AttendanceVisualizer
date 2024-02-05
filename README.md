
# **Problem Description Introduction** 
The HR department at xyzSoft is responsible for all processes related to employees in the company. The company has many gates that can be accesses by cards. Every entry and exit of all employees are logged in a huge log file. The logfile itself is simple in its format consisting of 4 main items: 

    1. Employee ID 
    1. Date
    1. Time-In (the first time the employee entered the company)
    1. Time-Out (the last time the employee exited from one of the gates)

The problem is that this log file is huge (around 50,000 lines for 700+ employees in a 3-months period). The data are stored inside an Excel File the client would like to keep it there so that they can add extra data later. 
1. ## **What is required?**
You are required write a program that visualizes the attendance data by allowing HR and department managers to view their employees. Currently what we would like to do is to have the list of employees in a list. Once the user clicks on one of the employees, it should show a visualization of their attendance in the entire period (3 months)
. 
# **Task 1: Class Diagram**
The problem is not that difficult. You might end up with few class. However, remember that you are a “Designer” not only a programmer! You have to approach this problem having in mind that the requirements might get bigger (remember, you have 2 extra homeworks). Develop a class diagram that reflects this structure and make sure to follow the main principles we discussed in the class including:

- Abstraction and Encapsulation
- Single Responsibility Principle
- Open-Closed Principle

You have to include all fields and methods in every class with proper access modifiers (private, public, etc.). If the relation between two classes is an association, specify the multiplicity, label and direction of the relationship. Make sure that your class diagram represents all needed components in this system.
# **Task 2: Develop the application**
Develop your program to fulfill the following requirements: 

1. When executed, it should parse the Excel file reading all of its contents.
1. You should construct Employee objects and Attendance objects separately. 
1. The list of Employees should be presented in the program in a listbox
   1. Currently you only have employees ID’s. This might change later.
1. When you click one of the employees in the list, you should visualize his/her attendance as shown in the following picture (This is only a sketch and you are welcome to enhance it according to your understanding of this domain) 
# **Visualization Specification (See the picture below)**
