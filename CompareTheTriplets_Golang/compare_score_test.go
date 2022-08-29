package main

import (
	"testing"
)

func Test_AliceMelhorPontuacao(t *testing.T) {
	// Arrange
	pontuacaoAlice := []int32{5, 5, 5}
	pontuacaoBob := []int32{1, 1, 1}
	esperado := []int32{3, 0}

	// Act
	resultado := Comparador(pontuacaoAlice, pontuacaoBob)

	// Assert
	for i := 0; i < 2; i++ {
		if resultado[i] != esperado[i] {
			t.Error(
				"Pontuação", i,
				"Esperado", esperado[i],
				"Obteve", resultado[i],
			)
		}
	}
}
