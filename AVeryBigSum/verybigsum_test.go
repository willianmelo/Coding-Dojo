package main

import "testing"

func Test_SumArrayValue_ArrayOfIntegers_ResultOfSum(t *testing.T) {
	listOfIntegers := []int{1000000001, 1000000002, 1000000003, 1000000004, 1000000005}
	expected := 5000000015

	result := SumArrayValue(listOfIntegers)

	if expected != result {
		t.Error("Expected", expected, "Got", result)
	}
}

func Test_SumArrayValue_ArrayOfBigIntegers_ResultOfSum(t *testing.T) {
	listOfIntegers := []int{1000000000000001, 1000000000000002, 1000000000000003, 1000000000000004, 1000000000000005}
	expected := 5000000000000015

	result := SumArrayValue(listOfIntegers)

	if expected != result {
		t.Error("Expected", expected, "Got", result)
	}
}
