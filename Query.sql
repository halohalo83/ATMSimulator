USE ATMSimulator
SELECT * FROM dbo.Accounts
INSERT INTO dbo.Accounts
        ( AcctNo ,
          HolderName ,
          PIN ,
          Balance ,
          Username ,
          Password
        )
VALUES  ( 1 , -- AcctNo - int
          'Admin' , -- HolderName - varchar(50)
          123 , -- PIN - int
          1000000 , -- Balance - money
          'admin' , -- Username - varchar(50)
          '123'  -- Password - varchar(50)
        )