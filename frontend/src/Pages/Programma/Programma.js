import React from "react";
import Hero2 from "../Shared/Hero2";
import DataFetching from "../../api/FetchEvenementen.js";

const Programma = () => {
    return(
        <>
            <Hero2 tekst="Programma"/>
            <DataFetching/>
        </>
        
    );
}

export default Programma;