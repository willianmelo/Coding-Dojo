package main

import "testing"

func Test_RetornarPrimosFatoresParaValorPrimo(t *testing.T) {
	// Arrange
	numeroInteiroPrimo := 7
	esperado := "7"

	// Act
	result := FatorarPrimos(numeroInteiroPrimo)

	// Assert
	if result != esperado {
		t.Error(
			"Esperado", esperado,
			"Resultado", result,
		)
	}
}

// Arrange
type testPair struct {
	numeroInteiroNaoPrimo int
	esperado              string
}

var tests = []testPair{
	{6, "2x3"},
	{33, "3x11"},
	{100, "2x2x5x5"},
}

func Test_CalcularFatoresDiversosNaoPrimos(t *testing.T) {
	for _, pair := range tests {
		// Act
		resultado := FatorarPrimos(pair.numeroInteiroNaoPrimo)

		// Assert
		if resultado != pair.esperado {
			t.Error(
				"Esperado", pair.esperado,
				"Resultado", resultado,
			)
		}
	}
}
