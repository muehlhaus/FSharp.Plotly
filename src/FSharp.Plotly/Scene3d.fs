namespace FSharp.Plotly

module Scene3d =
    
    /// Scene 
    type Scene() = 
        inherit DynamicObj ()

        /// Initialized Scene object
        [<CompiledName("init")>]
        static member Init (apply:Scene->Scene) =
            Scene () |> apply

        // [<JsonIgnore>]
        /// Applies the styles to Scene()
        [<CompiledName("style")>]
        static member Style
            (   
                ?xAxis:Axis.LinearAxis,
                ?yAxis:Axis.LinearAxis,
                ?zAxis:Axis.LinearAxis,
                ?isSubplotObj     ,
                ?BgColor          
                // ?Camera           ,
                // ?Domain           ,
                // ?Aspectmode       ,
                // ?Aspectratio
            ) =
                (fun (scene:Scene) -> 
                    isSubplotObj |> DynObj.setValueOpt scene "_isSubplotObj"
                    BgColor      |> DynObj.setValueOpt scene "bgcolor"
                    
                    // Update
                    xAxis        |> DynObj.setValueOpt scene "xaxis"
                    yAxis        |> DynObj.setValueOpt scene "yaxis"
                    zAxis        |> DynObj.setValueOpt scene "zaxis"

                    // out ->
                    scene
                ) 




    /// Projection 
    type Projection() = 
        inherit DynamicObj ()
        
        /// Initialized Projection object
        [<CompiledName("init")>]
        static member Init (apply:Projection->Projection) =
            Projection () |> apply



