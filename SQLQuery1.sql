CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY(1,1),       
    username VARCHAR(50) NOT NULL UNIQUE,   
    password VARCHAR(MAX) NOT NULL,         
    email VARCHAR(100) NOT NULL UNIQUE      
);

CREATE TABLE Contacts (
    id INT PRIMARY KEY IDENTITY(1,1),       
    user_id INT NOT NULL,                   
    Name NVARCHAR(50) NOT NULL,       
    Surname NVARCHAR(50),                 
    Nickname NVARCHAR(50),                  
    Email VARCHAR(100),                     
    Phone INT,
    Birthday DATE,
    CONSTRAINT FK_Contacts_Users FOREIGN KEY (user_id)
        REFERENCES Users (id) ON DELETE CASCADE 
);

CREATE TABLE Addresses (
    id INT PRIMARY KEY IDENTITY(1,1),       
    contact_id INT NOT NULL,                
    user_id INT NOT NULL,
    Street NVARCHAR(255) NOT NULL,  
    City NVARCHAR(100) NOT NULL,            
    Country NVARCHAR(100) NOT NULL,         
    CONSTRAINT FK_Addresses_Contacts FOREIGN KEY (contact_id)
        REFERENCES Contacts (id) ON DELETE CASCADE 
);
