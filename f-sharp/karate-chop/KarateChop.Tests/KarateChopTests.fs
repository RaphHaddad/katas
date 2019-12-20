module Tests

open Expecto
open KarateChoper

[<Tests>]
let tests =
  testList "Acceptance Tests" [

    let acceptanceTest expected number array =
      let actual = chop number array
      Expect.equal actual expected "didnt pass"

    testCase "Acceptance Tests" <| fun _ ->
      acceptanceTest -1 3 []
      acceptanceTest -1 3 [1]
      acceptanceTest 0 1 [1]
      acceptanceTest 0 1 [1; 3; 5]
      acceptanceTest 1 3 [1; 3; 5]
      acceptanceTest 2  5 [1; 3; 5]
      acceptanceTest -1 0 [1; 3; 5]
      acceptanceTest -1 2 [1; 3; 5]
      acceptanceTest -1 4 [1; 3; 5]
      acceptanceTest -1 6 [1; 3; 5]
      acceptanceTest 0 1 [1; 3; 5; 7]
      acceptanceTest 1 3 [1; 3; 5; 7]
      acceptanceTest 2 5 [1; 3; 5; 7]
      acceptanceTest 3 7 [1; 3; 5; 7]
      acceptanceTest -1 0 [1; 3; 5; 7]
      acceptanceTest -1 2 [1; 3; 5; 7]
      acceptanceTest -1 4 [1; 3; 5; 7]
      acceptanceTest -1 6 [1; 3; 5; 7]
      acceptanceTest -1 8 [1; 3; 5; 7]
  ]