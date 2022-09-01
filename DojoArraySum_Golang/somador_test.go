package main

import (
	"testing"
)

func Test_SomarValoresArray(t *testing.T) {
	// Arrange
	esperado := 9
	vetorParaSomar := []int{2, 3, 4}

	// Act
	resultado := Somador(vetorParaSomar)

	// Assert
	if resultado != esperado {
		t.Error(
			"Esperado", esperado,
			"Obteve", resultado,
		)
	}
}
