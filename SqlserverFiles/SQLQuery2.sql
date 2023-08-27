--to add some data
use Bank;
INSERT INTO Bank (Code, Name, Address) VALUES (1, 'Bank A', '123 Main St');
INSERT INTO Bank (Code, Name, Address) VALUES (2, 'Bank B', '456 Elm St');
INSERT INTO Bank (Code, Name, Address) VALUES (3, 'Bank C', '789 Oak St');
INSERT INTO Bank (Code, Name, Address) VALUES (4, 'Bank D', '321 Pine St');
INSERT INTO Bank (Code, Name, Address) VALUES (5, 'Bank E', '654 Maple St');

INSERT INTO Branch (Branch_id, Name, Address, Bank_Code) VALUES (1, 'Branch 1', '111 First Ave', 1);
INSERT INTO Branch (Branch_id, Name, Address, Bank_Code) VALUES (2, 'Branch 2', '222 Second Ave', 1);
INSERT INTO Branch (Branch_id, Name, Address, Bank_Code) VALUES (3, 'Branch 3', '333 Third Ave', 2);
INSERT INTO Branch (Branch_id, Name, Address, Bank_Code) VALUES (4, 'Branch 4', '444 Fourth Ave', 2);
INSERT INTO Branch (Branch_id, Name, Address, Bank_Code) VALUES (5, 'Branch 5', '555 Fifth Ave', 3);

INSERT INTO Customer (Customer_id, Name, Phone_Number, Address) VALUES (1, 'John Smith', '555-1234', '123 Main St');
INSERT INTO Customer (Customer_id, Name, Phone_Number, Address) VALUES (2, 'Jane Doe', '555-5678', '456 Elm St');
INSERT INTO Customer (Customer_id, Name, Phone_Number, Address) VALUES (3, 'Mike Johnson', '555-9012', '789 Oak St');
INSERT INTO Customer (Customer_id, Name, Phone_Number, Address) VALUES (4, 'Sarah Williams', '555-3456', '321 Pine St');
INSERT INTO Customer (Customer_id, Name, Phone_Number, Address) VALUES (5, 'Chris Brown', '555-7890', '654 Maple St');

INSERT INTO Account (Account_number, Account_Type, Balance, Branch_id) VALUES (1001, 'Savings', 5000.00, 1);
INSERT INTO Account (Account_number, Account_Type, Balance, Branch_id) VALUES (1002, 'Checking', 1000.00, 1);
INSERT INTO Account (Account_number, Account_Type, Balance, Branch_id) VALUES (2001, 'Savings', 15000.00, 2);
INSERT INTO Account (Account_number, Account_Type, Balance, Branch_id) VALUES (2002, 'Checking', 2000.00, 2);
INSERT INTO Account (Account_number, Account_Type, Balance, Branch_id) VALUES (3001, 'Savings', 10000.00, 3);
INSERT INTO Account (Account_number, Account_Type, Balance, Branch_id) VALUES (3002, 'Checking', 500.00, 3);

INSERT INTO Loan (Loan_id, Loan_Type, Amount, Branch_id) VALUES (5001, 'Personal', 10000.00, 1);
INSERT INTO Loan (Loan_id, Loan_Type, Amount, Branch_id) VALUES (5002, 'Mortgage', 200000.00, 1);
INSERT INTO Loan (Loan_id, Loan_Type, Amount, Branch_id) VALUES (6001, 'Personal', 5000.00, 2);
INSERT INTO Loan (Loan_id, Loan_Type, Amount, Branch_id) VALUES (6002, 'Car', 25000.00, 2);
INSERT INTO Loan (Loan_id, Loan_Type, Amount, Branch_id) VALUES (7001, 'Business', 50000.00, 3);
INSERT INTO Loan (Loan_id, Loan_Type, Amount, Branch_id) VALUES (7002, 'Personal', 10000.00, 3);

INSERT INTO Account_Customer (Account_number, Customer_id) VALUES (1001, 1 );
INSERT INTO Account_Customer (Account_number, Customer_id) VALUES (1002, 2);
INSERT INTO Account_Customer (Account_number, Customer_id) VALUES (2001, 3);
INSERT INTO Account_Customer (Account_number, Customer_id) VALUES (2002, 4);
INSERT INTO Account_Customer (Account_number, Customer_id) VALUES (3001, 5);

INSERT INTO Loan_Customer (Loan_id, Customer_id) VALUES (5001, 1);
INSERT INTO Loan_Customer (Loan_id, Customer_id) VALUES (5002, 2);
INSERT INTO Loan_Customer (Loan_id, Customer_id) VALUES (6001, 3);
INSERT INTO Loan_Customer (Loan_id, Customer_id) VALUES (6002, 4);
INSERT INTO Loan_Customer (Loan_id, Customer_id) VALUES (7001, 5);



INSERT INTO transaction_acc (transaction_id, account_number, transaction_type, amount, Transaction_date) VALUES (1, 1001, 'Deposit', 1.00, '2022-01-01');
INSERT INTO transaction_acc (transaction_id, account_number, transaction_type, amount, Transaction_date) VALUES (2, 1002, 'Withdraw', 5.00, '2021-01-02');
INSERT INTO transaction_acc (transaction_id, account_number, transaction_type, amount, Transaction_date) VALUES (3, 2001, 'Deposit', 2.00, '2023-01-03');
INSERT INTO transaction_acc (transaction_id, account_number, transaction_type, amount, Transaction_date) VALUES (4, 2002, 'Withdraw', 1.00, '2021-01-04');
INSERT INTO transaction_acc (transaction_id, account_number, transaction_type, amount, Transaction_date) VALUES (5, 3001, 'Deposit', 5.00, '2023-01-05');
INSERT INTO transaction_acc (transaction_id, account_number, transaction_type, amount, Transaction_date) VALUES (6, 3002, 'Withdraw', 2.00, '2022-01-06');
INSERT INTO transaction_acc (transaction_id, account_number, transaction_type, amount, Transaction_date) VALUES (7, 3002, 'Withdraw', 2.00, '2023-04-06');

select * from account