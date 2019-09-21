DECLARE @RoutineId int = 1000
DECLARE @RoutineTitle NVARCHAR(MAX) = N'روتین تستی'

-- delete old datas
DELETE [Routine2Role] WHERE [RoutineId] = @RoutineId
DELETE [Routine2Step] WHERE [RoutineId] = @RoutineId
DELETE [Routine2Action] WHERE [RoutineId] = @RoutineId
DELETE [Routine2Notice] WHERE [RoutineId] = @RoutineId

-- Create Routine
if exists (select * from [Routine2] with (updlock,serializable) where [Id] = @RoutineId)
begin
   UPDATE [Routine2] set [Title] = @RoutineTitle
   WHERE [Id] = @RoutineId
end
else
begin
    SET IDENTITY_INSERT [Routine2] ON
    INSERT INTO [Routine2] (
          [Id]
        , [Title]
    )

    VALUES (
          @RoutineId
        , @RoutineTitle
    )
    SET IDENTITY_INSERT [Routine2] OFF
end



-- Create RoutineRoles
INSERT INTO [Routine2Role] (
    [RoutineId],    [SortOrder],       [DashboardEnum],                   [Title],                             [StepsJson] ) VALUES
    (@RoutineId,              1,       'Applicant',                        N'متقاضی',                           '["101"]' )
  , (@RoutineId,              2,       'Expert',                           N'کارتابل کارشناس دفتر استانی',    '["201"]' )
  , (@RoutineId,              3,       'RelagiousCommittee',               N'رئیس کمیته معارف استانی',         '["301"]' )


-- Create RoutineSteps
INSERT INTO [Routine2Step] (
      [RoutineId], [Step],     [F1],     [F2],     [F3],     [F4],     [F5],     [F6],     [F7],     [Title] ) VALUES
      (@RoutineId,    101,     201,     NULL,     NULL,     NULL,     NULL,     NULL,     NULL,     N'ایجاد درخواست متقاضی')

	, (@RoutineId,    201,     301,      NULL,     NULL,     NULL,     NULL,     NULL,     NULL,     N'بررسی کارشناس دفتر استانی')
	
	, (@RoutineId,    301,     401,      NULL,     NULL,     NULL,     NULL,     NULL,     NULL,     N'بررسی رئیس کمیته معارف استانی')
	
	, (@RoutineId,    401,     NULL,     NULL,     NULL,     NULL,     NULL,     NULL,     NULL,     N'اتمام روال')


-- Create Actions Information
INSERT INTO [Routine2Action] (
      [RoutineId], [Step],        [Action],          [IsDescriptionRequired],  [IsDescriptionMultiline], [ShouldHideDescription],      [Color],           [Icon],                [Title]) VALUES
      (@RoutineId,    101,          'F1',                           0,                      0,                      0,                 'info',            'play',				  N'ارسال')
      ,(@RoutineId,    201,         'F1',                           0,                      0,                      0,                 'info',            'play',				  N'ارسال')
      ,(@RoutineId,    301,         'F1',                           0,                      0,                      0,                 'info',            'play',				  N'ارسال')





SELECT * FROM Routine2 WHERE Id = @RoutineId
SELECT * FROM Routine2Notice WHERE RoutineId = @RoutineId
SELECT * FROM Routine2Role WHERE RoutineId = @RoutineId
SELECT * FROM Routine2Step WHERE RoutineId = @RoutineId
SELECT * FROM Routine2Action WHERE RoutineId = @RoutineId