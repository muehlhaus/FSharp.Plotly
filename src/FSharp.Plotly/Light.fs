namespace FSharp.Plotly

/// Module containing plotly light modulation for 3d 
module Ligth =
     
    /// Lighting type inherits from dynamic object
    type Lighting () =
        inherit DynamicObj ()
        
        /// Initialized Lighting object
        [<CompiledName("init")>]
        static member Init (apply:Lighting->Lighting) =
            Lighting () |> apply

        // [<JsonIgnore>]
        /// Applies the styles to Lighting()
        [<CompiledName("style")>]
        static member Style
            (
                /// Epsilon for vertex normals calculation avoids math issues arising from degenerate geometry. Default 1e-12.
                ?Vertexnormalsepsilon : float,
                ?Facenormalsepsilon   : float,
                ?Ambient              : float,
                ?Diffuse              : float,
                ?Specular             : float,
                ?Roughness            : float,
                ?Fresnel              : float
            ) =
            
                (fun (lighting:('T :> Lighting)) -> 
                    Vertexnormalsepsilon |> DynObj.setValueOpt lighting "vertexnormalsepsilon"
                    Facenormalsepsilon   |> DynObj.setValueOpt lighting "facenormalsepsilon"
                    Ambient              |> DynObj.setValueOpt lighting "ambient"
                    Diffuse              |> DynObj.setValueOpt lighting "diffuse"
                    Specular             |> DynObj.setValueOpt lighting "specular"
                    Roughness            |> DynObj.setValueOpt lighting "roughness"
                    Fresnel              |> DynObj.setValueOpt lighting "fresnel"
           
                    lighting
                )



    /// Lighting type inherits from dynamic object
    type Lightposition () =
        inherit DynamicObj ()

        /// Initialized Lightposition object
        [<CompiledName("init")>]
        static member Init (apply:Lightposition->Lightposition) =
            Lightposition () |> apply

        /// Applies the styles to Lightposition()
        [<CompiledName("style")>]
        static member Style
            (
                ?X : int,
                ?Y : int,
                ?Z : int
            ) =
            
                (fun (lightposition:('T :> Lightposition)) -> 
                    X |> DynObj.setValueOpt lightposition "x"
                    Y |> DynObj.setValueOpt lightposition "y"
                    Z |> DynObj.setValueOpt lightposition "z"
           
                    lightposition
                )

