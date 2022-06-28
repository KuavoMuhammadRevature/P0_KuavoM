--create database CowaBungaBankingAppDB

--create table AdminLogin
--(
--	userName varchar(20),
--	passWord varchar(20),
--
--	constraint pk_admin_userName primary key(userName),
--	constraint chk_admmin_userName_len check(len(userName) > 3),
--	constraint chk_admin_passWord_len check(len(passWord) >5),
--	constraint chk_admin_accountStatus_List check (accountStatus in ('Active', 'Inactive', 'Locked', 'Disabled')
--
--))

--insert into AdminLogin (userName,passWord) values('AdminA', 'nomad1234')
--insert into AdminLogin (userName,passWord) values('AdminB', 'crocs2345')

--create table BranchInfo
--(
--	brName varchar(20) not null primary key,
--	brCity varchar(20),
--	brEmail varchar(20),
--	brContactNo varchar(10),
--	brOpenStatus varchar(10)

--)

--insert into BranchInfo (brName, brCity, brEmail, brContactNo, brOpenStatus) values('East Texas','Dallas, Texas','ETXB@cowabunga.net','4695559999','Closed' ),
--insert into BranchInfo (brName, brCity, brEmail, brContactNo, brOpenStatus) values( 'North Texas','Amarillo, Texas','NTXB@cowabunga.net','8065559999','Open'),
--insert into BranchInfo (brName, brCity, brEmail, brContactNo, brOpenStatus) values( 'South Texas','Galveston, Texas','STXB@cowabunga.net','4095559999','Open'),
--insert into BranchInfo (brName, brCity, brEmail, brContactNo, brOpenStatus) values( 'West Texas','Odessa, Texas','WTXB@cowabunga.net','4325559999','Open')

--create table ClientLogin
--(
--	userName varchar(20),
--	passWord varchar(20),
--	accountStatus varchar(10) default 'Active',
--	attempts int default (0)

--	constraint pk_client_userName primary key(userName),
--	constraint chk_client_userName_len check(len(userName) > 3),
--	constraint chk_client_passWord_len check(len(passWord) >5),
--	constraint chk_client_accountStatus_List check (accountStatus in ('Active', 'Inactive', 'Locked', 'Disabled')

--))
--
--insert into ClientLogin (userName, userPswd, userStatus, userAttempts) Values('ClientA','user6789','Active',0)
--insert into ClientLogin (userName, userPswd, userStatus, userAttempts) Values('ClientB','happy1234','Disabled',0)
--insert into ClientLogin (userName, userPswd, userStatus, userAttempts) Values('ClientC','client1234','Active',0)

--create table LoginInfo
--(
--	accNo int primary key not null,
--	userType varchar(10) not null,
--	userName varchar(20) not null,
--	userPswd varchar(20) not null,
--	userStatus varchar(10) null,
--	userAttempts int null

--)
--insert into LoginInfo (accNo, userType, userName, userPswd, userStatus, userAttempts) Values(101,'Admin','AdminA','nomad1234','Active',0)
--insert into LoginInfo (accNo, userType, userName, userPswd, userStatus, userAttempts) Values(102,'Admin','AdminB','crocs2345','Active',0)
--insert into LoginInfo (accNo, userType, userName, userPswd, userStatus, userAttempts) Values(103,'Admin','AdminC','sleepy8901','Locked',0)
--insert into LoginInfo (accNo, userType, userName, userPswd, userStatus, userAttempts) Values(511,'Client','ClientA','user6789','Active',0)
--insert into LoginInfo (accNo, userType, userName, userPswd, userStatus, userAttempts) Values(512,'Client','ClientB','happy1234','Disabled',0)
--insert into LoginInfo (accNo, userType, userName, userPswd, userStatus, userAttempts) Values(513,'Client','ClientC','client1234','Active',0)




--create table TransactionInfo
--(
--	trNo int not null primary key,
--	calendar datetime, 
--	fromAccount int,
--	toAccount int,
--	Amount int,
--	transferedBy varchar(20),
--	transcType varchar(10)

--)

--insert into TransactionInfo (trNo, calendar, fromAccount, toAccount, Amount, transferedBy, transcType) values (1,2022-06-22 11:04:25.033,101,102,2000,'Admin','Transfer')


--create table Users
--alues
--	accNo int,
--	userNo int,
--	userType varchar(10),
--	accType varchar(10),
--	userName varchar(20) not null,
--	accBalance float,
--	userStatus varchar(10),
--	accOverDrawProtection bit

--)

--insert into Users (accNo,userNo, userType,accType,userName,accBalance,userStatus,accOverDrawProtection) values (101,'Admin','AdminA','nomad1234','Active',0)
--insert into Users (accNo,userNo, userType,accType,userName,accBalance,userStatus,accOverDrawProtection) values (102,'Admin','AdminB','crocs2345','Inactive',0)
--insert into Users (accNo,userNo, userType,accType,userName,accBalance,userStatus,accOverDrawProtection) values (103,'Admin','AdminC','sleepy8901','Locked',0)
--insert into Users (accNo,userNo, userType,accType,userName,accBalance,userStatus,accOverDrawProtection) values (511,'Client','ClientA','user6789','Active',0)
--insert into Users (accNo,userNo, userType,accType,userName,accBalance,userStatus,accOverDrawProtection) values (512,'Client','ClientB','happy1234','Disabled',0)
--insert into Users (accNo,userNo, userType,accType,userName,accBalance,userStatus,accOverDrawProtection) values (513,'Client','ClientC','client1234','Active',0)























--create table AdminLogin
--(
--	userName varchar(20),
--	passWord varchar(20),
--	accountStatus varchar(10) default 'Active',
--	attempts int default (0)

--	constraint pk_admin_userName primary key(userName),
--	constraint chk_admmin_userName_len check(len(userName) > 3),
--	constraint chk_admin_passWord_len check(len(passWord) >5),
--	constraint chk_admin_accountStatus_List check (accountStatus in ('Active', 'Inactive', 'Locked', 'Disabled')


--))

--insert into AdminLogin (userName,passWord) values('Admin', 'nomad1234')





--create table ClientLogin
--(
--	userName varchar(20),
--	passWord varchar(20),
--	accountStatus varchar(10) default 'Active',
--	attempts int default (0)

--	constraint pk_client_userName primary key(userName),
--	constraint chk_client_userName_len check(len(userName) > 3),
--	constraint chk_client_passWord_len check(len(passWord) >5),
--	constraint chk_client_accountStatus_List check (accountStatus in ('Active', 'Inactive', 'Locked', 'Disabled')

--))

--insert into ClientLogin (userName,passWord) values('Client', 'happy1234')
