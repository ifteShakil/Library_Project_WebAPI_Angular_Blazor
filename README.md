
A Project Documentation
						on 
Library Management System


SUBMITTED TO
Sayed Zahidul Hassan	
Consultant (.NET),
Show & Tell Consulting Ltd.

Supervised By
Md. Foysal Wahid
Trainer, New Vision Information Technology Ltd. (NVIT)

SUBMITTED BY

ID
NAME
1272311
Sayed Minhajur Rahman (Leader)
1272015
Jahidul Islam
1271633
Iftekhar Ahmed
1272262
Tanvir Ehsan Bhuiyan
1271556
Mohammed Yousof
1271801
Md. Gias Uddin

INTRODUCTION

In the dynamic landscape of modern libraries, the pursuit of efficient management and seamless user experiences is paramount. Our project embarks on a journey to craft a sophisticated Library Management System, leveraging the latest technologies to revolutionize the way libraries operate. By weaving together, the power of ASP.NET Core Web API, JWT authentication, Angular and Blazor front-end, and comprehensive functionalities, our system aims to create a cohesive and user-centric environment that meets the diverse needs of both librarians and patrons.
The heart of this endeavor lies in the creation of a Login/Register Component, providing a secure gateway for users to access the system. With JWT Authentication at its core, we ensure that interactions within the system remain confidential and authorized, instilling trust and safeguarding sensitive data.
In the spirit of transparency and efficiency, the All-Requests feature offers a comprehensive view of all transactions, enabling librarians to manage and optimize resource allocation. To uphold responsibility, our system introduces Return Book, simplifying the return process and minimizing complexities for users.
The Library Management System extends its capabilities to empower librarians with crucial tools. Users List offers a comprehensive view of patrons, enhancing administrative capabilities. Fine Calculation automates the process of tracking and assessing fines, ensuring fairness and accuracy.
In line with the role-based nature of library operations, the system introduces functions to Block/Unblock/Enable/Disable users, providing librarians with granular control over system access. To enrich the library's offerings, the ability to Insert/Delete Books and Insert Categories amplifies the breadth of accessible materials.

Objectives
The primary objectives of the Library Management System project are as follows:
Provide a user-friendly interface for library patrons to interact with the library's resources.
Enable users to search for books, view book details, and borrow books.
Facilitate the borrowing and return of books, while calculating fines for overdue items.
Implement a secure login and registration process using JWT authentication.
Provide token-based authentication and role-based authorization for users and administrators.
Allow administrators to manage books, users, categories, and borrow requests.
Implement a book inspection feature to check returned books before they are returned to the shelf.
If any issues are found during inspection, remove the book from the shelf and list it for repair.
Allow users to request the addition of new books to the library's collection.
 Incorporate reporting capabilities using HTML
Scopes:
The proposed Library Management System will consist of the following components:

Login / Register Component:
Secure user registration and authentication mechanisms using JWT.
User-friendly login and registration interfaces.
WebAPI Project:
Develop a robust ASP.NET Core WebAPI backend to handle various operations.
Implement RESTful endpoints for communication between frontend and backend.
JWT Authentication:
Implement JWT-based authentication for secure access to the system.
Generate and validate tokens to ensure authorized access. 
Subscription Plans: 
Offer subscription-based plans for users to access premium services and features. There will be packages based on users need; and the admin can create, edit and modify packages. 
View Books:
Display a list of available books along with relevant details.
Allow users to search, sort, and filter books based on different criteria.
Borrow Book:
Enable users to place request for available books.
Implement an intuitive interface for selecting and confirming request.
My Borrowed Books:
Provide users with a section to view their current and past request.
Allow users to track the status of their orders.
All Borrow Requests:
Admin users can access a dashboard to view and manage all request.
Implement filters and sorting options for efficient order management.
Return Book:
Allow users to initiate book returns and manage return requests.
Provide a streamlined process for handling returned books.
Book Inspection: Books are received and returned to shelf after inspecting.
Admin can change book condition.
Users List:
Admin can access a list of registered users.
Implement user management features such as search and user status updates.
Fine Calculation:
Automatically calculate fines for overdue books. Fine will be based on users’ types (subscribed or normal).
Notify users about pending fines and provide a mechanism to clear them.
Block/Unblock/Enable/Disable:
Admin can manage user accounts by blocking, unblocking, enabling, or disabling them.
Implement secure account management features.
Insert/Remove Book:
Admin can add new books to the system and remove existing ones.
Implement proper validation and verification for book management.
Cataloging: 
Admin can manage book categories, subcategories and genres.
Allow easy addition and removal of book categories.
Profile Component:
Provide users with the ability to view and update their profiles.
Allow users to manage their personal information.
Shelf and Rack: 
Manage the physical arrangement of books within the library. To manage this DDC (Dewey Decimal Classification; most widely used classification system in the world for library management) will be used.
Book Serial No., ISBN No., Author, Publisher: 
Maintain detailed information about each book.
Book Borrow Info: 
Track the borrowing history of each book.
Online Reading Facility: 
Provide users with the ability to read books online. There will be restrictions on downloading books to prevent piracy. Users will have limited access to read books online and books will be loaded single page. Reading session will be available for users to continue their reading after logging out. Permission of pdf and agreement with publisher will be shown in book details.
Request New Book:
Allow users to request the addition of new books to the library's collection.
List for Repair: If issues are found, provide administrators with the ability to list the book for repair.
Report: Admin can see detailed report and analytics on books borrowed, fines and other important business information in his dashboard. Registered users can see their information about what books they’ve read, how many books they’ve read, due dates and fines etc. relevant information. To interest new users there will be report on most read books, reviews on books, etc.
Feedback: Users can give review and rate books and mark favorite books on their wish-list to facilitate reading experience.

Technology Stack

Backend: ASP.NET 6.0 Web API 
Frontend: Angular (16.1.6), Blazor, MAUI
Database: Microsoft SQL Server (15.0.2000.5)
Authentication: JWT (JSON Web Tokens)
Reporting: HTML reporting. 
IDE: Visual Studio 2022, VS CODE, SSMS 2018
Programming Languages: C# (Version 10), TypeScript, HTML 5, CSS 3, Bootstrap
Tools: Postman and Swagger (API testing) 


Methodology
Software development life cycle provides the overview and procedures to develop software. For our “Online Library Management”, the life cycle is given below-At first stage of SDLC we have to measure feasibility study of our proposed system that is system feasibility study of economics, implementation etc. 

Requirements Analysis: The existing system is evaluated. Deficiencies are identified. This can be done by interviewing users of the system and consulting with support personnel. The new system requirements are defined. In particular, the deficiencies in the existing system must be addressed with specific proposals for improvement. Other factors defined include needed features, functions.
Design: The proposed system is designed. Plans are laid out concerning the physical construction, hardware, operating systems, programming, communications and security issues.
Development: The new system is developed. The new components and programs must be obtained and installed. Users of the system must be trained in its use.
Testing: All aspects of performance must be tested. If necessary, adjustments must be made at this stage. Tests performed by quality assurance (QA) teams may include systems integration and system testing.
Maintenance: This step involves changing and updating the system once it is in place. Hardware or software may need to be upgraded, replaced or changed in some way to better fit the needs of the end-users continuously. Users of the system should be kept up-to-date concerning the latest modifications and procedures.


User Interface using Angular
Landing Page: In this project user visit this site for borrow their required book. They search book by author, category, publication.
User Registration Page 
User Login Page
Book Details: After Login If user want to know about the book, they can see the book details and send borrow request.
User Profile: When user request a book the requested book list shown in user profile.
Subscription Plan:
Admin Dashboard Interface Using Blazor
Admin Landing page: 
Admin Login Page:
Admin Dashboard: After login admin.
Book Category:
Category Form:
Sub-Category: 
Publisher :
Author :
Book List :
Book Copy :
Book Floor:
Book Shelf:
Subscription Plan:
Subscription User ID:
After confirm borrow request
Borrow Request List: when user send a borrow request the list will shown here. 
Invoice List: 
Report Viewer:
Print Report:

CONCLUSION
This internet-based application is designed to cater to all levels of management by providing comprehensive organizational information. It serves as an effective information management system for the Library.
The Library management system's key functionality includes generating book lend statistics for any given period, encompassing details such as book name, publisher, ISBN number, number of copies borrowed.
When a patrons requests a book that is not currently available in the Library , the system prompts the patrons to enter the full details of the requested book for procurement. If the requested book is in stock, the system displays the exact number of available copies and the rack number where the book is located. Conversely, if the book is not in stock, the system increments a request field for that book.
In the proposed system, once a patrons selects a book to borrow, the librarian enters the ISBN number of the book. The Library management system then updates the stock and generates a invoice for the selected book. This streamlined process ensures efficient book procurement, book keeping management, and tracking for the Library.

