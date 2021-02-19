# COMP1690_CW
THIS IS A WORK IN PROGRESS. I am currently working on the 1st of 3 applications in this solution.

This is a multi-application project for a fictitious car-rental company. 
The project includes a desktop application for the car-rental admin members to manage services, a mobile app for the drivers to log into and view/record their journeys, 
and a web API so the mobile app can communicate with a SQL Server database.

This was a coursework assignment given to me during the final year of my undergrad in software engineering.
Due to managing a heavy courseload, I felt that I didn't get to spend as much time working on this project as I wanted to.
Now that I have graduated and can spend more time on projects I decided to start this one from scratch.

The specification as it was given to me is posted below.

--- BACKGROUND ---
You have been approached by a taxi operator called Speedy Taxis. The company has a fleet of taxis which serve all of London and the surrounding area.
The company employs a large number of drivers and has experienced a number of incidents and customer complaints which it is now trying address.
In order to achieve this, it is planning to offer drivers various training courses and qualifications in an attempt to reduce the number of incidents and customer complaints.
A system is planned which would record details of training a driver has attended and what qualification(s) they have obtained.

As some training and qualifications expire, the system should remind users when it is time to renew a training or qualification.

When a driver is involved in an incident, which was caused by unprofessional behavior on part of the driver, then he/she gets a warning and it
is added to his/her disciplinary record. In addition to the training, the system should also keep these disciplinary records about the drivers.

In the long-term Speedy Taxis wants to develop an app which its taxi drivers can install on a mobile phone or tablet. They are envisaging that drivers would use
the app to log the start of their working day, the end of their working day and the start/end of each journey. This would give Speedy Taxis a record of the drivers
working hours and time actually spent driving. There should be a component in the system which accepts the work logs and processes them.
The company is not sure yet what technology to use for the app, so for the prototype of the system, they want the app to simply be implemented as a desktop application,
which would later be replaced with a mobile app. At this stage they are interested in getting sample data, submitting it to component via a web service and
ensuring that the data is processed correctly. The desktop application could then be replaced by the app at a later stage without affecting the system.

Speedy Taxis has a wish list of functionality which it would like to have, but recognises that it is not easy to develop. They would like to have a prediction
component which uses information such as the hours worked, training, qualifications and disciplinary record to calculate a driver’s likelihood of being
involved in an incident. They would also like a dashboard which contains visual components which depict a driver’s likelihood of being involved in an incident and
which could highlight drivers most at risk.

There are strict requirements about the technologies and architecture to beimplemented. These are detailed in the deliverables section.

--- BASIC FUNCTIONALITY ---
The basic functionality should consist of a desktop application which enables an admin user at Speedy Taxis to manage taxi drivers and record
their training and qualifications. The information has to be saved in a database. You can use any relational database management system you
wish (e.g. SQLServer, MySQL, Oracle, Access, etc.). The database should be normalised and use primary key and foreign key constraints.
The desktop application should be created as a Windows Forms Application using C#.

The application needs to provide the following functionality to an admin user:
- Log in
- Add/edit/delete drivers
- Add/edit/delete qualifications
- Add/edit/delete training types
- Schedule sessions for a training type
- Assign drivers to a training session and record the outcome (e.g. training completed successful)
- Search for a driver and see his/her profile including qualifications and training
- See a list of drivers who have qualifications/training expiring within the next 30 days

Currently there are two qualifications which are relevant to the taxi drivers, which are their driving license and geographical tests (there are 5 different
geographical tests: Central London, North London, South London, East London, West London).

Training types which the company is currently offering include: advanced driving course, driving at night, cyclist awareness, reduce fuel consumption.

A driver’s phone number is very important for the company as this is how they inform a driver when they are assigned a journey. To facilitate the
data entry of phone numbers, you should implement a Phone Textbox. Implement a component which inherits from the Textbox control. It should
only allow numbers to be entered. Further, it should display the numbers that are entered into it in red if there are more than 11. The Phone
Textbox component should be integrated into the application so it is used instead of a normal textbox when entering a phone number for a driver.

It must be possible for an admin user to view a list of drivers and for a particular driver show his/her qualifications and training.

--- INTERMEDIATE FUNCTIONALITY ---
It should be possible to create entries in a driver’s disciplinary record. This functionality should be added to the desktop application developed for the
basic system. Examples of incidents are: accidents, abusive behaviour towards customers, speeding offences, aggressive/dangerous driving, running a red light.

Create a Log component which can receive the following four inputs:
1. Start of day log
2. End of day log
3. Start of journey log
4. End of journey log

It should calculate journey durations (when receiving an end of journey log) and total hours worked in a day (when receiving an end of day log). It
should report an error if it receives a log in an unexpected sequence (e.g. an end of journey log when no start of journey log was received).
The component should be exposed through a Web Service (SOAP or REST), so that it can be called from the driver app. The prototype of the
driver app can be created as a desktop application and it must be possible to submit the four types of log listed above.

The driver app should not connect directly to the database or the Log component, but all communication must be via the Web Service
(remember that the company is planning to replace the desktop application with a mobile app at a later stage).

--- ADVANCED FUNCTIONALITY ---
Implement a component which predicts the likelihood of a driver being involved in an incident. It is up to you to decide how the prediction is
calculated, but it should involve at least the following parameters: hours worked in the current day, hours worked in the last seven days, training
activities completed by the driver.

A simple prediction could just present a percentage showing the overall risk of an incident. A more complex implementation could identify the
incident most likely to happen (requires calculating the risk for various types of incidents). For example, there is a 10% chance of running a red
light and an 8% chance of an accident.

Create a visualisation component which makes it possible to visually depict a driver’s likelihood of being involved in an incident. It could also
combine details of the different types of incidents in a single widget. The visual component should be integrated into the desktop application you
created for the admin users.

--- MY DATABASE ERD ---
https://lucid.app/lucidchart/invitations/accept/c7453826-a3c4-4bfe-8b5b-87e0e554b493
