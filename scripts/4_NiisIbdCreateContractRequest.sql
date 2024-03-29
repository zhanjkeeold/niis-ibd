USE [dbNiis]
GO

CREATE PROCEDURE [dbo].[NiisIbdCreateContractRequest]
  @patentId INT
AS
BEGIN

-- Проверяем, существует ли БД.
  IF NOT EXISTS
    (SELECT name
     FROM master.dbo.sysdatabases
     WHERE ('[' + name + ']' = N'niis_ibd'
            OR name = N'niis_ibd')) BEGIN RETURN;
  END

  DECLARE @contractId INT,
		  @typeId INT,
		  @gosNumber NVARCHAR(50),
		  @gosDate DATE,
		  @dby DATE

  SELECT @typeId = [TYPE_ID]
		,@gosNumber = [GOS_NUMBER_11]
		,@gosDate = [GOS_DATE_11]
		,@dby = [DBY]
  FROM [dbNiis].[dbo].[BT_BASE_PATENT]
  WHERE [U_ID] = @patentId

-- Проверяем, является ли @patentId договором.
  IF (@typeId = 72) BEGIN
	IF (@gosNumber IS NULL OR @gosNumber = ''
		AND @gosDate IS NULL OR @gosDate = ''
		AND @dby IS NULL OR @dby = '') BEGIN
			RETURN;
	END
	SET @contractId = @patentId;

  END
  -- Если @patentId не является договором, то ищем договор в ссылках.
  ELSE IF (@typeId = 4) BEGIN
	
	SELECT TOP 1 @contractId = [flParentDocId]
	FROM [dbNiis].[dbo].[RF_PAT_PAT]
	WHERE [flChildDocId] = @patentId
	
	IF (@contractId IS NULL) BEGIN
	  RETURN;
	END
	-- Если есть ссылка на договор, записываем данные в БД niis_ibd
	IF
      (SELECT U_ID
       FROM BT_BASE_PATENT
       WHERE U_ID = @contractId
         AND TYPE_ID = 72
         AND GOS_NUMBER_11 <> NULL
         AND GOS_DATE_11 <> NULL
	     AND DBY <> NULL) IS NULL BEGIN RETURN;
    END

  END

  IF (@contractId IS NULL) BEGIN
	RETURN;
  END

  INSERT INTO [niis_ibd].[dbo].[ContractRequests]
           ([ContractId]
		   ,[PropertyId]
           ,[Dispatched]
           ,[DispatchingDate]
           ,[RowCreatedDate])
     SELECT [ContractId]   
	       ,[PropertyId]
		   ,0
		   ,NULL
		   ,GETDATE()
	FROM [dbNiis].[dbo].[NiisIbdContract]
	WHERE [dbNiis].[dbo].[NiisIbdContract].[ContractId] = @contractId

END
