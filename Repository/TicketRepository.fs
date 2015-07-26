module FSharpBLOBA.Repository
open System
open FSharpBLOBA.Domain

let getAll () = 
    Seq.ofList[
        {Id = 1; Summary = ShortSummary "Something went wrong"; Details = "I was doing something and then this other thing happened and now it's broke"; OccurrenceDateTime = DateTime.Now; Priority = High; IsResolved = false; ResolutionDateTime = None };
        {Id = 2; Summary = ShortSummary "Something went wrong"; Details = "I was doing something and then this other thing happened and now it's broke"; OccurrenceDateTime = DateTime.Now; Priority = High; IsResolved = false; ResolutionDateTime = None };
        {Id = 3; Summary = ShortSummary "Something went wrong"; Details = "I was doing something and then this other thing happened and now it's broke"; OccurrenceDateTime = DateTime.Now; Priority = High; IsResolved = false; ResolutionDateTime = None };
    ]
