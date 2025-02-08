# VB.NET – Full Course for Beginners
* https://youtu.be/7Y4PD8I83g0?si=JUZDOtbjEKhbseQl

# Create First project with Visual Studio

Search For templates...:
* Open Visual Studio -> Get Started with The last item "Create a new project"
* The first combo box "All languages" -> select "Visual Basic"
* The second combo box "All platforms" -> select "Windows"
* The third combo box "All project types" -> select "Desktop"
* Choose the template "Windows Forms App" ("Visual Basic" + "Windows" + "Desktop")

![VBNET8-Find-Template](./images/VB.NET8-01-select-visual-basic-windows-desktop-template.png)

Configure your new project:
* Project name: MyFirstVBProject
* Location: C:\Develop\VB.NET\vb.net-tutorials\VB.NET8-Begginers\
* Solution name: MyFirstVBProjectSolution
    The project will be created at : C:\Develop\VB.NET\vb.net-tutorials\VB.NET8-Begginers\\MyFirstVBProjectSolution\MyFirstVBProject

![Configure-New-Project](./images/VB.NET8-02-configure-new-myfirstproject.png)


Choosing Target Framework: 
* .Net 8.0 (Long Term Support)

![Choosing-NET8-LTS](./images/VB.NET8-03-choosing-target-framework-NET8-LTS.png)

Click on the Create button, the VS will create the project for you.

The folder "My Project" is required for the execution of the project


# Show the Message when click a button
* Drag a button on the form
    * Text = Click Me
    * Name = btn_ShowMsg
* Double click on the buton it will generate the click event code
    * Click event = btn_ShowMsg_Click
    * Print the message: "hello world"

![Demo-MsgBox-Helloworld](./images/VB.NET8-04-demo-msgbox-helloworld.png)


