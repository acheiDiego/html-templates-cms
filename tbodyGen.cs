var table_meansureData = new List<dynamic>
    {
        new { meansure = "175/55R15", apply = "Dian/Tras", speedIndex = "H", chargeIndex = "75", presion = "40", calibration = "31" },
        new { meansure = "185/65R14", apply = "Dian/Tras", speedIndex = "H", chargeIndex = "74", presion = "39", calibration = "30" },
        new { meansure = "175/65R13", apply = "Dian/Tras", speedIndex = "H", chargeIndex = "75", presion = "38", calibration = "28" },
        new { meansure = "185/55R14", apply = "Dian/Tras", speedIndex = "H", chargeIndex = "71", presion = "41", calibration = "32" }
    };

string html_table_body (string row)
{
    var table_body = $"""
        <tbody id="meansure-tire-table">  
            {row}      
        </tbody>
        """;

    return table_body;
}
void create_table()
{
    string table_row = "";
    foreach (var row in table_meansureData)
    {
        table_row = table_row + $"""
    <tr class="table-data-row"> 
        <td class="table-cell row-data">{row.meansure}</td>  
        <td class="table-cell row-data">{row.apply}</td> 
        <td class="table-cell row-data">{row.speedIndex}</td> 
        <td class="table-cell row-data">{row.chargeIndex}</td> 
        <td class="table-cell row-data">{row.presion}</td>  
        <td class="table-cell row-data">{row.calibration}</td> 
    </tr>
    """;
    }

    var result = html_table_body(table_row);
    Console.WriteLine(result);
}

create_table();
