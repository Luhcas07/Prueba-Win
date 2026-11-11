CREATE PROCEDURE usp_Cliente_Buscar
	@Termino VARCHAR(100),
	@Limite INT = 10
AS
BEGIN
	SELECT TOP (@Limite) * 
	FROM Cliente 
		WHERE Activo = 1
		AND NumeroDocumento LIKE @Termino + '%'
		AND RazonSocial LIKE @Termino + '%'
END