Use Bank; 

GO 
CREATE VIEW BranchTotalBalance AS
SELECT b.Branch_id, SUM(a.Balance) AS Total_Balance
FROM Bank.dbo.Branch b
INNER JOIN Bank.dbo.Account a ON a.Branch_id = b.Branch_id
GROUP BY b.Branch_id;
GO
CREATE PROCEDURE GetAccountDetailsForBranchUPPs
    @BranchId INT
AS
BEGIN
    SELECT A.AccountId, A.AccountNumber, A.Balance
    FROM Bank.dbo.Accounts A
    INNER JOIN Bank.dbo.Branches B ON A.BranchId = B.BranchId
    WHERE A.BranchId = @BranchId;
END;

GO 
CREATE PROCEDURE AddAccountUPPs
(
    @account_code INT,
    @account_type VARCHAR(50),
    @account_balance DECIMAL(10, 2),
    @branch_code INT
)
AS
BEGIN
    INSERT INTO Bank.dbo.Account (Account_number, Account_Type, Balance, Branch_id)
    VALUES (@account_code, @account_type, @account_balance, @branch_code);
END;
GO 
CREATE TRIGGER UpdateAccountBalance
ON Bank.dbo.Transaction_acc
AFTER INSERT
AS
BEGIN
    -- Update the Account balance based on the Transaction type and amount
    UPDATE A
    SET A.Balance =
        CASE
            WHEN I.transaction_type = 'Deposit' THEN A.Balance + I.amount
            WHEN I.transaction_type = 'Withdraw' THEN A.Balance - I.amount
            ELSE A.balance
        END
    FROM dbo.Account A
    INNER JOIN inserted I ON A.Account_number = I.Account_number;
   
    -- If needed, you can perform additional actions here
   
END;

