module AdventOfCode2020.RunAll

let runDay day run =
    printfn "====== Day %i ======" day
    Util.time run
    printfn ""

[<EntryPoint>]
let main argv =
    runDay 1 Day1.run
    runDay 2 Day2.run
    runDay 3 Day3.run
    0
