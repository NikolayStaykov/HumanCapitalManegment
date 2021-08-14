# HumanCapitalManegment

Welcome to Human Capital Management System By Nikolay Staykov or HCMS for short

Part I: Setup

1. The application is currently connected to a test MySQL database hosted on db4free.net which contains some test data. You can use the
   login credentials: Username: admin Password: admin; for your first login and afterwards create custom users as needed. 

2. In the case that youwould like to migrate the application to a private MySQL serveryou can use the MySQL Workbench files in the 
   DatabaseModels folder toforward engenier it to the new server and edit the hibernate.cfg.xml file in the HCMSApplication folder 
   to enter the connection string. The Application will automatically connect to the new server after that.

Part II: Usage

1. There are 2 User types(Admin and Representative). Admins have full priviliges to create, edit or remove all information on the database.
   Representatives can create and edit most data, but are barred from deleting data in addition to some other restrictions. Fucnctions that
   only administrators can use appear as disabled to Representatives.

2. Limitations: Please keep in mind that objects in the database are dependent on each other. For instance when Deleting a department 
   object, it will also delete all positions within that department as well as all employees that hold those positions, and leave requests
   for said employees.
   