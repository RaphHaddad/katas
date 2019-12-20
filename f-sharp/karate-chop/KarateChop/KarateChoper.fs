module KarateChoper

let chop number array =
    let findIndex item = 
        array
        |> Seq.findIndex (fun i -> i = item) 
    let rec chopRec number array = 
        match array with
        | [] -> -1
        | head::_ when head = number -> findIndex head
        | _::tail -> chopRec number tail
    chopRec number array
