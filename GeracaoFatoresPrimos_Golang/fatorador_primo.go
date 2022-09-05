package main

import (
	"fmt"
	"os"
	"strconv"
)

func main() {
	arg, _ := strconv.Atoi(os.Args[1])

	fmt.Println("Para o número inteiro:", arg)

	resultado := FatorarPrimos(arg)
	fmt.Printf("Fatores: %v\n", resultado)
}

func FatorarPrimos(inteiro int) string {
	resultado := ""

	if IsPrime(inteiro) {
		return strconv.Itoa(inteiro)
	}

	auxiliar := inteiro

	for i := 2; i < inteiro; {
		if !IsPrime(i) {
			i++
			continue
		}

		if auxiliar%i != 0 {
			i++
			continue
		} else {
			auxiliar = auxiliar / i
			if resultado == "" {
				resultado = strconv.Itoa(i)
			} else {
				resultado += "x" + strconv.Itoa(i)
			}
		}
	}

	return resultado
}

func IsPrime(candidato int) bool {
	for i := 2; i < candidato; i++ {
		if candidato%i == 0 {
			return false
		}
	}

	return true
}
