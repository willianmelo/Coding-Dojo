package main

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
