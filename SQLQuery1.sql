CREATE TABLE Movimento
(
Id INT PRIMARY KEY IDENTITY(1,1),
IdConta INT NOT NULL,
Data DATETIME NOT NULL,
Valor Decimal(19, 2) NOT NULL,
Operacao INT NOT NULL,
CONSTRAINT CT_OPERACAO CHECK(Operacao IN (1,2))
)