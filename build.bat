dotnet publish TrafficManagementCenter.Server/TrafficManagementCenter.Server/TrafficManagementCenter.Server.csproj

dotnet publish TrafficManagementCenter.Server/TrafficManagementCenter.UI/TrafficManagementCenter.UI.csproj

mkdir buildArtifacts

xcopy /y /o /e "TrafficManagementCenter.Server\TrafficManagementCenter.Server\bin\Debug\netcoreapp3.1\publish" "buildArtifacts\webbApp\"

xcopy /y /o /e "TrafficManagementCenter.Server\TrafficManagementCenter.UI\bin\Debug\netcoreapp3.1\publish" "buildArtifacts\webbClient\"