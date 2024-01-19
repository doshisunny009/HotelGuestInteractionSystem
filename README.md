HotelGuestInteractionSystem

This System is developed by Sunny Doshi.
It is a system that lets guest to raise requests for any service they require from the hotel staff. It also allows the hotel staff to view all the requests and export it to a text file. This system can be integrated into an existing application as a feature.

-Steps to Setup & Run the system

1. For visual studio 2019 version 16.8 and above, You can directly go to visual studio -> Git tab -> Clone repository. A dialog box will open where you can simply provide the git repo link "https://github.com/doshisunny009/HotelGuestInteractionSystem.git" and clone it.
2. For visual studio versions that do not have git, You can simply download the code from the link "https://github.com/doshisunny009/HotelGuestInteractionSystem.git" and then unzip the file once downloaded. After unzipping the file, open the HotelGuestInteractionSystem.sln on visual studio.
3. The next step is to build the solution. For this Right click on the Solution name i.e. "HotelGuestInteractionSystem" that can be found in solution explorer and then select build solution.
4. Once the solution build is completed, Run the application by pressing Ctrl + F5 and you are ready to use the system.


-System Flow

The system has 2 interface - one for the hotel guest and other for hotel staff.
By default the system shows guest welcome page.
To navigate to hotel staff interface, type "YourLocalhostorServer/Request/StaffHomepage" in url search bar. Replace the YourLocalhostorServer part of url with localhost or server address you are running the application on.
Also, when the you export request details from hotel staff interface, the text file is stored in the HotelGuestInteractionSystem/Output/ directory.
