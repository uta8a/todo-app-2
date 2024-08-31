module tests

open NUnit.Framework
open todo.Add // referenced project's module

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    let result = add 2 3
    Assert.AreEqual(5, result)

open FsCheck

let prop_reverseTwiceIsOriginal (lst: int list) =
    reverse (reverse lst) = lst

[<Test>]
let Test2 () =
    Check.Quick prop_reverseTwiceIsOriginal
