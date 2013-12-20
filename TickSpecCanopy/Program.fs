module Program

open System.Reflection
open TickSpec

let assembly = Assembly.GetExecutingAssembly()
let definitions = StepDefinitions(assembly)

let executeFeature featureFile = 
    let stream = assembly.GetManifestResourceStream(featureFile)
    match stream with
    | null -> raise (System.IO.FileNotFoundException(featureFile))
    | _ -> definitions.Execute(featureFile, stream)

executeFeature "mutantCamelFeature.txt"