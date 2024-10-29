use employeedb

create table employeetb (
  Empid int,
  EmpName varchar(50),
  EmpDesig varchar(50),
  EmpDOJ datetime,
  EmpSal int,
  EmpDept int);


  create proc [dbo].[SPEmp_Insert]
  (@Pempid int,
  @Pempname varchar(50),
  @Pempdesig varchar(50),
  @Pempdoj datetime,
  @Pempsal int,
  @Pempdept int)
  as
  begin
  insert into Employeetb values(@Pempid,@Pempname,@Pempdesig,@Pempdoj,@Pempsal,@Pempdept)
  end
  go



  create proc [dbo].[SPEmp_Update1]
  (@Pempid int,
  @Pempname varchar(50),
  @Pempdesig varchar(50),
  @Pempdoj datetime,
  @Pempsal int,
  @Pempdept int)
  as begin
  update employeetb set
  EmpName=@Pempname,
  EmpDesig=@Pempdesig,
  EmpDOJ=@Pempdoj,
  EmpSal=@Pempsal,
  EmpDept=@Pempdept
  where 
  @Pempid=EmpId
  end 
  go


  create proc [dbo].[SPGetData]
   (@Pempid int,
  @Pempname varchar(50) output,
  @Pempdesig varchar(50) output,
  @Pempdoj datetime output,
  @Pempsal int output,
  @Pempdept int output)
  as begin
  select 
  EmpName=@Pempname,
  EmpDesig=@Pempdesig,
  EmpDOJ=@Pempdoj,
  EmpSal=@Pempsal,
  EmpDept=@Pempdept
  from Employeetb
  where EmpId=@PEmpId
  end
  go


  create proc [dbo].[SPGetSal]
  (@PEmpId int, @PempSal int output)
  as begin
  select @Pempsal=EmpSal from Employeetb
  where EmpId=@PEmpId
  end
  go



  create proc [dbo].[DelRecP1](@Pempid int)
  as begin
  Delete Employeetb
  where EmpId=@PempId
  end 
  Go