
# Conference Data Management System

## Overview

This repository contains the SQL dump for a conference data management system. The system is designed to manage information related to conference attendees, registration details, session schedules, speakers, sponsors, and venue information.

## Database Information

### Database Name
`conference_data`

### Tables

1. **attendees_info**
   - `AttendeeID` (Primary Key): Unique identifier for attendees
   - `typeAttendees`: Type of attendees (e.g., Students, Officers, Researchers)
   - `orgName`: Organization name of the attendee
   - `affiliation`: Affiliation information
   - `contactnum`: Contact number of the attendee

2. **register_info**
   - `User_ID` (Primary Key): Unique identifier for registered users
   - `Lname`: Last name of the user
   - `Fname`: First name of the user
   - `address`: Address of the user
   - `emailadd`: Email address of the user
   - `contactnum` (Unique): Contact number of the user
   - `username`: User's username
   - `password`: User's password

3. **schedules_info**
   - `scheduleID` (Primary Key): Unique identifier for schedules
   - `User_ID` (Foreign Key): User ID referencing `register_info`
   - `SessionID` (Foreign Key): Session ID referencing `sessions_info`
   - `session_name`: Name of the session
   - `venueName`: Venue for the session
   - `conferenceStatus`: Status of the conference (e.g., Pending, Done)

4. **sessions_info**
   - `SessionID` (Primary Key): Unique identifier for sessions
   - `title`: Title of the session
   - `description`: Description of the session
   - `dateAndtime`: Date and time of the session

5. **speakers_info**
   - `SpeakerID` (Primary Key): Unique identifier for speakers
   - `LNspeaker`: Last name of the speaker
   - `FNspeaker`: First name of the speaker
   - `Contactspeaker`: Contact information of the speaker
   - `Emailspeaker` (Unique): Email address of the speaker

6. **sponsor_info**
   - `sponsorID` (Primary Key): Unique identifier for sponsors
   - `LastName`: Last name of the sponsor
   - `FirstName`: First name of the sponsor
   - `emailAddress`: Email address of the sponsor
   - `contactnum`: Contact number of the sponsor

7. **venue_info**
   - `venueName` (Primary Key): Name of the venue
   - `location`: Location of the venue
   - `capacity`: Capacity of the venue

## Usage

1. Import the SQL dump into a database management system (e.g., MySQL).
2. Update the database connection details in your application configuration file.
3. Start using the conference data management system to organize and manage conference-related information.

Feel free to explore and customize the system based on your specific conference management needs.
