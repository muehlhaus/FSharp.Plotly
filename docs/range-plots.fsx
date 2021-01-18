(*** hide ***)

(*** condition: prepare ***)
#r @"..\packages\Newtonsoft.Json\lib\netstandard2.0\Newtonsoft.Json.dll"
#r "../bin/Plotly.NET/net5.0/Plotly.NET.dll"
(*** condition: fsx ***)
#if FSX
#r "../packages/Newtonsoft.Json/lib/netstandard2.0/Newtonsoft.Json.dll"
#r "../bin/Plotly.NET/net5.0/Plotly.NET.dll"
#endif // FSX
(*** condition: ipynb ***)
#if IPYNB
#r "nuget: Plotly.NET, 2.0.0-beta1"
#r "nuget: Plotly.NET.Interactive, 2.0.0-alpha5"
#endif // IPYNB

(** 
# Range plots

[![Binder](https://mybinder.org/badge_logo.svg)](https://mybinder.org/v2/gh/plotly/Plotly.NET/gh-pages?filepath=range-plots.ipynb)

*Summary:* This example shows how to create Range plot charts in F#.

let's first create some data for the purpose of creating example charts:

*)

open Plotly.NET 

let rnd = System.Random()

let x  = [1.; 2.; 3.; 4.; 5.; 6.; 7.; 8.; 9.; 10.; ]
let y = [2.; 1.5; 5.; 1.5; 3.; 2.5; 2.5; 1.5; 3.5; 1.]

let yUpper = y |> List.map (fun v -> v + rnd.NextDouble())
let yLower = y |> List.map (fun v -> v - rnd.NextDouble())

(**
A range plot is commonly used to indicate some property of data that lies in a certain range around a central value,
for example the range of all predictions from different models, scattering around a central tendency.
*)

let range1 =
    Chart.Range(
        x,y,yUpper,yLower,
        StyleParam.Mode.Lines_Markers,
        Color="grey",
        RangeColor="lightblue")

(*** condition: ipynb ***)
#if IPYNB
range1
#endif // IPYNB

(***hide***)
range1 |> GenericChart.toChartHTML
(***include-it-raw***)


