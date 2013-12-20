module Program

open System.Reflection
open TickSpec

let assembly = Assembly.GetExecutingAssembly()
let definitions = StepDefinitions(assembly)

let executeDefinition source = 
    let s = assembly.GetManifestResourceStream(source)
    match s with
    | null -> ()
    | _ -> definitions.Execute(source, s)

let executeFeature feature = [ feature ] |> Seq.iter executeDefinition

executeFeature "mutantCamelFeature.txt"