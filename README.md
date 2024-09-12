# Badminton Court Management System
## 1. Introduction
The Badminton Court Management System is a web-based application designed to manage the scheduling and booking of badminton courts. This system provides functionalities for users to book courts, manage court availability, and track bookings. It aims to streamline the process for both the court administrators and players, making it easier to reserve and manage court time.

## 2. Features
Manage court schedules and availability.
Book badminton courts for specific time slots.
Track and update booking information.
Admin panel for managing court data and user bookings.
Provide real-time updates on court availability.
## 3. Technologies Used
This project is developed using the following technologies:

Back-end: C# with .NET Framework
Front-end: HTML, CSS, JavaScript
Database: SQL Server
Project Management: Visual Studio
## 4. Installation
To run this project locally, please follow the instructions below:

### 4.1. System Requirements
Visual Studio 2019 or higher
SQL Server for database management
.NET Framework 4.7.2 or higher
### 4.2. Setup Instructions
#### Clone the repository:

git clone https://github.com/trieutien0804/LTCSDL_Project_QuanLySanCauLong.git
#### Set up the database:

Create a new SQL Server database named BadmintonCourtDB.

Update the connection string in the appsettings.json file:

"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=BadmintonCourtDB;Trusted_Connection=True;"
}
#### Build and run the project:

Open the project in Visual Studio.
Build the solution to restore all dependencies.
Run the project by pressing Ctrl + F5 to start the server.
#### Access the application:

After the project is running, open your browser and navigate to:

http://localhost:5000
## 5. Usage
Users can browse available courts and book a time slot for their game.
Admins can log in to manage court schedules, monitor user bookings, and update court availability.
The system provides real-time updates on court availability and current bookings.
## 6. Contribution
We welcome contributions to this project! To contribute:

Fork this repository.
Create a new branch from main to work on your changes.
Submit a pull request for review.
## 7. Contact
For any questions or issues regarding this project, feel free to contact the developer via email at: [your email].

