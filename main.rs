fn add(a: i32, b: i32) -> i32 {
    a + b
}

fn main() {
    let a = 3;
    let b = 4;
    let c = add(a, b);
    println!("Hello Rust!");
    println!("The result is {}", c);
}
