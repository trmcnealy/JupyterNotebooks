#r "D:\TFS_Sources\Github\Compilation\trmcnealy\DataStorage\bin\Debug\netcoreapp3.1\Kokkos.NET.dll"
#r "D:\TFS_Sources\Github\Compilation\trmcnealy\DataStorage\bin\Debug\netcoreapp3.1\PostgreSql.NET.dll"
#r "D:\TFS_Sources\Github\Compilation\trmcnealy\DataStorage\bin\Debug\netcoreapp3.1\Engineering.Connector.dll"
#r "D:\TFS_Sources\Github\Compilation\trmcnealy\DataStorage\bin\Debug\netcoreapp3.1\Engineering.DataSource.dll"
#r "D:\TFS_Sources\Github\Compilation\trmcnealy\OilGas.Data\bin\Debug\netcoreapp3.1\OilGas.Data.dll"
#r "D:\TFS_Sources\Github\Compilation\trmcnealy\OilGas.Data\bin\Debug\netcoreapp3.1\OilGas.Data.RRC.Texas.dll"

#r "D:\TFS_Sources\Github\Compilation\trmcnealy\DataStorage\bin\Debug\netcoreapp3.1\Microsoft.AspNetCore.Html.dll"
#r "D:\TFS_Sources\Github\Compilation\trmcnealy\DataStorage\bin\Debug\netcoreapp3.1\Microsoft.AspNetCore.Html.Abstractions.dll"

using Engineering.DataSource.GeoSpatial;

ArcGIS map = new ArcGIS(1500,500);

map.Id.ToString();

map.GetHtml().ToString();