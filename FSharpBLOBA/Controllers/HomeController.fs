namespace FSharpBLOBA.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Web
open System.Web.Mvc
open System.Web.Mvc.Ajax

open Repository

type HomeController() =
    inherit Controller()
    member this.Index () = 
        this.View(Tickets.getAll ())

