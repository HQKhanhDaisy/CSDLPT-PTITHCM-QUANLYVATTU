CREATE PROC [dbo].[SP_RP_DSVATTU]
AS
	SELECT MAVT, TENVT, DVT, SOLUONGTON FROM dbo.Vattu ORDER BY TENVT
