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

func Test_AliceMenorPontuacao(t *testing.T) {
	// Arrange
	pontuacaoAlice := []int32{1, 1, 1}
	pontuacaoBob := []int32{5, 5, 5}
	esperado := []int32{0, 3}

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

func Test_AliceIgualPontuacao(t *testing.T) {
	// Arrange
	pontuacaoAlice := []int32{1, 97, 3}
	pontuacaoBob := []int32{1, 97, 3}
	esperado := []int32{0, 0}

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

func Test_AliceMaiorMisto(t *testing.T) {
	// Arrange
	pontuacaoAlice := []int32{2, 97, 3}
	pontuacaoBob := []int32{1, 90, 5}
	esperado := []int32{2, 1}

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
