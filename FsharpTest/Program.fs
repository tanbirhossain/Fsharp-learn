//let mutable z = 10
//z <- 12
//z <- 13
//printfn "result: %d" z

//#region Decision Making
//let a: int32 = 100
//let b: int32 = 200
//if (a = 10) then
//    printfn "value of a is 10\n"
//elif (a=20) then
//    printfn "Value of a is 20\n"
//else
//    printfn "None of them so chill"
//    printfn "None of second"
//#endregion

//#region loop Making
//let main() =
//    for i=20 downto 1 do
//        printfn "i: %i" i
//main()
//#endregion

// Looping over a list.
//let list1 = [10;25;34;45;78]
//for i in list1 do
//    printfn "%d" i

// Looping over a sequence
//let seq1 = 
//    seq {
//        for i in 1 .. 10 -> (i, i*i) 
//    }
//for (a, asqr ) in seq1 do
//    printfn "%d squared is %d" a asqr
    
//While do
//let mutable a = 10
//while (a<20) do
//    printfn "value of a: %d" a
//    a <- a + 1

//Nested loop
//let main() =
//    for i=1 to 5 do
//        printf "\n"
//        for j = 1 to 3 do
//            printf "*"
//main()

// the function calculate the volume of 
// a cylinder with radius and length as parameters
//let cylinderVolume radius length : float =
//    //function body
//    let pi = 3.14159
//    length * pi * radius * radius
//let vol = cylinderVolume 3.0 5.0
//printfn " Volume: %g " vol

// The function returns the larger value between two
//let max num1 num2 : int32 =
//    // function body
//    if(num1 > num2) then
//        num1
//    else
//        num2
//let result = max 53 52
//printfn "Max number: %d " result

//let doubleIdIt x:int =
//    2*x
//printfn "Double 19: %d" (doubleIdIt(19))

//Recursive Function
//let rec fib n =
//    if n< 2 then
//        1
//    else
//        fib (n-1) + fib (n-2)
//for i=1 to 10 do
//    printfn "Fibonacci %d: %d" i (fib(i))

//open System
//let rec fact x =
//    if x < 1 then 
//        1
//    else
//        x * fact (x-1)
//Console.WriteLine(fact 8)

//Lambda Expressions     input x(int) -> input y(int) -> return result(int)
//let applyFunction ( f: int -> int -> int ) x y = 
//    f x y
//let mul x y = x * y
//let res = applyFunction mul 5 7 
//printfn "%d" res

//let applyfunction (f: int -> int -> int) x y = f x y
//let res = applyfunction(fun x y -> x * y) 5 7 
//printfn "%d" res

//Function Composition and pipelining
//let function1 x = x + 1
//let function2 x = x * 5
//let f = function1 >> function2 //here is function1 firstly will be exectue after that fuction1 result will be call function2 
//let res = f 10
//printfn "%d" res

//Pipelining of functions
//let function1 x = x + 1
//let function2 x = x * 5
//let res = 10 |> function1 |> function2
//printfn "%d" res

//Operators on Strings
//let xmldata = @"<book author = ""lewis, C.S"" title = ""Narnia"">"
//printfn "%s" xmldata

//let collectTesting inputs =
//    String.collect (fun c -> sprintf "%c " c) inputs
//printfn "%s" (collectTesting "Happy New Year!")

//let strings = ["Tutorials Point"; "Coding Ground" ; "Absolute Classes"]
//let outProducts = String.concat "\n" strings
//printfn "%s" outProducts

//printfn "%s" <| String.replicate 10 "*! "


//let div x y = 
//    match y with
//    | 0 -> None
//    |_ -> Some(x/y)
//let res : int option = div 20 0
//printfn "Result: %A" res

//let checkPositive (a : int) =
//    if a>0 then
//        Some(a)
//    else
//        None
//let res : int option = checkPositive(-31)
//printfn "Result: %A " res

//let isHundred = function
//    | Some(100) -> true
//    | Some(_) | None -> false
//printfn "%A" (isHundred (Some(45)))
//printfn "%A" (isHundred (Some(100)))
//printfn "%A" (isHundred None)

//Record List
//type websitemanush = 
//    {   
//        Title : string;
//        Url : string
//    }

//(* create some records *)
//let homepage = { Title ="TutorialsPoints"; Url = "www.tutorialspoint.com" }
//let cpage = { Title = "Learn C"; Url = "www.Kashem.com" }

//(* printing records *)
//(printfn "Home Page: Title: %A \n \t URL: %A") homepage.Title homepage.Url
//(printfn "Cpage Page: Title: %A \n \t URL: %A") cpage.Title homepage.Url



//type student =
//   { 
//      Name : string;
//      ID : int;
//      RegistrationText : string;
//      IsRegistered : bool
//   }

//let getStudent name id = 
//    {
//        Name = name;
//        ID  = id;
//        RegistrationText = null;
//        IsRegistered = false
//    }


//let registerStudent st =
//    {
//        st with
//        RegistrationText = "Registered";
//        IsRegistered = true
//    }
//let printStudent msg st =
//    printfn "%s: %A" msg st

//let main() =
//    let preRegisteredStudent = getStudent "Zara" 10
//    let postRegisteredStudent = registerStudent preRegisteredStudent

//    printStudent "Before Registration: " preRegisteredStudent
//    printStudent "After Registration: " postRegisteredStudent

//main()



//List
let list1 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
printfn "The list: %A" list1

let list2 = 1 :: 2 :: 3 :: []
printfn "The list: %A" list2

let list3 = [1..10]
printfn "The list: %A" list3

