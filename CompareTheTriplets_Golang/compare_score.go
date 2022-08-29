package main

import (
	"fmt"
	"time"
)

func Comparador(a []int32, b []int32) []int32 {
	var scoreA int32 = 0
	var scoreB int32 = 0

	for i := 0; i < 3; i++ {
		if a[i] > b[i] {
			scoreA++
		} else if a[i] < b[i] {
			scoreB++
		}
	}

	return []int32{scoreA, scoreB}
}

func main() {
	comparacao := Comparador([]int32{5, 5, 5}, []int32{1, 1, 1})
	fmt.Println(comparacao)
	time.Sleep(8 * time.Second)
}
