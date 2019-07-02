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
//let list1 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
//printfn "The list1: %A" list1

//let list2 = 1 :: 2 :: 3 :: []
//printfn "The list2: %A" list2

//let list3 = [1..10]
//printfn "The list3: %A" list3

//let list4 = ['a' .. 'm']
//printfn "The list4: %A" list4

//let list5 = List.init 5 (fun index -> (index, index * index, index * index * index))
//printfn "The list5: %A" list5

//let list6 = [ for a in 1..10 do yield (a * a)]
//printfn "The list: %A" list6

//let list7 = [ for a in 1..100 do
//                if a % 3 = 0 && a % 5 = 0 then 
//                    yield a
//            ]

//printfn "The list7: %A" list7

//let list8 = [ for a in 1 .. 3 do
//                   yield! [a .. a + 3]
//            ]
//printfn "The list8: %A" list8


//List Properties
//let list1 = [2;4;5;6;8;10;12;14;16]

// Use of Properties
//printfn "list1.IsEmpty is %b" (list1.IsEmpty)
//printfn "list1.Length is %d" (list1.Length)
//printfn "list1.Head is %d" (list1.Head)
//printfn "list1.Tail.Head is %d" (list1.Tail.Head)
//printfn "list1.Tail.Tail.Head is %d" (list1.Tail.Tail.Head)
//printfn "list1.Item(1) is %d" (list1.Item(1))

//let list1 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
//printfn "The list: %A" list1 
//let list2 = list1 |> List.filter (fun x -> x % 2 = 0);;
//printfn "The Filtered list: %A" list2

//let list1 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
//printfn "The list: %A" list1
//let list2 = list1 |> List.map (fun x -> (x*x).ToString());;
//printfn "The Mapped list: %A" list2

//List.append
//let list1 = [1;2;3;4;5]
//let list2 = [6;7;8;9;10]
//let list3 = List.append list1 list2

//printfn "The first list: %A" list1
//printfn "The second list: %A" list2
//printfn "The appened list: %A" list3

//let lt1 =["a";"b";"c"]
//let lt2 =["e";"f";"g"]
//let lt3 = lt1 @ lt2
//printfn "The first list: %A" lt1
//printfn "The second list: %A" lt2
//printfn "The appened list: %A" lt3

//let list1 = [9.0; 0.0; 2.0; -4.54; 11.2; 8.0; -10.0]
//printfn "The list: %A" list1

//let list2 = List.sort list1
//printfn "The sorted list: %A" list2

//let s = List.sum list1
//let avg = List.average list1
//printfn "The sum: %f" s
//printfn "The average: %f" avg


//let sumList list = List.fold ( fun acc elem -> acc + elem) 0 list
//printfn "Sum of the elements of list %A is %d." [ 1..10](sumList[1..10])


//let seq1 = seq {1..10}
//printfn "The Sequence: %A" seq1

//let seq2 = seq {1..5..50}
//printfn "The Sequence: %A" seq2

//let seq3 = seq {50 .. -5 .. 0}
//printfn "The Sequence:　%A" seq3

//let seq4 = seq { for a in 1..10 do yield a,a*a,a*a*a}
//printfn "The Sequence: %A" seq4

//let isprime n =
//    let rec check i =
//        i > n/2 || (n%i<>0 && check(i+1))
//    check 2

//let primeIn50 = seq { for n in 1..50 do if isprime n then yield n }
//for x in primeIn50 do
//    printfn "%d" x

//let seq2 = Seq.init 5 (fun n-> n * 3)
//Seq.iter (fun i-> printf "%d " i) seq2
//printfn ""

//let seq3 =[| 2 ..2.. 200 |] |> Seq.ofArray
//Seq.iter (fun i-> printf "%d" i) seq3
//printfn ""

//let set1 = Set.empty.Add(3).Add(5).Add(7).Add(9)
//printfn "The new set: %A" set1

//let weekdays = Set.ofList ["mon"; "tunes";"wed";"thurs";"fri"]
//printfn "The list set; %A" weekdays

//let set2 = Set.ofSeq [1..2..10]
//printfn "The sequence set: %A" set2

//let a = Set.ofSeq [1..2..20 ]
//let b = Set.ofSeq [1..3..20]
//let c = Set.intersect a b
//let d = Set.union a b
//let e = Set.difference a b

//printf "Set a: "
//Set.iter (fun x-> printf "%O " x) a
//printfn""

//printf "Set b: "
//Set.iter (fun x-> printf "%O " x) b
//printfn""

//printfn "Set c = set intersect of a and b : "
//Set.iter (fun x -> printf "%O " x) c
//printfn""

//printfn "Set d = set union of a and b : "
//Set.iter (fun x -> printf "%O " x) d
//printfn""

//printfn "Set e = set difference of a and b : "
//Set.iter (fun x -> printf "%O " x) e
//printfn""

//let students =
//    Map.empty.
//        Add("Zara Ali", "1501").
//        Add("Robin Sahoo", "1503").
//        Add("Rishita Gupta", "1502");;
//printfn "Map - students: %A" students
//printfn "Map - students counts: %d" students.Count

//(* finding the registration number of a student *)
//let found = students.TryFind "Rishita Gupta"
//match found with 
//| Some x -> printfn "Found %s." x
//| None -> printfn "Did not found the specified value."


//type choice = 
//    | Yes
//    | No


//let x = Yes
//let y = No

//let main() =
//   printfn "x: %A" x
//   printfn "y: %A" y
//main()

//type VoltageState = 
//    | High
//    | Low

//let toggleSwitch = function 
//    | High -> Low
//    | Low -> High

//let main() =
//    let on = High
//    let off = Low
//    let change = toggleSwitch off

//    printfn "Switch on state: %A" on
//    printfn "Switch on state: %A" off
//    printfn "Toggle off: %A" change
//    printfn "Toggle the Change state: %A" (toggleSwitch change)
//main()

//Mutable Data
//open System
//type studentData = 
//    {
//        ID : int;
//        mutable IsRegistered :bool;
//        mutable RegisteredText: string;
//    }

//let getStudent id = 
//    { ID = id;
//        IsRegistered = false;
//        RegisteredText = null; }

//let registerStudents (students: studentData list) =
//    students |> List.iter(fun st ->
//        st.IsRegistered <- true
//        st.RegisteredText <- sprintf "Registered %s" (DateTime.Now.ToString("hh:mm:ss"))
//        Threading.Thread.Sleep(1000)
//    )
//let printData (students : studentData list) =
//    students |> List.iter (fun x-> printfn "%A" x)

//let main() =
//    let students = List.init 3 getStudent
//    printfn "Before Process:"
//    printData students

//    printfn "After process:"
//    registerStudents students
//    printData students
//    Console.ReadKey(true) |> ignore

//main()

////using semicolon separator
//let array1 = [| 1;2;3;4;5;6 |]
//for i in 0..array1.Length - 1 do
//    printf "%d " array1.[i]
//printf " "


//// without semicolon separator
//let array2 =
//    [|
//        1
//        2
//        3
//        4
//        5
//    |]

//for i in 0 .. array2.Length - 1 do
//    printf "%d " array2.[i]
//printfn ""

////using sequence 
//let array3 =[| for i in 1..10 -> i * i |]
//for i in 0.. array3.Length - 1 do
//    printf "%d " array3.[i]

//open System.Collections.Generic
//let booksList = new List<string>()
//booksList.Add("Gone with the Wind")
//booksList.Add("Atlas Shrugged")
//booksList.Add("Fountainhead")
//booksList.Add("Thornbirds")
//booksList.Add("Rebecca")
//booksList.Add("Narnia")

//booksList |> Seq.iteri (fun index item -> printfn "%i: %s" index booksList.[index])
