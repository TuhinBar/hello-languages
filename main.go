package main

import "fmt"

func main(){
	fmt.Println("Hello GO");

	println("The result is: ", add(1, 2))
}

func add(a int, b int) int {
	return a + b
}