USE [Teste]
GO
/****** Object:  StoredProcedure [dbo].[P_GET_ALL_VALUES_BY_CFOP]    Script Date: 13/04/2018 21:50:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_GET_ALL_VALUES_BY_CFOP]
AS
BEGIN
	SELECT
		 cfop
		,SUM(baseIcms) ValorTotalBaseIcms
		,SUM(valorIcms) ValorTotalIcms
		,SUM(baseipi) ValorTotalBaseIpi
		,SUM(valoripi) ValorTotalIpi
	FROM notaFiscalItem
	GROUP BY cfop
END
