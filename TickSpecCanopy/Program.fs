module Program

open System
open System.IO
open System.Reflection
open TickSpec

let assembly = Assembly.GetExecutingAssembly()
let definitions = StepDefinitions(assembly)

let executeFeature featureFile = 
    let stream = assembly.GetManifestResourceStream(featureFile)
    match stream with
    | null -> raise (FileNotFoundException(featureFile))
    | _ -> definitions.Execute(featureFile, stream)

let featureFiles = 
    let features = assembly.GetManifestResourceNames() |> Seq.where (fun x -> x.EndsWith(".feature"))
    let wipFeatures = features |> Seq.where (fun x -> x.StartsWith("_"))
    if Seq.isEmpty wipFeatures then features else wipFeatures

featureFiles |> Seq.iter executeFeature