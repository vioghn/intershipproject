
USE Bank;

CREATE TABLE Bank (
    Code INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Address VARCHAR(200) NOT NULL
);

CREATE TABLE Branch (
    Branch_id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Address VARCHAR(200) NOT NULL,
    Bank_Code INT,
    FOREIGN KEY (Bank_Code) REFERENCES Bank(Code)
);

CREATE TABLE Customer (
    Customer_id INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Phone_Number VARCHAR(20) NOT NULL,
    Address VARCHAR(200) NOT NULL
);

CREATE TABLE Account (
    Account_number INT PRIMARY KEY,
    Account_Type VARCHAR(50) NOT NULL,
    Balance DECIMAL(10, 2),
    Branch_id INT,
    FOREIGN KEY (Branch_id) REFERENCES Branch(Branch_id)
);

CREATE TABLE Loan (
    Loan_id INT PRIMARY KEY,
    Loan_Type VARCHAR(50) NOT NULL,
    Amount DECIMAL(10, 2),
    Branch_id INT,
    FOREIGN KEY (Branch_id) REFERENCES Branch(Branch_id)
);

CREATE TABLE Account_Customer (
    Account_number INT,
    Customer_id INT,
    PRIMARY KEY (Account_number, Customer_id),
    FOREIGN KEY (Account_number) REFERENCES Account(Account_number),
    FOREIGN KEY (Customer_id) REFERENCES Customer(Customer_id)
);

CREATE TABLE Loan_Customer (
    Loan_id INT,
    Customer_id INT,
    PRIMARY KEY (Loan_id, Customer_id),
    FOREIGN KEY (Loan_id) REFERENCES Loan(Loan_id),
    FOREIGN KEY (Customer_id) REFERENCES Customer(Customer_id)
);

Go
CREATE FUNCTION dbo.GetAccountBalance (@account_number INT) 
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @balance DECIMAL(10, 2);
    SELECT @balance = Balance
    FROM Account
    WHERE Account_number = @account_number;
    
    RETURN @balance;
END;
GO

CREATE TABLE transaction_acc( 
    transaction_id INT, 
    account_number INT, 
    transaction_type VARCHAR(50) NOT NULL,
    amount DECIMAL(10, 2),
    Transaction_date DATE,
    PRIMARY KEY (transaction_id),
    FOREIGN KEY (account_number) REFERENCES Account(Account_number),
	CONSTRAINT withdraw_amount
    CHECK (amount <= dbo.GetAccountBalance(account_number) or transaction_type = 'Deposit')
);
